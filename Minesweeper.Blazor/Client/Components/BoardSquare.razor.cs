using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Minesweeper.Blazor.Shared.Models;

namespace Minesweeper.Blazor.Client.Components
{
    public class BoardSquareBase : ComponentBase
    {
        private const int LEFT_BUTTON = 0;

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

        protected void OpenSquare(MouseEventArgs e)
        {
            if(e.Button == LEFT_BUTTON)
            {
                Square.OpenSquare();
            }
            else
            {
                Square.SetFlag();
            }
        }
    }
}
