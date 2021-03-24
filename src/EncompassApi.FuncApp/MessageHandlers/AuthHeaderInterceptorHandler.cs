using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EncompassApi.FuncApp.MessageHandlers
{
    public class AuthHeaderInterceptorHandler : DelegatingHandler
    {
        private readonly ILogger _log;
        public AuthHeaderInterceptorHandler(ILogger<AuthHeaderInterceptorHandler> log)
        {
            _log = log;
        }

        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            _log.LogInformation(request.Headers.Authorization.ToString());

            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("Auth Header Logged")
            };
            
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return await tsc.Task;
        }
    }
}
