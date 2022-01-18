class Conta {
  constructor(agencia, numero, tipo, saldo = 0) {
    this.agencia = agencia;
    this.numero = numero;
    this.tipo = tipo;
    this.saldo = saldo;
  }

  get saldo() {
    return this._saldo;
  }

  set saldo(value) {
    this._saldo = value;
  }
  sacar(v) {
    if(v > this._saldo) {
      console.log("valor superior ao saque.");
    } else {
      console.log(`Sacado: R$ ${v}`);
      this._saldo -= v;
    }
  }

  depositar(v) {
    this._saldo += v;
    console.log(`Depositado ${v} na conta.`);
  }
}

class Corrente extends Conta {
  constructor(agencia, numero, saldo, credito) {
    super(agencia, numero,"Corrente", saldo);
    this.credito = credito;
  }
  get credito() {
    return this._credito;
  }
  set credito(value) {
    this._credito = value;
  }
}

class Poupanca extends Conta {
  constructor(agencia, numero, saldo) {
    super(agencia, numero,"poupança", saldo);
  }
}

class Universitaria extends Conta {
  constructor(agencia, numero, saldo) {
    super(agencia, numero, "universitaria", saldo);
  }
  sacar(v) {
    if(v > 500) {
      console.log("Valor superior, só permite < 500");
    } else if(v > this._saldo) {
      console.log("valor superior ao saque.");
    } else {
      console.log(`Sacado: R$ ${v}`);
      this._saldo -= v;
    }
  }
}

const conta = new Conta(1, 666, '', 100);
console.log(conta.saldo);
conta.depositar(1);
conta.sacar(10);
console.log(conta.saldo);

const corrente = new Corrente(1, 6, 1000, true);
const poupanca = new Poupanca(1, 7, 500);
const universitaria = new Universitaria(1, 9, 400);
console.log(corrente.saldo);
corrente.sacar(90);
console.log(poupanca.saldo);
poupanca.sacar(300);
console.log(universitaria.saldo);
universitaria.sacar(200);