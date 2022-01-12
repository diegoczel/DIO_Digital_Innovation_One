const obj1 = {
  nome: "diego"
};

const obj2 = {
  nome: "cris"
};

function get1() {
  console.log(this);
}

function get2() {
  console.log(this.nome);
}

/*
// this faz a referencia a function
get1();
get1.call();
*/
// this faz a referencia para obj1
get1.call(obj1);

get2.call(obj2);

const point = {
  x: 1,
  y: 2
};

function sum(x, y) {
  if(this.x === undefined || this.y === undefined) {
    console.log(arguments)
    return x + y;

  }
  console.log(arguments)
  console.log(this.x + this.y + x + y);
}

console.log(sum(0, 1));
console.log(sum.call(0, 1));
console.log(sum.call(point, 5, 6));

const myObj = {
  num1: 2,
  num2: 4
};

function soma(a, b) {
  console.log(this.num1 + this.num2 + a + b);
}
soma.call(myObj, 1, 5);