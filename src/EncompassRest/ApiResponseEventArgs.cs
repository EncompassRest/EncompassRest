using System;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace EncompassRest
{
    /// <summary>
    /// Api response event arguments.
    /// </summary>
    public sealed class ApiResponseEventArgs : EventArgs
    {
        /// <summary>
        /// The Api request.
        /// </summary>
        public HttpRequestMessage Request => Response.RequestMessage;

        /// <summary>
        /// The Api response status code.
        /// </summary>
        public HttpStatusCode StatusCode => Response.StatusCode;

        /// <summary>
        /// The Api response.
        /// </summary>
        public HttpResponseMessage Response { get; }

        /// <summary>
        /// The Api response correlation id as specified in the X-Correlation-ID header. Useful to Ellie Mae for inspecting issues.
        /// </summary>
        public string CorrelationId => Response.Headers.TryGetValues("X-Correlation-ID", out var values) ? values.FirstOrDefault() : null;

        internal ApiResponseEventArgs(HttpResponseMessage response)
        {
            Response = response;
        }
    }
}