/*
  Problem: 1.3 URLify: Write a method to replace all spaces in a string with '%20'. You may assume that the string has sufficient space at the end to hold the additional characters
               and that you are given the "true" length of the string.
*/
function urlify(input,trueLen) {
  let trailingIndex = input.length - 1;
  let inputArr = Array.from(input);
  for (let i = trueLen - 1; i > 0; i--) 
  {
    if (i >= trailingIndex) break;
    if (inputArr[i] === ' ') {
        inputArr[trailingIndex] = '0';
        inputArr[trailingIndex - 1] = '2';
        inputArr[trailingIndex - 2] = '%';
        trailingIndex -= 3;
    }
    else {
        inputArr[trailingIndex] = inputArr[i];
        trailingIndex--;
    }
  }
  return inputArr.join('');
}

console.log(urlify("blah bibbity blah    ", 17));

