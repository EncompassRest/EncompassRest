using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest
{
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
                var error = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                sb.Append(error);
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

    public class LoanLocked
    {
        public string ErrorMessage { get; set; }
        public string Id { get; set; }
        public string InnerErrorMessage { get; set; }
        public LoanLockedDetails Details { get; set; }
    }

    public class LoanLockedDetails
    {
        public bool CurrentlyLoggedOn { get; set; }
        public string LoanId { get; set; }
        public string LockedByFirstName { get; set; }
        public string LockedByLastName { get; set; }
        public string LockedBySessionId { get; set; }
        public string LockedByUserId { get; set; }
        public DateTime LockedSince { get; set; }
    }

    public sealed class NotFoundException : RestException
    {
        internal static new async Task<NotFoundException> CreateAsync(string message, HttpResponseMessage response)
        {
            var baseMessage = await BuildBaseMessageAsync(message, response).ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return new NotFoundException(baseMessage, response, content);
        }

        private NotFoundException(string message, HttpResponseMessage response, string content)
            : base(message, response, content)
        {
        }
    }
}