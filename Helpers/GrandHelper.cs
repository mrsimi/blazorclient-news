using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using NewsApi.Models;
using Newtonsoft.Json;

namespace Hackernews.Helpers
{
    public static class GrandHelper
    {
        private static T DeserializeJsonFromStream<T> (Stream stream)
        {
            if (stream == null || stream.CanRead == false)
                return default (T);

            using (var sr = new StreamReader (stream))
            using (var jtr = new JsonTextReader (sr))
            {
                var js = new JsonSerializer ();
                var searchResult = js.Deserialize<T> (jtr);
                return searchResult;
            }
        }

        private static async Task<string> StreamToStringAsync (Stream stream)
        {
            string content = null;
            if (stream != null)
                using (var sr = new StreamReader (stream))
            content = await sr.ReadToEndAsync ();

            return content;
        }

        public static async Task<Root> QueryHelper (string baseUrl, string query, CancellationToken cancellationToken)
        {
            Root Data = null;

            string url = baseUrl.Replace ("{query}", query);

            using (var client = new HttpClient ())
            using (var request = new HttpRequestMessage (HttpMethod.Get, url))
            using (var response = await client.SendAsync (request, cancellationToken))
            {

                var stream = await response.Content.ReadAsStreamAsync ();

                if (response.IsSuccessStatusCode)
                    Data = DeserializeJsonFromStream<Root> (stream);
                else
                {
                    var content = await StreamToStringAsync (stream);
                    throw new ApiException
                    {
                        StatusCode = (int) response.StatusCode,
                            Content = content
                    };
                }
            }

            return Data;
        }
    }
}