using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Hackernews.Helpers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using NewsApi.Models;
using Newtonsoft.Json;

namespace Hackernews.Components
{
    public partial class News : ComponentBase
    {
        public readonly HttpClient httpClient = new HttpClient ();
        private Root data;
        private string Query;

        SearchRequest SearchRequest = new SearchRequest ();

        private const string BASE_URI = "https://newsapi.org/v2/everything?q={query}&apiKey=c56a21ef39374f0bade0bcfe0336db23&sortBy=relavancy";

        protected override async Task OnInitializedAsync ()
        {
            CancellationTokenSource source = new CancellationTokenSource ();
            CancellationToken cancellationToken = source.Token;

            Query = "bombings";

            data = await GrandHelper.QueryHelper (BASE_URI, Query, cancellationToken);

        }

        async void FormSubmitted (EditContext editContext)
        {
            Console.WriteLine ("query:" + SearchRequest.QueryString);
            Query = SearchRequest.QueryString;

            CancellationTokenSource source = new CancellationTokenSource ();
            CancellationToken cancellationToken = source.Token;

            data = await GrandHelper.QueryHelper (BASE_URI, Query, cancellationToken);
            StateHasChanged ();
        }

    }

}