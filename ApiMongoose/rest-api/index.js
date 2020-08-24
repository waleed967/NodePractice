const express = require("express");
const mongoose = require("mongoose");

const app = express();

app.use(express.json());

mongoose
    .connect("mongodb://localhost:27017/Post", {

        useNewUrlParser: true,
        useUnifiedTopology: true,
    })
    .then(() => console.log("Connected to MongoDb"))
    .catch((err) => console.log(err));
const PORT = 3000;
app.listen(PORT, () => console.log("Started"));


//Get All Info 
const Post = require("./models/post");

app.get("/posts", function(req, res) {
    Post.find(function(err, posts) {
        if (err) {
            return res.status(500).json({ error: err.message });
        }
        res.status(200).json({ posts: posts });
    });
});

//Post
app.post("/posts", function(req, res) {

    const { id, name, address, cnic, country } = req.body;
    const post = new Post({
        id: id,
        name: name,
        address: address,
        cnic: cnic,
        country: country
    });

    post.save(function(err, newPost) {

        if (err) {
            return res.status(500).json({ err: err.message });
        }

        res.status(200).json({ msg: "Post Saved" });

    });
});

//Get Info by Name

app.get("/posts/:postNAME", function(req, res) {


    const postNAME = req.params.postNAME;
    Post.findOne({ name: postNAME }, function(err, post) {

        if (err) {
            return res.status(500).json({ err: err.message });
        }

        if (post == null) return res.status(200).json({ msg: "No post found" });

        res.status(200).json({ post: post });
    });
});

//Put Updated Info by Name

app.put("/posts/:postNAME", function(req, res) {


    const postNAME = req.params.postNAME;

    const { id } = req.body;
    const { name } = req.body;
    const { address } = req.body;
    const { cnic } = req.body;
    const { country } = req.body;

    Post.findOneAndUpdate({ name: postNAME }, { id: id, name: name, address: address, cnic: cnic, country: country }, function(err, post) {

        if (err) {
            return res.status(500).json({ err: err.message });
        }



        res.status(200).json({ msg: "Name Updated" });
    });
});

//Delete Info by Name 

app.delete("/posts/:postNAME", function(req, res) {

    const postNAME = req.params.postNAME;

    Post.deleteOne({ name: postNAME }, function(err) {
        if (err) {
            return res.status(500).json({ err: err.message });
        }
        res.status(200).json({ msg: "post deleted" });

    });
});
//const PORT = 3000;
//app.listen(PORT, () => console.log("Server Started"));