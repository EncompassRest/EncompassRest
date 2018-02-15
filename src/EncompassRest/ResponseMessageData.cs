using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest
{
    public sealed class ResponseMessageData
    {
        internal static async Task<ResponseMessageData> CreateAsync(HttpResponseMessage response)
        {
            var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var requestContent = GetRequestContent(response.RequestMessage.Content);
            return new ResponseMessageData(response, responseContent, requestContent);
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

        public HttpRequestMessage Request => Response.RequestMessage;

        public string RequestContent { get; }

        public HttpStatusCode StatusCode => Response.StatusCode;

        public HttpResponseMessage Response { get; }

        public string ResponseContent { get; }

        public string Date => Response.Headers.TryGetValues("Date", out var values) ? values.FirstOrDefault() : null;

        public string CorrelationId => Response.Headers.TryGetValues("X-Correlation-ID", out var values) ? values.FirstOrDefault() : null;

        private ResponseMessageData(HttpResponseMessage response, string responseContent, string requestContent)            
        {
            Response = response;
            ResponseContent = responseContent;
            RequestContent = requestContent;
        }
    }
}
