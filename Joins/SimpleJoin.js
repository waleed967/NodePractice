var mysql = require('mysql');

var con = mysql.createConnection({
    host: "localhost",
    user: "root",
    password: "QWERTYuiop.7",
    database: "myEmployee"
});

con.connect(function(err) {
    if (err) throw err;
    var sql = "SELECT users.name AS user, products.name AS product FROM users JOIN products ON users.fv_product = products.pid";
    con.query(sql, function(err, result) {
        if (err) throw err;
        console.log(result);
    });
});