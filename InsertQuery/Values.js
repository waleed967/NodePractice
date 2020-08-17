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

    var sql = "INSERT INTO reporters(name , address) VALUES ('Hamza' , 'Wah Model Town')";
    con.query(sql, function(err, reult) {

        if (err) throw err;
        console.log("Values Inserted");

    });

});