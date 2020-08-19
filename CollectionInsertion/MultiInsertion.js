var MongoClient = require('mongodb').MongoClient;
var url = "mongodb://localhost:27017/";

MongoClient.connect(url, function(err, db) {
    if (err) throw err;
    var dbo = db.db("myDepartment");

    var myobj = [
        { name: 'Waleed', address: 'NewCity' },
        { name: 'Hamza', address: 'WahModelTown' },
        { name: 'Adeel', address: 'WahCantt' },
        { name: 'Qamar', address: 'NewCity' }
    ];
    dbo.collection("students").insertMany(myobj, function(err, res) {
        if (err) throw err;
        console.log("Number Of Records Inserted" + res.insertedCount);
        db.close();
    });
});