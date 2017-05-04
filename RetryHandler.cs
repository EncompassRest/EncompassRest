using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace EncompassRest
{
    internal sealed class RetryHandler : DelegatingHandler
    {
        private readonly Func<Task<AuthenticationHeaderValue>> _reinitializeAuthorizationHeader;

        public RetryHandler(HttpMessageHandler innerHandler, Func<Task<AuthenticationHeaderValue>> reinitializeAuthorizationHeader)
            : base(innerHandler) => _reinitializeAuthorizationHeader = reinitializeAuthorizationHeader;

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
            if (!response.IsSuccessStatusCode && response.StatusCode == HttpStatusCode.Unauthorized)
            {
                request.Headers.Authorization = await _reinitializeAuthorizationHeader().ConfigureAwait(false);
                response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
            }
            return response;
        }
    }
}
