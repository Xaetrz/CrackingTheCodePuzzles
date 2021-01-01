using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodePuzzles.Chapters
{
    public class Moderate
    {
        /// <summary>
        /// 16.1 Number Swapper: Write a function to swap a number in place (that is, without temporary variables. 
        /// </summary>
        /// <param name="num1">First number to swap</param>
        /// <param name="num2">Second number to swap</param>
        public static void NumberSwapperInPlace(int num1, int num2)
        {
            Console.WriteLine("Num1 Before = " + num1);
            Console.WriteLine("Num2 Before = " + num2);

            // Num1 = 20
            // Num2 = 30

            // Num1 = 20+30 = 50
            // Num2 = 50-30 = 20

            // Num1 = 50-20 = 30
            // Num2 = 20
            num1 = num2 + num1;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("Num1 After = " + num1);
            Console.WriteLine("Num2 After = " + num2);
        }

        public static void WordFrequencies(string filePath)
        {

        }
    }
}



