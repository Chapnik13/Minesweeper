using System;
using Microsoft.AspNetCore.Components;

namespace Minesweeper.Blazor.Client.Components
{
    public class GameBoardBase : ComponentBase
    {
        [Parameter]
        public int Size { get; set; }

        protected int[,] Board;

        protected override void OnParametersSet()
        {
            Board = new int[Size, Size];
        }

        protected void OnGameSquareClick(int id)
        {
            Console.WriteLine($"Squre[{id / Size},{id % Size}]");
        }
    }
}
