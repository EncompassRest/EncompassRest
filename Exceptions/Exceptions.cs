using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Threading.Tasks;
using EncompassRest.Exceptions;

namespace EncompassRest
{
    public sealed class NotFoundException : Exception
    {
        public string ExtraData { get; }

        public NotFoundException(string message, string extraData)
            : base(message)
        {
            ExtraData = extraData;
        }
    }

    public class RestException : Exception
    {
        internal static async Task<RestException> CreateAsync(string message, HttpResponseMessage response)
        {
            var baseMessage = await BuildBaseMessageAsync(message, response).ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return new RestException(baseMessage, response, content);
        }

        internal static async Task<string> BuildBaseMessageAsync(string message, HttpResponseMessage response)
        {
            var sb = new StringBuilder();

            if (!string.IsNullOrEmpty(message))
            {
                sb.AppendLine(message);
            }

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsAsync<HttpError>().ConfigureAwait(false);
                if (error != null)
                {
                    sb.AppendLine(error.Message);

                    var innerException = error.InnerException;
                    if (innerException != null)
                    {
                        sb.AppendLine(innerException.Message);
                    }

                    sb.Append(error.StackTrace);
                }
            }
            return sb.ToString();
        }

        public HttpStatusCode StatusCode => Response.StatusCode;

        public HttpResponseMessage Response { get; }

        public string Content { get; }

        public string CorrelationId
        {
            get
            {
                var corr = Response.Headers.Where(x => x.Key == "X-Correlation-ID").Select(x => x.Value).FirstOrDefault();
                return corr?.FirstOrDefault() ?? "NA";
            }
        }

        internal RestException(string message, HttpResponseMessage response, string content)
            : base(message)
        {
            Response = response;
            Content = content;
        }
    }

    public sealed class LoanLockedException : RestException
    {
        internal static new async Task<LoanLockedException> CreateAsync(string message, HttpResponseMessage response)
        {
            var baseMessage = await BuildBaseMessageAsync(message, response).ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return new LoanLockedException(baseMessage, response, content);
        }

        public LoanLocked LoanLocked { get; }

        private LoanLockedException(string message, HttpResponseMessage response, string content)
            : base(message, response, content)
        {
            LoanLocked = JsonConvert.DeserializeObject<LoanLocked>(content);
        }
    }
}