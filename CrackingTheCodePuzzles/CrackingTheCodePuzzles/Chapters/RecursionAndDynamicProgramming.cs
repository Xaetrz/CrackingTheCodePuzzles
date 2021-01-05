using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace CrackingTheCodePuzzles.Chapters
{
    public class RecursionAndDynamicProgramming
    {
        /// <summary>
        /// 8.1 Triple Step A child is running up a staircase with n steps and can hop either 1 step, 2 steps, or 3
        /// steps at a time.Implement a method to count how many possible ways the child can run up the stairs.
        /// </summary>
        public static int TripleStep_Recursive(int totalSteps)
        {
            if (totalSteps == 0) return 1;
            else if (totalSteps < 0) return 0;

            return TripleStep_Recursive(totalSteps - 1) + TripleStep_Recursive(totalSteps - 2) + TripleStep_Recursive(totalSteps - 3);
        }
        // Same as above except with Memoization
        public static int TripleStep_Memo(int totalSteps)
        {
            int[] memo = new int[totalSteps + 1];
            return TripleStep_Memo(totalSteps, memo);
        }
        public static int TripleStep_Memo(int totalSteps, int[] memo)
        {
            if (totalSteps == 0) return 1;
            else if (totalSteps < 0) return 0;
            else if (memo[totalSteps] == 0) return memo[totalSteps];

            memo[totalSteps] = TripleStep_Recursive(totalSteps - 1) + TripleStep_Recursive(totalSteps - 2) + TripleStep_Recursive(totalSteps - 3);
            return memo[totalSteps];
        }

        /// <summary>
        /// 8.2 Imagine a robot sitting on the upper left corner of grid with r rows and c columns.
        /// The robot can only move in two directions, right and down, but certain cells are "off limits" such that
        /// the robot cannot step on them.Design an algorithm to find a path for the robot from the top left to the bottom right.
        /// </summary>
        public static List<Point> RobotInAGrid(bool[,] maze)
        {
            List<Point> path = new List<Point>();
            bool[,] failedPoints = new bool[maze.GetLength(0), maze.GetLength(1)];
            bool isValidPath = RobotInAGrid(maze, path, new Point(0, 0), failedPoints);

            if (!isValidPath) return null;
            return path;
        }
        public static bool RobotInAGrid(bool[,] maze, List<Point> path, Point curLoc, bool[,] failedPoints)
        {
            // Add cur location to path if not blocked or not already failed, otherwise invalid path
            if (maze[curLoc.X, curLoc.Y] || failedPoints[curLoc.X, curLoc.Y]) return false;
            else path.Add(curLoc);
            
            // Reached the end of the maze
            if (curLoc.X == maze.GetLength(0) - 1 && curLoc.Y == maze.GetLength(1) - 1) return true;

            // Search one down
            if (curLoc.X < maze.GetLength(0) - 1)
            {
                bool isValidPath = RobotInAGrid(maze, path, new Point(curLoc.X + 1, curLoc.Y), failedPoints);
                if (isValidPath) return true;
            }
            
            // Search one right
            if (curLoc.Y < maze.GetLength(1) - 1)
            {
                bool isValidPath = RobotInAGrid(maze, path, new Point(curLoc.X, curLoc.Y + 1), failedPoints);
                if (isValidPath) return true;
            }

            // No valid path from current location, so remove from path list
            path.RemoveAt(path.Count - 1);
            failedPoints[curLoc.X, curLoc.Y] = true;
            return false;
        }
        public static void PrintMazeAndPath(bool[,] maze, List<Point> path)
        {
            for (int i = 0; i <= maze.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= maze.GetLength(1) - 1; j++)
                {
                    Point currentPoint = new Point(i, j);
                    if (path.Contains(currentPoint)) Console.Write("#");
                    else if (maze[i, j]) Console.Write("X");
                    else Console.Write("O");
                }
                Console.WriteLine();
            }
        }
        public static void PrintExampleMazes()
        {
            bool[,] maze1 = new bool[,] { { false, false, true,  false, false },
                                          { false, false, true,  false, false },
                                          { false, false, false, false, false },
                                          { false, true,  false, false, false },
                                          { true,  false, false, false, false } };
            PrintMazeAndPath(maze1, RobotInAGrid(maze1));
        }
    }
}
