using Minesweeper.Blazor.Shared.Models;
using System;

namespace Minesweeper.Blazor.Shared
{
    public class MinesweeperGame
    {
        public Board Board { get; set; }

        public void InitializeBoard(int boardSize, int amountOfBombs)
        {
            Board = new Board(CreateBoard(boardSize, amountOfBombs));

            foreach (var square in Board.SquaresBoard)
            {
                square.Opened += Square_Opened;
            }
        }

        private ESquareValue[,] CreateBoard(int boardSize, int amountOfBombs)
        {
            var board = new ESquareValue[boardSize, boardSize];
            var rnd = new Random();

            while (amountOfBombs > 0)
            {
                var x = rnd.Next(0, board.GetLength(0));
                var y = rnd.Next(0, board.GetLength(1));

                if (board[x, y] != ESquareValue.Bomb)
                {
                    amountOfBombs--;
                    board[x, y] = ESquareValue.Bomb;
                    IncreaseValuesNearBomb(board, x, y);
                }
            }

            return board;
        }

        private void IncreaseValuesNearBomb(ESquareValue[,] board, int x, int y)
        {
            IncreaseSquareValue(board, x - 1, y - 1);
            IncreaseSquareValue(board, x - 1, y);
            IncreaseSquareValue(board, x - 1, y + 1);
            IncreaseSquareValue(board, x, y - 1);
            IncreaseSquareValue(board, x, y + 1);
            IncreaseSquareValue(board, x + 1, y - 1);
            IncreaseSquareValue(board, x + 1, y);
            IncreaseSquareValue(board, x + 1, y + 1);
        }

        private void IncreaseSquareValue(ESquareValue[,] board, int x, int y)
        {
            if (x < 0 || y < 0 || x >= board.GetLength(0) || y >= board.GetLength(1) || board[x, y] < ESquareValue.Empty || board[x, y] >= ESquareValue.Eight)
            {
                return;
            }

            Console.WriteLine(board[x, y]);
            board[x,y] = board[x, y]+1;
        }

        private void Square_Opened(object sender, SquareLocation e)
        {
            if (sender is Square square && square.Value == ESquareValue.Empty)
            {
                OpenSquare(e.X - 1, e.Y - 1);
                OpenSquare(e.X - 1, e.Y);
                OpenSquare(e.X - 1, e.Y + 1);
                OpenSquare(e.X, e.Y - 1);
                OpenSquare(e.X, e.Y + 1);
                OpenSquare(e.X + 1, e.Y - 1);
                OpenSquare(e.X + 1, e.Y);
                OpenSquare(e.X + 1, e.Y + 1);
            }
        }

        private void OpenSquare(int x, int y)
        {
            if (x >= 0 && y >= 0 && x < Board.Size && y < Board.Size)
            {
                if (Board[x, y].Value == ESquareValue.Empty && !Board[x, y].IsOpen)
                {
                    Board[x, y].OpenSquare();
                }
            }
        }
    }
}
