class Animal {
  constructor(type = 'animal') {
    this.type = type;
  }
  get type() {
    return this._type;
  }
  set type(value) {
    this._type = value;
  }
  makeSound() {
    console.log('animal sound');
  }
}

class Cat extends Animal {
  constructor() {
    super('cat');
  }
  makeSound() {
    super.makeSound();
    console.log("miau");
  }
}

let a1 = new Animal();
a1.makeSound();
a1.type = 'teste';
console.log(a1.type);