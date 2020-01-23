using Microsoft.AspNetCore.Components;

namespace Minesweeper.Blazor.Client.Components
{
    public class BoardSquareBase : ComponentBase
    {
        [Parameter]
        public int Value { get; set; }

        [Parameter]
        public int Id { get; set; }

        [Parameter]
        public EventCallback<int> OnClick { get; set; }

        public bool IsOpen { get; set; } = false;

        public void OpenSquare()
        {
            IsOpen = true;
            OnClick.InvokeAsync(Id);
        }
    }
}
