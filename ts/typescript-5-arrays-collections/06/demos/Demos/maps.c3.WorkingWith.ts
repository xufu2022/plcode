// initial Map variable.
let mapOfGames = new Map<string, number>();

//  adding values to a map
mapOfGames.set("Pong", 1972);
mapOfGames.set("Tetris", 1985);
mapOfGames.set("The Oregon Trail", 1981);


console.log(mapOfGames.get("Tetris")); // get value based on key
console.log(mapOfGames.has("Tetris")); // check if k/v is in map based on key
console.log(mapOfGames.delete("tetris")); // delete k/v based on key

//mapOfGames.clear(); // clear out all the map entries. 

console.log(mapOfGames.size);