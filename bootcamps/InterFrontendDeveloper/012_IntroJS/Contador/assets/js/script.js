let spanCurrent = document.getElementById('current-number');
let spanCurrent2 = document.getElementById('current-number2');
let spanCurrent3 = document.getElementById('current-number3');



let currentValue = 0;
let currentValue2 = 0;
let currentValue3 = 0;
spanCurrent2.style.color = '#ff0000';

let but2Dec = document.getElementById('but2Dec');
but2Dec.disabled = true;
let but2Inc = document.getElementById('but2Inc');


//let butDec2 = document.getElementsByName('subtrair2')[0];
//butDec2.disabled = true;

function increment() {
  currentValue += 1;
  spanCurrent.innerHTML = currentValue;
}

function decrement() {
  currentValue -= 1;
  spanCurrent.innerHTML = currentValue;
}

function increment2() {
  
  if (currentValue2 === 9) {
    spanCurrent2.style.color = '#00ff00';
  } else {
    spanCurrent2.style.color = '#000000';
  }

  if (currentValue2 === 0) {
    but2Dec.disabled = false;
  }

  currentValue2 += 1;
  spanCurrent2.innerHTML = currentValue2;

  if (currentValue2 === 10) {
    but2Inc.disabled = true;
  }
}

function decrement2() {
  if (currentValue2 === 1) {
    spanCurrent2.style.color = '#ff0000';
  } else {
    spanCurrent2.style.color = '#000000';
  }

  if (currentValue2 === 10) {
    but2Inc.disabled = false;
    
  }

  currentValue2 -= 1;
  spanCurrent2.innerHTML = currentValue2;
  
  if (currentValue2 === 0) {
    but2Dec.disabled = true;
  }
}

function increment3() {
  currentValue3 += 1;
  spanCurrent3.innerHTML = currentValue3;
}

function decrement3() {
  currentValue3 -= 1;
  spanCurrent3.innerHTML = currentValue3;
}

document.getElementById('but3Dec').addEventListener("click", decrement3);
document.getElementById('but3Inc').addEventListener("click", increment3);