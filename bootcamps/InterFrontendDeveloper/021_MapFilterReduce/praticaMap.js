// pratique efetuando uma *. Uma vez usando this e outra sem
const mul1 = {
  v: 4
};

const array = [1, 2, 3, 4, 5];

const fun1 = (item) => item * 2;

const fun2 = (item, index, arr) => {
  console.log(item, index, arr);
  return item * 2;
};

//const fun3 = (item) => { // this dont work ???
const fun3 = function (item) {
  //console.log(this);
  // this é passado para a function callback
  // então nesse caso, consigo acessar uma propriedade de um object
  // e aplicar algum processamento em cada element do array
  return item * this.v;
};
console.log(array.map(fun1));
console.log(array.map(fun2));
console.log(array.map(fun3, mul1));
