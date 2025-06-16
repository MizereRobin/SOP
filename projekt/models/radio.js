const { Sequelize, DataTypes } = require("sequelize");
const sequelize = require("../config/db");

const Radio = sequelize.define("Radio", {
    azon: { type: DataTypes.INTEGER, allowNull: false },
    csatorna: { type: DataTypes.STRING, allowNull: false },
  adohely: { type: DataTypes.STRING, allowNull: false },
  cim: { type: DataTypes.STRING, allowNull: true },
  teljesitmeny: { type: DataTypes.INTEGER, allowNull: false },
  frekvencia: { type: DataTypes.INTEGER, allowNull: false },
});

module.exports = Radio;
