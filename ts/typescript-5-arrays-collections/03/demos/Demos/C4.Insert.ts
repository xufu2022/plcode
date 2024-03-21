// original array
let insertElements: number[] = [1, 2, 4, 7];

// inserting elements
insertElements.splice(2, 0, 3); // add 3 at the 2 index
console.log(insertElements);

// inserting multiple elements
insertElements.splice(4, 0, 5, 6) // adding mutiple numbers at a certain spot
console.log(insertElements);

// removing elements
insertElements.splice(3, 2); // remove 2 elements at index 3 (this will be 4, 5)
console.log(insertElements);

// saving removed elements
let removedElements: number[] = insertElements.splice(1, 2)
console.log(removedElements, ' - removed elements');