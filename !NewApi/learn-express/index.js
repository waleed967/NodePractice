const express = require("express")
const mongoose = require("mongoose") // new
const routes = require("./routes")
const Post = require("./models/post")
const bodyParser = require("body-parser")

const router = express.Router()

// Connect to MongoDB database
mongoose
    .connect("mongodb://localhost:27017/Student",

        {

            useNewUrlParser: true

        })
    .then(() => {
        const app = express()
        app.use(bodyParser.json())
        app.use("/api", router) // new
        app.listen(3000, () => {
            console.log("Server has started!")
        });
    });


router.get("/posts", async(req, res) => {

    const posts = await Post.find()
    res.send(posts)
});


router.post("/posts", async(req, res) => {
    const post = new Post({
        title: req.body.title,
        content: req.body.content
    })
    await post.save()
    res.send(post)
});

router.get("/posts/:title", async(req, res) => {
    const post = await Post.findOne({ title: req.params.title })
    res.send(post)
});


router.patch("/posts/:title", async(req, res) => {
    try {
        const post = await Post.findOne({ title: req.params.title })

        if (req.body.title) {
            post.title = req.body.title
        }

        if (req.body.content) {
            post.content = req.body.content
        }

        await post.save()
        res.send(post)
    } catch {
        res.status(404)
        res.send({ error: "Post doesn't exist!" })
    }
});


router.delete("/posts/:title", async(req, res) => {
    try {
        await Post.deleteOne({ title: req.params.title })
        res.status(204).send()
    } catch {
        res.status(404)
        res.send({ error: "Post doesn't exist!" })
    }
});
module.exports = router