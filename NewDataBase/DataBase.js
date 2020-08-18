var mysql = require('mysql');

var con = mysql.createConnection({
    host: "localhost",
    user: "root",
    password: "QWERTYuiop.7",
    database: "myDepartment"
});

con.connect(function(err) {
    if (err) throw err;
    console.log("Connected!");
    var sql = "SELECT students.name AS student, teachers.name AS teacher FROM students RIGHT JOIN teachers ON students.sid = teachers.tid";
    con.query(sql, function(err, result) {
        if (err) throw err;
        console.log(result);
    });
});