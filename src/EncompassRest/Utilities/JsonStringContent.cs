using System.Net.Http;
using System.Text;

namespace EncompassRest.Utilities
{
    internal sealed class JsonStringContent : StringContent
    {
        public JsonStringContent(string json)
            : base(json, Encoding.UTF8, "application/json")
        {
        }
    }
}