// original array 
let beginingSentences: string[] = ["I'm", "You're", "We're"];



// ---------------------------------- map function - modifies each element in the array and returns a new array
let sentencesMapped: string[] = beginingSentences.map(function(value) {
  return value + ' funny!' ;
});

console.log(sentencesMapped);




// ---------------------------------- map - fat arrow
let finalSentencesMapped: string[] = beginingSentences.map(b => b.concat(' funny!'));

console.log(finalSentencesMapped);




// ---------------------------------- filter function - filters out the elements into a new array - you can't alter the values. 
let sentencesFilter: string[] = beginingSentences.filter((s) => {
    if(s.length > 3) {
         return s;
    }
});

console.log(sentencesFilter);




// ---------------------------------- filter - fat arrow
let finalSentencesFilter: string[] = beginingSentences.filter((s) => s.length > 3);

console.log(finalSentencesFilter);




// ---------------------------------- combined filter and map
let finalSentence: string[] = beginingSentences.filter((s) => s.length > 3).map(b => b.concat(" funny!"));

console.log(finalSentence);
