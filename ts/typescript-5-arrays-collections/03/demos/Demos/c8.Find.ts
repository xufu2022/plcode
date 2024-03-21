let animals: string[] = ["cow", "horse", "pig", "chicken", "horse", "sheep", "horse", "goat", "lamb"];

// find index of certain value in array
let horseIndex: number = animals.indexOf("horse");

console.log(horseIndex);

// find another index
let nextHorse: number = animals.indexOf('horse', horseIndex+1);
let lastHorse: number = animals.indexOf('horse', -2);

console.log(nextHorse);
console.log(lastHorse);



// find the last index of a certain value in the array
let horseIndex2: number = animals.lastIndexOf("horse");

console.log(horseIndex2);



// includes ------------------------------
let inArray: boolean = animals.includes('pig');
console.log(inArray);

inArray = animals.includes('pig', 3); // search starting at index 2
console.log(inArray);

inArray = animals.includes('pig', -5); // search starting at index 2
console.log(inArray);