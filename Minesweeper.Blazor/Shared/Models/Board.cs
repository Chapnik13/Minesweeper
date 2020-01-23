using System;

namespace Minesweeper.Blazor.Shared.Models
{
    public class Board
    {
        public int Size => SquaresBoard.GetLength(0);

        public Square[,] SquaresBoard { get; private set; }

        public Square this[int i, int j] => SquaresBoard[i, j];

        public Board(ESquareValue[,] arrayBoard)
        {
            SquaresBoard = new Square[arrayBoard.GetLength(0), arrayBoard.GetLength(1)];

            for (var i = 0; i < arrayBoard.GetLength(0); i++)
            {
                for (var j = 0; j < arrayBoard.GetLength(1); j++)
                {
                    SquaresBoard[i, j] = new Square(i, j, arrayBoard[i, j]);
                }
            }
        }
    }
}
