using Microsoft.AspNetCore.Components;
using Minesweeper.Blazor.Shared.Models;

namespace Minesweeper.Blazor.Client.Components
{
    public class GameBoardBase : ComponentBase
    {
        [Parameter]
        public Board Board { get; set; }
    }
}