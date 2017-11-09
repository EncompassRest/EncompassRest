using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest
{
    public sealed class EncompassRestException : Exception
    {
        internal static async Task<EncompassRestException> CreateAsync(string message, HttpResponseMessage response)
        {
            var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var requestContent = GetRequestContent(response.RequestMessage.Content);
            return new EncompassRestException(message, response, responseContent, requestContent);
        }

        private static string GetRequestContent(HttpContent content)
        {
            switch (content)
            {
                case JsonStreamContent jsonStreamContent:
                    return JsonHelper.ToJson(jsonStreamContent.Value, jsonStreamContent.Type);
                case JsonStringContent jsonStringContent:
                    return jsonStringContent.Json;
                default:
                    return null;
            }
        }

        private static string BuildBaseMessage(string message, HttpResponseMessage response, string responseContent)
        {
            var sb = new StringBuilder();

            sb.Append(message);

            if (!response.IsSuccessStatusCode)
            {
                if (!string.IsNullOrEmpty(message))
                {
                    sb.AppendLine();
                }
                sb.Append(responseContent);
            }
            
            return sb.ToString();
        }

        public HttpRequestMessage Request => Response.RequestMessage;

        public string RequestContent { get; }

        public HttpStatusCode StatusCode => Response.StatusCode;

        public HttpResponseMessage Response { get; }

        public string ResponseContent { get; }

        public string CorrelationId => Response.Headers.TryGetValues("X-Correlation-ID", out var values) ? values.FirstOrDefault() : null;

        private EncompassRestException(string message, HttpResponseMessage response, string responseContent, string requestContent)
            : base(BuildBaseMessage(message, response, responseContent))
        {
            Response = response;
            ResponseContent = responseContent;
            RequestContent = requestContent;
        }
    }
}