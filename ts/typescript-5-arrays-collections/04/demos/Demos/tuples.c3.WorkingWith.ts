
// name, year, platform
let sampleTuple: [string, number];
//let sampleTuple: readonly [string, number];

// errors creating a tuple
sampleTuple = ["Tuple String", 12]; // adding a boolean, but tuple type doesn't allow for booleans

sampleTuple[0] = 12; // can't update tuple index 1 with number type, it is declared as a string

sampleTuple.push("I am a string, also."); // strings allowed
//sampleTuple.push(true); // can't add a boolean 




// More alterations
sampleTuple.pop(); // doable
sampleTuple.shift(); // ruins the data type association
sampleTuple.unshift('Another string.'); // potential to ruin data type association
sampleTuple.unshift(true); // ruins the data type association, can't push boolean

// perform readonly operation
