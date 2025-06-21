const express = require("express");
const mysql = require("mysql2/promise");
const swaggerUi = require("swagger-ui-express");
const swaggerDocument = require("./swagger/swagger.json");
const { config } = require("./config/config.js");

const app = express();
const port = config.server.port;

const pool = mysql.createPool(config.database);

app.use(express.json());
app.use("/api-docs", swaggerUi.serve, swaggerUi.setup(swaggerDocument));

app.get("/", (req, res) => {
  res.send("Rádió API");
});

app.get("/sugarzasihely", async (req, res) => {
  try {
    const { telepules } = req.query;
    if (!telepules) {
      return res.status(400).json({ error: "telepules paraméter kötelező." });
    }

    const [rows] = await pool.execute(
      `SELECT DISTINCT cim, csatorna, frekvencia
       FROM kiosztas
       WHERE adohely = ? AND cim IS NOT NULL
       GROUP BY cim`,
      [telepules]
    );

    res.json(rows.map(row => row.cim));
  } catch (err) {
    console.error("Hiba /sugarzasihely alatt:", err);
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
      `SELECT csatorna, teljesitmeny
       FROM kiosztas
       WHERE adohely = ?
       ORDER BY teljesitmeny DESC`,
      [adohely]
    );

    res.json(rows);
  } catch (err) {
    console.error("Hiba /teljesitmeny alatt:", err);
    res.status(500).json({ error: "Lekérdezési hiba." });
  }
});

app.get("/varosinallomasnev", async (req, res) => {
  try {
    const [rows] = await pool.execute(
      `SELECT csatorna
       FROM kiosztas
       WHERE csatorna LIKE CONCAT('%', adohely, '%')`
    );

    res.json(rows.map(row => row.csatorna));
  } catch (err) {
    console.error("Hiba /varosinallomasnev alatt:", err);
    res.status(500).json({ error: "Lekérdezési hiba." });
  }
});

// POST lesz ha megcsinálom
app.get("/teljesitmeny", async (req, res) => {
  try {
    const { adohely } = req.query;
    if (!adohely) {
      return res.status(400).json({ error: "adohely paraméter kötelező." });
    }

    const [rows] = await pool.execute(
      `SELECT csatorna, teljesitmeny
       FROM kiosztas
       WHERE adohely = ?
       ORDER BY teljesitmeny DESC`,
      [adohely]
    );

    res.json(rows);
  } catch (err) {
    console.error("Hiba /teljesitmeny alatt:", err);
    res.status(500).json({ error: "Lekérdezési hiba." });
  }
});


app.listen(port, () => {
  console.log(`Server is running on http://localhost:${port}`);
  console.log(`Swagger UI available at http://localhost:${port}/api-docs`);
});


