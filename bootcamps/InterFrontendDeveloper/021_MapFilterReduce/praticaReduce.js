// some all numbers of array using reduce

const fun1 = (total, current) => {
  //console.log(total, current);
  return total - current;
}

console.log([175, 50, 25].reduce(fun1, 0));// initial value
console.log([175, 50, 25].reduce(fun1));