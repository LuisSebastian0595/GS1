const express = require('express');
const config = require('./config');

const inventario = require('./modulos/inventario/rutas')

const app = express();

//Configuración del puerto
app.set('port', config.app.port)

app.use('/api/inventario', inventario)

module.exports = app;