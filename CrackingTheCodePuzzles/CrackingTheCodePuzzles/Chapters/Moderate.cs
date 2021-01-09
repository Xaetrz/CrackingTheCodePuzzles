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

        /// <summary>
        /// 16.4 Tic Tac Win: Design an algorithm to figure out if someone has won a game of tic-tac-toe.
        /// </summary>
        public static Piece IsTicTacWin(Piece[,] board)
        {
            Piece firstPiece;
            int numRows = board.GetLength(0),
                numCols = board.GetLength(1);

            // Check rows
            for (int row = 0; row < numRows; row++)
            {
                firstPiece = board[row, 0];
                if (IsRowWon(board, row)) return firstPiece; 
            }

            // Check columns
            for (int col = 0; col < numCols; col++)
            {
                firstPiece = board[0, col];
                if (IsColumnWon(board, col)) return firstPiece;
            }

            // Check top-left to bottom-right diagonal
            firstPiece = board[0, 0];
            if (IsDiagonalWon(board, 1)) return firstPiece;

            // Check bottom-left to top-right diagonal
            firstPiece = board[numRows - 1, numCols - 1];
            if (IsDiagonalWon(board, -1)) return firstPiece;

            return Piece.Empty;
        }
        public static bool IsRowWon(Piece[,] board, int row)
        {
            Piece firstPiece = board[row, 0];
            if (firstPiece == Piece.Empty) return false;

            for (int col = 1; col < board.GetLength(1); col++)
            {
                Piece nextPiece = board[row, col];
                if (firstPiece != nextPiece) return false;
            }
            return true;
        }
        public static bool IsColumnWon(Piece[,] board, int col)
        {
            Piece firstPiece = board[0, col];
            if (firstPiece == Piece.Empty) return false;

            for (int row = 1; row < board.GetLength(0); row++)
            {
                Piece nextPiece = board[row, col];
                if (firstPiece != nextPiece) return false;
            }
            return true;
        }
        public static bool IsDiagonalWon(Piece[,] board, int direction)
        {
            int col = (direction == 1) ? 0 : board.GetLength(1) - 1;
            Piece firstPiece = board[0, col];
            if (firstPiece == Piece.Empty) return false;

            for (int row = 1; row < board.GetLength(0); row++)
            {
                col += direction;
                Piece nextPiece = board[row, col];
                if (firstPiece != nextPiece) return false;
            }
            return true;
        }
        public enum Piece { Empty = 0, Red = 1, Blue = 2 }

    }
}



