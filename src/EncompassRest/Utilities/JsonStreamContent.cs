using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Utilities
{
    internal sealed class JsonStreamContent : HttpContent
    {
        private static readonly Task s_completedTask = Task.FromResult(0);

        public static JsonStreamContent Create<T>(T value) => new JsonStreamContent(value, typeof(T));

        public object Value { get; }

        public Type Type { get; }

        public JsonStreamContent(object value)
            : this(value, null)
        {
        }

        public JsonStreamContent(object value, Type type)
        {
            Headers.ContentType = new MediaTypeHeaderValue("application/json");

            Value = value;
            Type = type;
        }

        protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
        {
            using (var writer = new StreamWriter(stream, Encoding.UTF8, 4096, true))
            {
                JsonHelper.ToJson(Value, Type, writer);
            }
            return s_completedTask;
        }

        protected override bool TryComputeLength(out long length)
        {
            length = 0;
            return false;
        }
    }
}