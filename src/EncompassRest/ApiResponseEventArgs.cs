using System;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace EncompassRest
{
    public sealed class ApiResponseEventArgs : EventArgs
    {
        public HttpRequestMessage Request => Response.RequestMessage;

        public HttpStatusCode StatusCode => Response.StatusCode;

        public HttpResponseMessage Response { get; }

        public string CorrelationId => Response.Headers.TryGetValues("X-Correlation-ID", out var values) ? values.FirstOrDefault() : null;

        internal ApiResponseEventArgs(HttpResponseMessage response)
        {
            Response = response;
        }
    }
}