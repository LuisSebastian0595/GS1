const app = require('./app');

app.listen(app.get('port'), ()=> {
    console.log("Servidor ejecutando en http://localhost:3000", app.get("port"));
});