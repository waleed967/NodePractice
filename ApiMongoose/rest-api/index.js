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


//Get
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

    const { id, name, city } = req.body;
    const post = new Post({
        id: id,
        name: name,
        city: city
    });

    post.save(function(err, newPost) {

        if (err) {
            return res.status(500).json({ err: err.message });
        }

        res.status(200).json({ msg: "Post Saved" });

    });
});

//Get

app.get("/posts/:postID", function(req, res) {


    const postID = req.params.postID;
    Post.findOne({ id: postID }, function(err, post) {

        if (err) {
            return res.status(500).json({ err: err.message });
        }

        if (post == null) return res.status(200).json({ msg: "No post found" });

        res.status(200).json({ post: post });
    });
});

//Put

app.put("/posts/:postID", function(req, res) {


    const postID = req.params.postID;

    const { name } = req.body;
    Post.findOneAndUpdate({ id: postID }, { name: name }, function(err, post) {

        if (err) {
            return res.status(500).json({ err: err.message });
        }



        res.status(200).json({ msg: "Name Updated" });
    });
});

//Delete

app.delete("/posts/:postID", function(req, res) {

    const postID = req.params.postID;

    Post.deleteOne({ id: postID }, function(err) {
        if (err) {
            return res.status(500).json({ err: err.message });
        }
        res.status(200).json({ msg: "post deleted" });

    });
});
//const PORT = 3000;
//app.listen(PORT, () => console.log("Server Started"));