 // set up the tuple data type are necessary
let myFirstTuple: [string, number] = ['I am a String', 100]; 
//let myFirstTuple: [string, number] = [100, 'I am a String']; 




// optional entries in the tuple
//let tupleData: [string, number, object, boolean]; // original
let tupleData: [string, number, object | null, boolean?]; // optional with or


tupleData = ['', 1, {}, true]; // all elements
tupleData = ['', 1, {}]; // exclude 4th optional element
tupleData = ['', 1, null]; // adding null

