using Microsoft.AspNetCore.Components;
using Minesweeper.Blazor.Shared;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Minesweeper.Blazor.Client.Pages
{
    public partial class MinesweeperPage : ComponentBase
    {
        [Inject] 
        private HttpClient HttpClient { get; set; }
    }
}
