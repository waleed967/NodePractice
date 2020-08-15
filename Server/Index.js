var http = require('http');

http.createServer(function (req, res) {
    console.log(req.headers)
  res.writeHead(200, {'Content-Type': 'text/plain'});
  res.end('Hello to!');
}).listen(8080);