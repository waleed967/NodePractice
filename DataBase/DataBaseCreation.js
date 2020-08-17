var mysql = require('mysql')
var con = mysql.createConnection({
    host: "localhost",
    user: "root",
    password: "QWERTYuiop.7"

});

con.connect(function(err)

    {
        if (err) throw err;
        console.log("Connected!");

        con.query('CREATE DATABASE myEmployee', function(err, result) {
            if (err) throw err;
            console.log("DataBase is Created!");

        });
    });