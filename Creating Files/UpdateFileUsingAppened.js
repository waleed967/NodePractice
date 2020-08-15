var fs = require('fs');
const { listenerCount } = require('process');

fs.appendFile('mynewfile1.txt', 'My Name Is Waleed!', function (err) {
  if (err) throw err;
  console.log('Updated!');
});
