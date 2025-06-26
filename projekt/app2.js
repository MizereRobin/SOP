const express = require("express");
const mysql = require("mysql2/promise");
const jwt = require("jsonwebtoken");
const swaggerUi = require("swagger-ui-express");
const swaggerDocument = require("./swagger/swagger.json");
const { config } = require("./config/config.js");

const app = express();
const port = config.server.port;
const pool = mysql.createPool(config.database);
const secretKey = "titkos_kulcs_123";

const users = [
  { username: "admin", password: "admin123" },
  { username: "teszt", password: "pass" }
];

app.use(express.json());
app.use("/api-docs", swaggerUi.serve, swaggerUi.setup(swaggerDocument));

function authenticateToken(req, res, next) {
  const authHeader = req.headers["authorization"];
  const token = authHeader && authHeader.split(" ")[1];

  if (!token) return res.sendStatus(401);

  jwt.verify(token, secretKey, (err, user) => {
    if (err) return res.sendStatus(403);
    req.user = user;
    next();
  });
}

app.get("/", (req, res) => {
  res.send("Rádió API\nSwagger UI: http://localhost:3000/api-docs");
});
app.get("/megyek", async (req, res) => {
  try {
     const [rows] = await pool.execute(
      `SELECT megye FROM regio`
    );

    res.json(rows.map(row => row.megye));
  } catch (err) {
    res.status(500).json({ error: "Lekérdezési hiba." });
  }
});

app.get("/telepulesnev", async (req, res) => {
  try {
     const [rows] = await pool.execute(
      `SELECT nev FROM telepules`
    );

    res.json(rows.map(row => row.nev));
  } catch (err) {
    res.status(500).json({ error: "Lekérdezési hiba." });
  }
});


app.post("/login", (req, res) => {
  const { username, password } = req.body;
  const user = users.find(u => u.username === username && u.password === password);
  if (!user) return res.status(401).json({ error: "Hibás hitelesítés" });

  const token = jwt.sign({ username }, secretKey, { expiresIn: "1h" });
  res.json({ token });
});

app.post("/addtelepules", authenticateToken, async (req, res) => {
  try {
    const { telepules } = req.query;
    if (!telepules) {
      return res.status(400).json({ error: "Paraméter megadása kötelező!" });
    }

    const adatok = telepules.split("!");
    const [rows] = await pool.execute(
      `INSERT INTO telepules VALUES (?,?)`,
      [adatok[0], adatok[1]]
    );

    res.json({ message: "Sikeres beszúrás.", rows });
  } catch (err) {
    res.status(500).json({ error: "INSERT hiba." });
  }
});

app.post("/addkiosztas", authenticateToken, async (req, res) => {
  try {
    const { kiosztas } = req.query;
    if (!kiosztas) {
      return res.status(400).json({ error: "Paraméter megadása kötelező." });
    }

    const adatok = kiosztas.split("!");
    const [rows] = await pool.execute(
      `INSERT INTO kiosztas(frekvencia, csatorna, teljesitmeny, adohely, cim) VALUES (?,?,?,?,?)`,
      [adatok[0], adatok[1], adatok[2], adatok[3], adatok[4]]
    );

    res.json({ message: "Sikeres beszúrás.", rows });
  } catch (err) {
    res.status(500).json({ error: "INSERT hiba." });
  }
});

app.get("/sugarzasihely", async (req, res) => {
  try {
    const { telepules } = req.query;
    if (!telepules) {
      return res.status(400).json({ error: "telepules paraméter kötelező." });
    }

    const [rows] = await pool.execute(
      `SELECT DISTINCT cim FROM kiosztas WHERE adohely = ? AND cim IS NOT NULL GROUP BY cim`,
      [telepules]
    );

    res.json(rows.map(row => row.cim));
  } catch (err) {
    res.status(500).json({ error: "Lekérdezési hiba." });
  }
});

app.get("/teljesitmeny", async (req, res) => {
  try {
    const { adohely } = req.query;
    if (!adohely) {
      return res.status(400).json({ error: "adohely paraméter kötelező." });
    }

    const [rows] = await pool.execute(
      `SELECT csatorna, teljesitmeny FROM kiosztas WHERE adohely = ? ORDER BY teljesitmeny DESC`,
      [adohely]
    );

    res.json(rows);
  } catch (err) {
    res.status(500).json({ error: "Lekérdezési hiba." });
  }
});

app.get("/varosinallomasnev", async (req, res) => {
  try {
    const [rows] = await pool.execute(
      `SELECT csatorna FROM kiosztas WHERE csatorna LIKE CONCAT('%', adohely, '%')`
    );

    res.json(rows.map(row => row.csatorna));
  } catch (err) {
    res.status(500).json({ error: "Lekérdezési hiba." });
  }
});

app.listen(port, () => {
  console.log(`Server is running on http://localhost:${port}`);
});
