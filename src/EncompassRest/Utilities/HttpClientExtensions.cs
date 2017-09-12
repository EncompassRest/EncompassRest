using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace EncompassRest.Utilities
{
    internal static class HttpClientExtensions
    {
        public static Task<HttpResponseMessage> PatchAsync(this HttpClient client, string requestUri, HttpContent content) => client.PatchAsync(requestUri, content, CancellationToken.None);

        public static Task<HttpResponseMessage> PatchAsync(this HttpClient client, string requestUri, HttpContent content, CancellationToken cancellationToken) => client.PatchAsync(new Uri(client.BaseAddress + requestUri), content, cancellationToken);

        public static Task<HttpResponseMessage> PatchAsync(this HttpClient client, Uri requestUri, HttpContent content) => client.PatchAsync(requestUri, content, CancellationToken.None);

        public static Task<HttpResponseMessage> PatchAsync(this HttpClient client, Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            var request = new HttpRequestMessage(new HttpMethod("PATCH"), requestUri)
            {
                Content = content
            };

            return client.SendAsync(request, cancellationToken);
        }
    }
}