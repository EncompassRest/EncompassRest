using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace EncompassREST.HelperClasses
{
    public static class HttpClientExtensions
    {
        public static Task<HttpResponseMessage> PatchAsync(this HttpClient client, string requestUri, HttpContent content) => client.PatchAsync(new Uri(client.BaseAddress + requestUri), content);

        public static async Task<HttpResponseMessage> PatchAsync(this HttpClient client, Uri requestUri, HttpContent content)
        {
            var method = new HttpMethod("PATCH");
            var request = new HttpRequestMessage(method, requestUri)
            {
                Content = content
            };

            var response = new HttpResponseMessage();
            try
            {
                response = await client.SendAsync(request);
            }
            catch (TaskCanceledException e)
            {
                Debug.WriteLine("ERROR: " + e.ToString());
            }

            return response;
        }
    }
}
