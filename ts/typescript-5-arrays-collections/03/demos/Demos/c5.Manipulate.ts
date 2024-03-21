// original arrays
let aOne: number[] = [3, 7, 2];
let aTwo: number[] = [40, 10, 80];
let aThree: number[] = [900, 600, 500];
let aFour: number[] = [3, 7, 2, 9, 4, 1, 8, 5];

// concat - combining arrays
let cOne: number[] = aOne.concat(aTwo);
let cTwo: number[] = aOne.concat(aTwo, aThree);

// console.log(aOne, aTwo, aThree);
// console.log(cOne);
// console.log(cTwo)

// Slice - combining arrays
let sOne: number[] = aFour.slice(2); // 4,1,8,5
let sTwo: number[] = aFour.slice(4, 5); // 4
let sThree: number[]= aFour.slice(-2); // 8,5
let sFour: number[] = aFour.slice(2, 1); // count from the end


console.log(aFour);
console.log(sOne);
console.log(sTwo);
console.log(sThree);
console.log(sFour);
