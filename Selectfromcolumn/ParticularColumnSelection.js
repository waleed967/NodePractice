var mysql = require('mysql');

var con = mysql.createConnection({
    host: "localhost",
    user: "root",
    password: "QWERTYuiop.7",
    database: "myEmployee"
});

con.connect(function(err) {
    if (err) throw err;
    con.query("SELECT * FROM reporters WHERE address = 'NewCity'", function(err, result) {
        if (err) throw err;
        console.log(result);
    });
});