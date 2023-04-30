/*
  Description: Determines if a given string is unique.
  Problem: 1.1 Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures?
*/
function isUnique(str)
{
  // Uses javascript objects as a hash map
  let uniqueObj = {};
  for (char of str) 
  {
    if (uniqueObj[char] !== undefined) return false;
    uniqueObj[char] = 1;
  }
  return true;
}

function isUniqueNoDataStructure(str)
{
  // Brute force method of nested loops across the string
  for (let i = 0; i < str.length; i++) 
  {
    for (let j = i + 1; j < str.length; j++)
    {
      if (str[i] === str[j]) return false;
    }
  }
  return true;
}

function testAll()
{
  isUniqueTest1();
  isUniqueTest2();
  isUniqueTest3();
  isUniqueTest4();
  isUniqueNoDataStructureTest1();
  isUniqueNoDataStructureTest2();
  isUniqueNoDataStructureTest3();
  isUniqueNoDataStructureTest4();
  isUniqueNoDataStructureTest5();
}

function isUniqueTest1()
{
  console.assert(isUnique(""));
}

function isUniqueTest2()
{
  console.assert(!isUnique("aa"));
}

function isUniqueTest3()
{
  console.assert(isUnique("ab"));
}

function isUniqueTest4()
{
  console.assert(isUnique("bacwqerty"));
}

function isUniqueNoDataStructureTest1()
{
  console.assert(isUniqueNoDataStructure(""));
}

function isUniqueNoDataStructureTest2()
{
  console.assert(!isUniqueNoDataStructure("aa"));
}

function isUniqueNoDataStructureTest3()
{
  console.assert(isUniqueNoDataStructure("ab"));
}

function isUniqueNoDataStructureTest4()
{
  console.assert(isUniqueNoDataStructure("bacwqerty"));
}

function isUniqueNoDataStructureTest5()
{
  console.assert(!isUniqueNoDataStructure("bacwqertyq"));
}

testAll();