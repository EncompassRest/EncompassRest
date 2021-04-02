using System.Net.Http;
using System.Net.Http.Headers;

namespace EncompassApi.Utilities
{
    internal sealed class JsonStringContent : StringContent
    {
        public string Json { get; }

        public JsonStringContent(string json)
            : base(json)
        {
            Json = json;
            Headers.ContentType = new MediaTypeHeaderValue("application/json");
        }
    }
}