const mysql = require('mysql');
const config = require('../config');

const prueba = {
    id: 1,
    nombre: 'juan',
    edad: 43
}

function alldata(tabla){
    return prueba;
}

function one(tabla, id){

}

function agregar(tabla, data){

}

function eliminar(tabla, id){

}

module.exports = {
    alldata,
    one,
    agregar,
    eliminar,
}