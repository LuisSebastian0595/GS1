const db = require('../../DB/mysql');

const TABLA = 'inventario';

function alldata () {
    return db.alldata(TABLA);
}

module.exports = {
    alldata,
}