let farmAnimals: string[] = ["cow", "horse", "pig", "chicken", "horse", "sheep", "horse", "goat", "lamb"];

farmAnimals.sort(); // sorts in place cpu is forever changed to be sorted in ascending order

console.log(farmAnimals);



farmAnimals.reverse(); // reverse in place, cpus is forever changed to be in descending order

console.log(farmAnimals);



// toSorted, toReverse not allowed in TypeScript. 
// toSorted, toReverse only implemented on chromium based browsers

//var sortedArray = farmAnimals.toSorted();
//var reversedArray = farmAnimals.toReversed();