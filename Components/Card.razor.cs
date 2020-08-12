using Microsoft.AspNetCore.Components;

namespace Hackernews.Components
{
    public partial class Card : ComponentBase
    {
        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public string Description { get; set; }

        [Parameter]
        public string UrlToImage { get; set; }

        [Parameter]
        public string Url { get; set; }

        [Parameter]
        public string Author { get; set; }

        [Parameter]
        public string Source { get; set; }

        [Parameter]
        public string Date { get; set; }
    }
}