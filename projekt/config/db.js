const { Sequelize } = require("sequelize");

const sequelize = new Sequelize("radio", "root", "", {
  host: "localhost",
  dialect: "mysql",
  port: 3306,
  logging: true,
});

module.exports = sequelize;
