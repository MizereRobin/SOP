const express = require("express");
const mysql = require("mysql2/promise");
const swaggerUi = require("swagger-ui-express");
const swaggerDocument = require("swagger.json");
const { config } = require("../config.js");

const app = express();
const port = config.server.port;

// MySQL adatbázis kapcsolat
const pool = mysql.createPool(config.database);

// Middleware
app.use(express.json());
app.use("/api-docs", swaggerUi.serve, swaggerUi.setup(swaggerDocument));

// Főoldal
app.get("/", (req, res) => {
  res.send("Rádió API");
});

// 1. Végpont: Sugárzási címek lekérdezése város alapján
app.get("/radios", async (req, res) => {
  try {
    const { city } = req.query;
    if (!city) {
      return res.status(400).json({ error: "City parameter is required." });
    }

    const [rows] = await pool.execute(
      "SELECT DISTINCT broadcast_address FROM radios WHERE broadcast_location = ?",
      [city]
    );
    res.json(rows.map(row => row.broadcast_address));
  } catch (err) {
    console.error(`Error fetching broadcast addresses: ${err}`);
    res.status(500).json({ error: "Failed to fetch broadcast addresses." });
  }
});

// 2. Végpont: Rádiók listázása egy helyről teljesítmény szerint
app.get("/radios/from", async (req, res) => {
  try {
    const { location } = req.query;
    if (!location) {
      return res.status(400).json({ error: "Location parameter is required." });
    }

    const [rows] = await pool.execute(
      "SELECT radio_name, power FROM radios WHERE broadcast_location = ? ORDER BY power DESC",
      [location]
    );
    res.json(rows);
  } catch (err) {
    console.error(`Error fetching radios by location: ${err}`);
    res.status(500).json({ error: "Failed to fetch radios." });
  }
});

// 3. Végpont: Rádiók listázása, amelyek nevében szerepel a város neve
app.get("/radios/with-city-name", async (req, res) => {
  try {
    const [rows] = await pool.execute(
      "SELECT radio_name FROM radios WHERE radio_name LIKE CONCAT('%', broadcast_location, '%')"
    );
    res.json(rows.map(row => row.radio_name));
  } catch (err) {
    console.error(`Error fetching radios with city name: ${err}`);
    res.status(500).json({ error: "Failed to fetch radios." });
  }
});

// Szerver indítása
app.listen(port, () => {
  console.log(`Server is running on http://localhost:${port}`);
  console.log(`Swagger UI available at http://localhost:${port}/api-docs`);
});
