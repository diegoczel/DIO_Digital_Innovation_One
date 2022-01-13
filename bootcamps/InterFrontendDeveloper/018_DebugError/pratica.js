function arrIsLen(arr, n) {
  // is array.length === n
  try {
    
    // arg ausente
    if(arguments.length === 0 || !arr || !n) throw ReferenceError("arg array and/or arg n, it's not present.");
    // arg array não é do type array
    if(!Array.isArray(arr)) throw TypeError("arg array is not of type array");
    // arg n não é do type number
    if(isNaN(Number(n))) throw TypeError("arg n is not of type number");
    // arr.length é diferente de n
    if(arr.length !== n) {
      throw RangeError("length of array is different of n");
    } else {// significa que arr.length === n
      //return true;
      console.log('true');
    }

  } catch(e)  {
    // TODO multi catch using instanceof
    console.log(e.name, '-', e.message);
  } 
}

//arrIsLen();
arrIsLen([1, 2, 3]);
arrIsLen([1, 2, 3], 3);
arrIsLen([1, 2, 3], 2);
arrIsLen([1, 2, 3], 'a');
arrIsLen('a', 2);