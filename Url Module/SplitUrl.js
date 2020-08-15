var url = require('url');
var add = 'http://localhost:8080/default.htm?year=2017&month=february';
var p = url.parse(add, true);


console.log(p.host); //returns 'localhost:8080'
console.log(p.pathname); //returns '/default.htm'
console.log(p.search); //returns '?year=2017&month=february'

var pdata = p.query; //returns an object: { year: 2017, month: 'february' }
console.log(pdata.month); //returns 'february'
console.log(pdata.year); // returns '2017'