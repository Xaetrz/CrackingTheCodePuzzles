
/*
  Description: Checks if the two given strings are permutations of each other
  Problem: 1.2 Given two strings, write a method to decide if one is a permutation of the other.
*/
function checkPermutation(str1, str2)
{
  // Take advantage of string and array functions to do the work for me
  if (str1.length !== str2.length) return false;
  return str1.split("").sort().join() === str2.split("").sort().join();
}

function checkPermutationManual(str1, str2)
{
  // Do the 
  return str1.split("").sort().join() === str2.split("").sort().join();
}

let str1 = "test1";
let str2 = "tes1t";
console.log("Are the strings \"" + str1 + "\" and \"" + str2 + "\" permutations of each other? " + (checkPermutation(str1, str2) ? "\nYes." : "\nNo."));