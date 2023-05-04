/*
    Description: The classic FizzBuzz. Multiple implementations with various optimizations
*/
function fizzBuzzBruteForce() {
    for (let i = 0; i <= 100; i++) {
        if ((i % 3 === 0) && (i % 5 ===0)) console.log("FizzBuzz");
        else if (i % 3 === 0) console.log("Fizz");
        else if (i % 5 === 0) console.log("Buzz");
        else console.log(`${i} `);
    }
}

function fizzBuzzBasic() {
    for (let i = 0; i <= 100; i++) {
        if (i % 15 === 0) console.log("FizzBuzz");
        else if (i % 3 === 0) console.log("Fizz");
        else if (i % 5 === 0) console.log("Buzz");
        else console.log(`${i} `);
    }
}

fizzBuzzBasic();