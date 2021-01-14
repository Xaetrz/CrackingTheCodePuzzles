using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodePuzzles.Chapters.ObjectOrientedDesign.Minesweeper
{
    public class Board
    {
        public Cell[,] Mines { get; private set; }
        public int NumberOfBombs { get; private set; }
        public int NumberOfUncheckedCells { get; private set; }

        public Board(int boardSize, int numberOfBombs) 
        {
            this.Mines = GenerateBoard(boardSize, numberOfBombs);
            this.NumberOfBombs = numberOfBombs;
        }

        private Cell[,] GenerateBoard(int boardSize, int numberOfBombs) { throw new NotImplementedException(); }

        public bool CheckCell(int rowIndex, int colIndex) { throw new NotImplementedException(); }
        private void ExpandBlank() { }
    }

    public class Cell
    {
        public bool IsMine { get; private set; }
        public bool IsChecked { get; private set; }
        public bool NumberOfSurroundingMines { get; private set; }

        public Cell (bool isMine, int numberOfSurroundingMines ) { }

        public bool CheckCell() { throw new NotImplementedException(); }
    }

    public static class Game
    {
        public enum GameState { Won, Lost, Ongoing }

        public static GameState State;
        public static Board CurrentBoard;

        public static void Initialize() { }

        public static void PlayGame() { } // Game Loop
    }

    public static class GameIO
    {
        public static void DisplayUserInputMessage() { }
        public static void DisplayResultMessage() { }
        public static bool GetUserInput(out int xRow, out int xCol) { throw new NotImplementedException(); }

        public static void PrintBoard(Board board) { }

        public static void ClearBoard(Board board) { }
    }

}
