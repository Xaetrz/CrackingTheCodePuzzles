using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using CrackingTheCodePuzzles.Implementation;

namespace CrackingTheCodePuzzles.Chapters
{
    public class Moderate
    {
        /// <summary>
        /// 16.1 Number Swapper: Write a function to swap a number in place (that is, without temporary variables. 
        /// </summary>
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

        /// <summary>
        /// 16.2 Word Frequencies: Design a method to find the frequency of occurrences of any given word in a book. What if we were running this algorithm mUltiple times?
        /// </summary>
        public static Dictionary<string, int> WordFrequencies(string filePath)
        {
            Dictionary<string, int> wordCounter = new Dictionary<string, int>();

            try
            {
                using StreamReader sr = new StreamReader(filePath);

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    MatchCollection words = Regex.Matches(line, @"\b\w+\b");

                    foreach (string word in words)
                    {
                        int count;
                        if (wordCounter.TryGetValue(word, out count))
                        {
                            wordCounter[word] = count + 1;
                        }
                        else
                        {
                            wordCounter.Add(word, 0);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read.");
                Console.WriteLine(e.Message);
            }
            return wordCounter;
        }
        public static int GetFrequency(Dictionary<string, int> table, string word)
        {
            if (table.TryGetValue(word, out int count))
            {
                return count;
            }
            return 0;
        }


        /// <summary>
        /// 16.3 Intersection of two line segments
        /// </summary>
        public static Point Intersection(LineSegment lineSeg1, LineSegment lineSeg2)
        {
            // Important Note: Assumes that the start point has a X coordinate before the X coordinate of the end point for each line segment

            Line line1 = new Line(lineSeg1.StartPoint, lineSeg1.EndPoint);
            Line line2 = new Line(lineSeg2.StartPoint, lineSeg2.EndPoint);

            Point intersectPoint = Line.Intersection(line1, line2);

            if (LineSegment.DoLineSegmentsIntersect(lineSeg1, lineSeg2, intersectPoint)) return intersectPoint;
            else return null;
        }
    }
}



