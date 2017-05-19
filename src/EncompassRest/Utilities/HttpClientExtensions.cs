using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace EncompassRest.Utilities
{
    public static class HttpClientExtensions
    {
        public static Task<HttpResponseMessage> PatchAsync(this HttpClient client, string requestUri, HttpContent content) => client.PatchAsync(new Uri(client.BaseAddress + requestUri), content);

        public static Task<HttpResponseMessage> PatchAsync(this HttpClient client, Uri requestUri, HttpContent content)
        {
            var request = new HttpRequestMessage(new HttpMethod("PATCH"), requestUri)
            {
                Content = content
            };

            return client.SendAsync(request);
        }
    }
}