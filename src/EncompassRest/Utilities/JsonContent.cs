using System.Net.Http;
using System.Text;

namespace EncompassRest.Utilities
{
    internal sealed class JsonContent : StringContent
    {
        public static JsonContent Create<T>(T value) => new JsonContent(value.ToJson());

        public JsonContent(string json)
            : base(json, Encoding.UTF8, "application/json")
        {
        }
    }
}