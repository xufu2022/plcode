// create a set
//let ourFirstSet = new Set(); // standard JS set implementation
let ourFirstSet = new Set<string>(); // creates an empty set
//let ourFirstSet = new Set<object>(); // sets can have different types stored


// a set initialized with values.
//let setWithData = new Set<string>(['Tetris', 'Pong', 'The Oregon Trail']);
let setWithData = new Set<string>(['Tetris', 'Pong', 'The Oregon Trail']);

console.log(setWithData);
console.log(typeof setWithData);