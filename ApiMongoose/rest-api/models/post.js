const mongoose = require("mongoose");

const PostSchema = new mongoose.Schema({
    id: Number,
    tile: String,
    body: String
});

module.exports = mongoose.model("Post", PostSchema);