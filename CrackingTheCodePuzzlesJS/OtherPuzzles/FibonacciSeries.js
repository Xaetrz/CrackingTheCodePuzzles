/*
    Description: The classic Fibonacci series. Multiple implementations
*/

function fibonacciIterative(num) {
    if (num <= 1) return 1;
    let curr = 1;
    let prev = 1;
    for (let i = 2; i <= num; i++) {
        let temp = curr;
        curr += prev;
        prev = temp;
    }
    return curr;
}

function fibonacciRecursive(num) {
    if (num <= 1) return 1;
    return fibonacciRecursive(num - 1) + fibonacciRecursive(num - 2);
}

console.log(fibonacciIterative(40));
console.log(fibonacciRecursive(40));  // Fun fact: O(n^2)