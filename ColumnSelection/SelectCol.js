var mysql = require('mysql');

var con = mysql.createConnection({
    host: "localhost",
    user: "root",
    password: "QWERTYuiop.7",
    database: "myEmployee"
});

con.connect(function(err) {
    if (err) throw err;
    con.query("SELECT name FROM reporters", function(err, result, fields) {
        if (err) throw err;
        console.log(result);
    });
});