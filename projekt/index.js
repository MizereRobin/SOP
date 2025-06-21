const express = require('express');
const radioRoutes = require('./routes/radioRoutes');
const swaggerUi = require('swagger-ui-express');
const fs = require('fs');
const cors = require('cors');

const app = express();
app.use(cors());
app.use(express.json());

const swaggerDocument = JSON.parse(fs.readFileSync('./swagger.json', 'utf-8'));

app.use('/api-docs', swaggerUi.serve, swaggerUi.setup(swaggerDocument));

app.use('/kiosztas', radioRoutes);

const PORT = 3000;
app.listen(PORT, () => {
  console.log(`Server is running on http://localhost:${PORT}`);
});
