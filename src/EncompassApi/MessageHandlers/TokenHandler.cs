using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EncompassApi.MessageHandlers
{
    public class TokenHandler : DelegatingHandler
    {
        private readonly ITokenServiceClient _tokenServiceClient;
        public TokenHandler(ITokenServiceClient tokenServiceClient)
        {
            _tokenServiceClient = tokenServiceClient;
        }

        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var token = await _tokenServiceClient.GetToken();
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            return await base.SendAsync(request, cancellationToken);
        }
    }
}