var MongoClient = require('mongodb').MongoClient;
var url = "mongodb://localhost:27017/";

MongoClient.connect(url, function(err, db) {
    if (err) throw err;
    var dbo = db.db("myDepartment");
    var myquery = { name: /^A/ };
    var newvalues = { $set: { address: "Lahore" } };
    dbo.collection("students").updateMany(myquery, newvalues, function(err, res) {
        if (err) throw err;
        console.log("Replaced");
        db.close();
    });
});