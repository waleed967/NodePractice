var MongoClient = require('mongodb').MongoClient;
var url = "mongodb://localhost:27017/";

MongoClient.connect(url, function(err, db) {
    if (err) throw err;
    var dbo = db.db("myDepartment");


    dbo.collection("students").find({}, { projection: { _id: 1, name: 3, address: 3 } }).toArray(function(err, res) {
        if (err) throw err;
        console.log(res);
        db.close();
    });
});