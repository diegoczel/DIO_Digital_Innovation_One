
function getAdmins(m) {
  if(!m) return 'arg passed is empty or null or undefined';

  if(m[Symbol.toStringTag] !== 'Map') return 'arg passed Não é um Map';
  
  let arr = [];
  for(let i of m) {
    if(i[1].toLowerCase() === 'admin') arr.push(i[0]);
  }

  return arr;
}

const m = new Map();
m.set('diego', 'AdMin');
m.set('cris', 'admin');
m.set('tales', 'suporte');
console.log(getAdmins(m));
console.log(getAdmins('1'));
console.log(getAdmins());