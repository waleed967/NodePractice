var mysql = require('mysql');

var con = mysql.createConnection({
    host: "localhost",
    user: "root",
    password: "QWERTYuiop.7",
    database: "myEmployee"
});

con.connect(function(err) {
    if (err) throw err;
    var sql = "UPDATE reporters SET name = 'Waleed' WHERE id = '2'";
    con.query(sql, function(err, result) {
        if (err) throw err;
        console.log(result.affectedRows + " record(s) updated");
    });
});