// original array
let addRemove: number[] = [3, 6];

// add two items to the array using the push function.
addRemove.push(5, 2);
addRemove.push(1);

addRemove.unshift(20, 40);
addRemove.unshift(30);

// contents of array after all the adding
console.log(addRemove);

// pop  --------------------
addRemove.pop(); // remove 1 item from the end of the array

// the popped value can be saved to a variable
let popRemove: number | undefined = addRemove.pop(); 


// shift -------------
addRemove.shift(); // remove 1 item from the beginning of the array

// the shifted value can be saved to a variable
let shiftRemove: number | undefined = addRemove.shift();

// contents of array after all the adding and removing
console.log(addRemove);

// stored values from a pop and a shift
console.log(popRemove, ' - removed by pop');
console.log(shiftRemove, ' - removed by shift');
