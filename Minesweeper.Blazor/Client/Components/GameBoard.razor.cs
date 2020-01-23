using Microsoft.AspNetCore.Components;
using Minesweeper.Blazor.Shared;

namespace Minesweeper.Blazor.Client.Components
{
    public class GameBoardBase : ComponentBase
    {
        [Parameter]
        public int Size { get; set; }

        [Inject]
        public MinesweeperGame Game { get; set; }

        protected override void OnParametersSet()
        {
            Game.InitializeBoard(Size, 8);
        }
    }
}