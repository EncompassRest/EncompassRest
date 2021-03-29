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
    public class LoggingResponseHeadersHandler : DelegatingHandler
    {
        private readonly IOptions<HttpResponseHeaderLogOptions> _options;
        private readonly ILogger<LoggingResponseHeadersHandler> _logger;

        public LoggingResponseHeadersHandler(
            ILogger<LoggingResponseHeadersHandler> logger,
            IOptions<Configuration.HttpResponseHeaderLogOptions> options)
        {
            _options = options;
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
                foreach (var key in _options?.Value.Headers)
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
