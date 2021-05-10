using System;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace EncompassRest
{
    /// <summary>
    /// Api response event arguments.
    /// </summary>
    public interface IApiResponseEventArgs
    {
        /// <summary>
        /// The concurrency limit as specified in the X-Concurrency-Limit-Limit header.
        /// </summary>
        int? ConcurrencyLimit { get; }
        /// <summary>
        /// The concurrency limit remaining as specified in the X-Concurrency-Limit-Remaining header.
        /// </summary>
        int? ConcurrencyLimitRemaining { get; }
        /// <summary>
        /// The Api response correlation id as specified in the X-Correlation-ID header. Useful to Ellie Mae for inspecting issues.
        /// </summary>
        string? CorrelationId { get; }
        /// <summary>
        /// The rate limit as specified in the X-Rate-Limit-Limit header.
        /// </summary>
        int? RateLimit { get; }
        /// <summary>
        /// The rate limit remaining as specified in the X-Rate-Limit-Remaining header.
        /// </summary>
        int? RateLimitRemaining { get; }
        /// <summary>
        /// The rate limit reset date and time as specified in the X-Rate-Limit-Reset header.
        /// </summary>
        DateTime? RateLimitReset { get; }
        /// <summary>
        /// The Api request.
        /// </summary>
        HttpRequestMessage Request { get; }
        /// <summary>
        /// The Api response.
        /// </summary>
        HttpResponseMessage Response { get; }
        /// <summary>
        /// The Api response status code.
        /// </summary>
        HttpStatusCode StatusCode { get; }
    }

    internal sealed class ApiResponseEventArgs : EventArgs, IApiResponseEventArgs
    {
        public HttpRequestMessage Request => Response.RequestMessage;

        public HttpStatusCode StatusCode => Response.StatusCode;

        public HttpResponseMessage Response { get; }

        public string? CorrelationId => Response.Headers.TryGetValues("X-Correlation-ID", out var values) ? values.FirstOrDefault() : null;

        public int? ConcurrencyLimit => Response.Headers.TryGetValues("X-Concurrency-Limit-Limit", out var values) && int.TryParse(values.FirstOrDefault() ?? string.Empty, out var value) ? value : default;

        public int? ConcurrencyLimitRemaining => Response.Headers.TryGetValues("X-Concurrency-Limit-Remaining", out var values) && int.TryParse(values.FirstOrDefault() ?? string.Empty, out var value) ? value : default;

        public int? RateLimit => Response.Headers.TryGetValues("X-Rate-Limit-Limit", out var values) && int.TryParse(values.FirstOrDefault() ?? string.Empty, out var value) ? value : default;

        public int? RateLimitRemaining => Response.Headers.TryGetValues("X-Rate-Limit-Remaining", out var values) && int.TryParse(values.FirstOrDefault() ?? string.Empty, out var value) ? value : default;

        public DateTime? RateLimitReset => Response.Headers.TryGetValues("X-Rate-Limit-Reset", out var values) && int.TryParse(values.FirstOrDefault() ?? string.Empty, out var value) ? new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(value) : default;

        internal ApiResponseEventArgs(HttpResponseMessage response)
        {
            Response = response;
        }
    }
}