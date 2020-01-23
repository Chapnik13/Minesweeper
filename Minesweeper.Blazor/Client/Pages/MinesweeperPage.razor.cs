using Microsoft.AspNetCore.Components;
using Minesweeper.Blazor.Shared;

namespace Minesweeper.Blazor.Client.Pages
{
    public partial class MinesweeperPage : ComponentBase
    {
        [Inject]
        public MinesweeperGame Game { get; set; }

        protected override void OnParametersSet()
        {
            Game.InitializeBoard(8, 8);
        }
    }
}
