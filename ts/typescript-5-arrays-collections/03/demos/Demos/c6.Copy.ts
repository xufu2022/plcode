// original
let originalArray: number[] = [3, 7, 2];

// copy using concat, slice and spread operator
//let newArray = originalArray;
//let newArray = originalArray.concat(); 
//let newArray = originalArray.slice();
let newArray = [...originalArray];

// modify newly copied arrat
newArray.push(100); 

console.log(originalArray);
console.log(newArray);
