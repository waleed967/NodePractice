var MongoClient = require('mongodb').MongoClient;
var url = "mongodb://localhost:27017/";

MongoClient.connect(url, function(err, db) {
    if (err) throw err;
    var dbo = db.db("myDepartment");
    var myquery = { name: /^H/ };
    dbo.collection("students").deleteMany(myquery, function(err, obj) {
        if (err) throw err;
        console.log(obj.result.n);
        db.close();
    });
});