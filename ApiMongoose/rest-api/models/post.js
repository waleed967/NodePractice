const mongoose = require("mongoose");

const PostSchema = new mongoose.Schema({
    id: Number,
    name: String,
    address: String,
    cnic: Number,
    country: String

});

module.exports = mongoose.model("Post", PostSchema);