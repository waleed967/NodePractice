var mysql = require('mysql');
var con = mysql.createConnection({
    host: "localhost",
    user: "root",
    password: "QWERTYuiop.7",
    database: "myEmployee"
});

con.connect(function(err) {

    if (err) throw err;
    console.log("Connected!")


    var sql = "CREATE TABLE CUSTOMERS (name VARCHAR(255), address VARCHAR(255))";

    con.query(sql, function(err, result) {
        if (err) throw err;
        console.log("Table created");
    });

});