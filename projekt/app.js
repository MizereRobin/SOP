const express = require("express");
const bodyParser = require("body-parser");
const swaggerUi = require("swagger-ui-express");
const swaggerDocument = require("swagger.json");

const app = express();
const PORT = 3000;

// Middleware
app.use(bodyParser.json());
app.use("/api-docs", swaggerUi.serve, swaggerUi.setup(swaggerDocument));

// Mock adatok
const radios = [
  { radio_name: "Budapest FM", broadcast_location: "Budapest", broadcast_address: "Main St 1", power: 1000 },
  { radio_name: "Miskolc Radio", broadcast_location: "Miskolc", broadcast_address: "Downtown 2", power: 800 },
  { radio_name: "Debrecen Waves", broadcast_location: "Debrecen", broadcast_address: "Central 3", power: 500 }
];

// Endpointok
app.get("/radios", (req, res) => {
  const city = req.query.city;
  const result = radios
    .filter(radio => radio.broadcast_location === city)
    .map(radio => radio.broadcast_address);
  res.json([...new Set(result)]); // Egyedi címek
});

app.get("/radios/from", (req, res) => {
  const location = req.query.location;
  const result = radios
    .filter(radio => radio.broadcast_location === location)
    .sort((a, b) => b.power - a.power)
    .map(radio => ({ radio_name: radio.radio_name, power: radio.power }));
  res.json(result);
});

app.get("/radios/with-city-name", (req, res) => {
  const result = radios
    .filter(radio => radio.radio_name.includes(radio.broadcast_location))
    .map(radio => radio.radio_name);
  res.json(result);
});

// Indítás
app.listen(PORT, () => {
  console.log(`Szerver fut: http://localhost:${PORT}`);
  console.log(`Swagger UI: http://localhost:${PORT}/api-docs`);
});
