const f1 = function () {
  throw "Error criado";
}
const f2 = function () {
  return "Return criado";
}
console.log(f2());
console.log(f1());