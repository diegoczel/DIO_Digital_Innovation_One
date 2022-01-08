function soma(a, b) {
  let msg = `Os números ${a} e ${b}`;
  msg += (a === b) ? '' : ' não';
  msg += ' são iguais.';

  let s = a + b;

  msg += ` Sua soma é ${s}, que é`;
  msg += (s > 10) ? ' maior que' : (s < 10) ? ' menor que' : ' igual à';
  msg += ' 10 e';
  msg += (s > 20) ? ' maior que' : (s < 20) ? ' menor que' : ' igual à';
  msg += ' 20.';
  console.log(msg);
}

function numberEqual(a, b) {
  let msg = `Os números ${a} e ${b}`;
  msg += (a === b) ? '' : ' não';
  msg += ' são iguais. ';
  return msg;
}

function MaiorMenorQue(a, b) {
  let s = a + b;
  let msg = `Sua soma é ${s}, que é`;
  msg += (s > 10) ? ' maior que' : (s < 10) ? ' menor que' : ' igual à';
  msg += ' 10 e';
  msg += (s > 20) ? ' maior que' : (s < 20) ? ' menor que' : ' igual à';
  msg += ' 20.';
  return msg;
}

function sum(a, b) {
  if(isNaN(a) || isNaN(b)) {
    console.log("Por favor, informe um número válido!"); 
    return;
  }
  console.log(numberEqual(a, b) + MaiorMenorQue(a, b));
}
sum('a', 1);
sum(1, 'a');
sum(1, 2);
sum(5, 5);
sum(10, 10);
sum(10, 11);
sum(10, 9);

/*soma(1, 2);
soma(5, 5);
soma(10, 10);
soma(10, 11)
soma(10, 9)*/

