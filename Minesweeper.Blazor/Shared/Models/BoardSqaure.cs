using System;

namespace Minesweeper.Blazor.Shared.Models
{
    public class Square
    {
        public ESquareValue Value { get; private set; }
        public bool IsOpen { get; private set; } = false;
        public bool IsFlag { get; private set; } = false;

        public event EventHandler<SquareLocation> Opened;

        private SquareLocation location;

        public Square(int i, int j, ESquareValue value)
        {
            Value = value;
            location = new SquareLocation(i, j);
        }

        public void OpenSquare()
        {
            if (!IsOpen && !IsFlag)
            {
                IsOpen = true;
                Opened?.Invoke(this, location);
            }
        }

        public void SetFlag()
        {
            if (!IsOpen)
            {
                IsFlag = true;
            }
        }
    }
}
