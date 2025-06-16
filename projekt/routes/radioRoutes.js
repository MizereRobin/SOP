const express = require("express");
const { Op } = require("sequelize");
const Radio = require("../models/radio");

const router = express.Router();

// 1. Egy település adóinak sugárzási helyei
router.get("/kiosztas", async (req, res) => {
  const { city } = req.query;
  try {
    const kiosztas = await Radio.findAll({
      where: { adohely: city },
      attributes: ["adohely"],
      group: ["adohely"],
    });
    res.json(kiosztas);
  } catch (err) {
    res.status(500).json({ error: err.message });
  }
});

// 2. Egy helyről sugárzott rádiók listája
router.get("/kiosztas/from", async (req, res) => {
  const { adohely } = req.query;
  try {
    const kiosztas = await Radio.findAll({
      where: { adohely: adohely },
      attributes: ["csatorna", "teljesitmeny"],
      order: [["teljesitmeny", "DESC"]],
    });
    res.json(kiosztas);
  } catch (err) {
    res.status(500).json({ error: err.message });
  }
});

// 3. Rádiók, amelyek nevében szerepel a település neve
router.get("/kiosztas/with-city-name", async (req, res) => {
  try {
    const kiosztas = await Radio.findAll({
      where: {
        radio_name: { [Op.like]: Sequelize.col("broadcast_location") },
      },
    });
    res.json(kiosztas);
  } catch (err) {
    res.status(500).json({ error: err.message });
  }
});

module.exports = router;
