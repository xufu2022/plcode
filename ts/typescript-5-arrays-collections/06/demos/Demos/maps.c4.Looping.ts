// set up the map variable
let gameMap = new Map<string, number>([
    ['Pong', 1972],
    ['Tetris', 1985],    
    ['The Oregon Trail', 1981]
]);

// grab all the keys
for (let key of gameMap.keys()) {
    console.log(key);
}

// grab all the values
for (let value of gameMap.values()) {
    console.log(value);
}

// grab entire entry as an array
for (let entry of gameMap.entries()) {
    console.log(entry);
    //console.log(entry[0], entry[1]);
}

// grab separated key/value variables
for (let [key, value] of gameMap) {
    console.log(key, value); 
}