const express = require('express');

const respuesta = require('../../red/respuestas');

const controlador = require('./controlador');

const router = express.Router();

router.get('/', function (req, res) {
    const alldata = controlador.alldata();
    respuesta.success(req, res, alldata, 200);
});

module.exports = router;