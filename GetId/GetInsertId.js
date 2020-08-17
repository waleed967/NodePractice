var mysql = require('mysql');

var con = mysql.createConnection({
    host: "localhost",
    user: "root",
    password: "QWERTYuiop.7",
    database: "myEmployee"
});

con.connect(function(err) {
    if (err) throw err;
    console.log("Connected!");
    var sql = "INSERT INTO reporters (name, address) VALUES ('Rahim', 'WahCantt')";
    con.query(sql, function(err, result) {
        if (err) throw err;
        console.log("1 record inserted, ID: " + result.insertId);
    });
});