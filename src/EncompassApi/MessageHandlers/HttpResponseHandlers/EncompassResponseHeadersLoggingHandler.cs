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
    public class EncompassResponseHeadersLoggingHandler<THandler> : DelegatingHandler
    {
        private readonly IEnumerable<string> _headers;
        private readonly ILogger<THandler> _logger;
        const string HANDLERTAG = "HandlerTag";
        const string URI = "Uri";

        public EncompassResponseHeadersLoggingHandler(
            ILogger<THandler> logger,
            IEnumerable<string> headers)
        {
            _headers = headers;
            _logger = logger;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var resp = await base.SendAsync(request, cancellationToken);

            LogHeaders(resp, request.RequestUri.ToString());
            return resp;
        }

        

        public Dictionary<string, string> LogHeaders(HttpResponseMessage resp, string requestUri)
        {

            resp.Headers.Add(HANDLERTAG, Guid.NewGuid().ToString());
            resp.Headers.Add(URI, requestUri);
            var headers = resp.Headers;
            var logArray = new Dictionary<string, string>();
            if (headers != null)
            {
                foreach (var key in _headers)
                {
                    if (headers.TryGetValues(key, out IEnumerable<string> values) && headers.TryGetValues(HANDLERTAG, out IEnumerable<string> tag) && headers.TryGetValues(URI, out IEnumerable<string> uri))
                    {
                        _logger.LogDebug("Header {0} : {1} for tag: {2}", key, values.FirstOrDefault(), tag.FirstOrDefault());
                       
                        if (key.Contains("Concurrency"))
                        {
                            var header = new ConcurrencyHeaderLimit("Concurrency", tag.FirstOrDefault(), uri.FirstOrDefault(), true);
                            var conccurrencyFactory = HeaderLimitFactory<ConcurrencyHeaderLimit>.Factory;

                            conccurrencyFactory.Add(header, key, values.FirstOrDefault(), _logger)
                                 .Log(header, _logger);
                            logArray.Add(key, values.FirstOrDefault());
                            if (!logArray.ContainsKey("ConcurrencyRatio") && conccurrencyFactory.Ratio.HasValue)
                            {
                                logArray.Add("ConcurrencyRatio", conccurrencyFactory.Ratio.Value.ToString());
                            }

                        }
                        else if (key.Contains("X-Rate"))
                        {
                            var header = new XRateHeaderLimit("XRate", tag.FirstOrDefault(), uri.FirstOrDefault(), true);
                            var xRateLimitFactory = HeaderLimitFactory<XRateHeaderLimit>.Factory;

                            xRateLimitFactory.Add(header, key, values.FirstOrDefault(), _logger)
                                 .Log(header, _logger);
                            logArray.Add(key, values.FirstOrDefault());
                            if (!logArray.ContainsKey("XRateLimitRatio") && xRateLimitFactory.Ratio.HasValue)
                            {
                                logArray.Add("XRateLimitRatio", xRateLimitFactory.Ratio.Value.ToString());
                            }

                        }
                    }
                }

            }
            return logArray;
        }

    }

}
