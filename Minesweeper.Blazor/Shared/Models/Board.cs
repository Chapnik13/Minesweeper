using System.Collections;
using System.Collections.Generic;

namespace Minesweeper.Blazor.Shared.Models
{
    public class Board : IEnumerable<Square>
    {
        public int Size => Squares.GetLength(0);

        private Square[,] Squares { get; set; }

        public Square this[int i, int j] => Squares[i, j];

        public Board(ESquareValue[,] arrayBoard)
        {
            Squares = new Square[arrayBoard.GetLength(0), arrayBoard.GetLength(1)];

            for (var i = 0; i < arrayBoard.GetLength(0); i++)
            {
                for (var j = 0; j < arrayBoard.GetLength(1); j++)
                {
                    Squares[i, j] = new Square(i, j, arrayBoard[i, j]);
                }
            }
        }

        public IEnumerator<Square> GetEnumerator()
        {
            foreach (var square in Squares)
            {
                yield return square;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
