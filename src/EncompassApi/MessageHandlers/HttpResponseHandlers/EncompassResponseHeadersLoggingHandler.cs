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
        const string CONCURRENCYTAG = "ConcurrencyTag";
        const string Uri = "Uri";

        public EncompassResponseHeadersLoggingHandler(
            ILogger<EncompassResponseHeadersLoggingHandler> logger,
            IEnumerable<string> headers)
        {
            _headers = headers;
            _logger = logger;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var resp = await base.SendAsync(request, cancellationToken);
            resp.Headers.Add(CONCURRENCYTAG, Guid.NewGuid().ToString());
            resp.Headers.Add(Uri, request.RequestUri.ToString());
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
                    if (headers.TryGetValues(key, out IEnumerable<string> values) && headers.TryGetValues(CONCURRENCYTAG, out IEnumerable<string> tag) && headers.TryGetValues(Uri, out IEnumerable<string> uri))
                    {
                        _logger.LogDebug("Header {0} : {1} for tag: {2}", key, values.FirstOrDefault(), tag.FirstOrDefault());

                        if (key.Contains("Concurrency"))
                        {
                            var header = new ConcurrencyHeaderLimit("Concurrency", tag.FirstOrDefault(), uri.FirstOrDefault(), true);
                            HeaderLimitFactory<ConcurrencyHeaderLimit>.Factory
                                 .Add(header, key, values.FirstOrDefault(), _logger)
                                 .Log(header, _logger);
                        }


                    }
                }
                
            }
        }

    }

}
