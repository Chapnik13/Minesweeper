using Microsoft.AspNetCore.Components;
using Minesweeper.Blazor.Shared.Models;

namespace Minesweeper.Blazor.Client.Components
{
    public class BoardSquareBase : ComponentBase
    {
        [Parameter]
        public Square Square { get; set; }

        protected override void OnParametersSet()
        {
            Square.Opened += Square_Opened;
        }

        private void Square_Opened(object sender, SquareLocation e)
        {
            StateHasChanged();
        }
    }
}
