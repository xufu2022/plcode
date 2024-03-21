// create a map
//let map = new Map(); // a standard JS map implementation
let  ourFirstMap = new Map<number, string>(); // creates an empty map
//let map = new Map<number, object>(); // k/v can be any data type

// a map initialized with k/v pairs
let mapWithData = new Map<string, number>([
    ['Tetris', 1985],
    ['Pong', 1972],
    ['The Oregon Trail', 1981]
]);

console.log(mapWithData);
console.log(typeof mapWithData);