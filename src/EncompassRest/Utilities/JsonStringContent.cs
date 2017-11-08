using System.Net.Http;
using System.Net.Http.Headers;

namespace EncompassRest.Utilities
{
    internal sealed class JsonStringContent : StringContent
    {
        public JsonStringContent(string json)
            : base(json)
        {
            Headers.ContentType = new MediaTypeHeaderValue("application/json");
        }
    }
}