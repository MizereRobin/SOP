module.exports = {
  config: {
    server: {
      port: 3000
    },
    database: {
      host: "localhost",
      user: "root",
      password: "",
      database: "sop_db",
      waitForConnections: true,
      connectionLimit: 10,
      queueLimit: 0
    }
  }
};
