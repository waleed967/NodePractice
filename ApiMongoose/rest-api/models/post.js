const mongoose = require("mongoose");

const PostSchema = new mongoose.Schema({
    id: Number,
    name: String,
    city: String
});

module.exports = mongoose.model("Post", PostSchema);