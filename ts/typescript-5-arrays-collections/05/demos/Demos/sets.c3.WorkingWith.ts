// initial set variable.
let setOfGames = new Set<string>();

//  adding values to a set
setOfGames.add("Pong");
setOfGames.add("Tetris");
setOfGames.add("The Oregon Trail");


console.log(setOfGames.has("Tetris"));
console.log(setOfGames.delete("tetris"));

//setOfGames.clear(); // clear out all the set entries. 

console.log(setOfGames.size); // print size of the set

