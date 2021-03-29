using EncompassApi.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace EncompassApi.MessageHandlers
{
    public class EncompassResponseHeadersLoggingHandler : DelegatingHandler
    {
        private readonly IEnumerable<string> _headers;
        private readonly ILogger<EncompassResponseHeadersLoggingHandler> _logger;

        public EncompassResponseHeadersLoggingHandler(
            ILogger<EncompassResponseHeadersLoggingHandler> logger,
            IEnumerable<string> headers)
        {
            _headers = headers;
            _logger = logger;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var resp= await base.SendAsync(request, cancellationToken);
            _logHeaders(resp);
            return resp;
        }

        private void _logHeaders(HttpResponseMessage resp)
        {
            var headers = resp.Headers;
            if (headers != null)
            {
                foreach (var key in _headers)
                {
                    if (headers.TryGetValues(key, out IEnumerable<string> values))
                    {
                        _logger.LogDebug("Header {0} : {1}", key, values.FirstOrDefault());
                    }
                }
            }
        }

    }
}
