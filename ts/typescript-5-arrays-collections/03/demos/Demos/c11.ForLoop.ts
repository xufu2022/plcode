
// loop through an array of numbers and print to the console.
let numbers: number[] = [3, 7, 2, 3, 4, 1, 7, 5];

// standard for loop
for(var i: number = 0; i < numbers.length; i++) {
    console.log(numbers[i]);
}

// for/in loop  prints index
for(let n in numbers ) {
    console.log(n, numbers[n]);
};

// for/of loop prints values
for(let n of numbers ) {
    console.log(n);
};
