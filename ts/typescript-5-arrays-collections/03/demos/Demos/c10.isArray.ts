let testValue:string = 'Sort me';

// some function can be used on string.
console.log(testValue.indexOf('r'));

// sample variables to test if their contents is an array
//let testVariable: string = "Am I an array?";
let testVariable: number[] = [3, 7, 2];

if(Array.isArray(testVariable)) {
    console.log("Hooray, an array!");
} else {
    console.log("Not an array.");
}
