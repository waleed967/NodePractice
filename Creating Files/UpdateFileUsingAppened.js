var fs = require('fs');


fs.appendFile('mynewfile3.txt', 'My Name Is Waleed!', function (err) {
  if (err) throw err;
  console.log('Updated!');
});
