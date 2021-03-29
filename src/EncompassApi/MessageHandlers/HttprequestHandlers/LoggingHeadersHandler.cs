using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EncompassApi.MessageHandlers
{
    public class LoggingHeadersHandler : DelegatingHandler
    {
        public LoggingHeadersHandler()
        {

        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var resp= await base.SendAsync(request, cancellationToken);
            return resp;
        }

    }
}
