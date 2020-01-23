namespace Minesweeper.Blazor.Shared.Models
{
    public struct SquareLocation
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public SquareLocation(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
