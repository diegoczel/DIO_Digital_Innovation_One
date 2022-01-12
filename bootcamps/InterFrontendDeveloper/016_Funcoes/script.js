const nome = "diego";

console.log(this);

( function () {
  console.log(this);
})();

// no navegador 
// this referece ao window