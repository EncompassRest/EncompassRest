using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using System.Collections;
using System;

namespace EncompassRest.Services
{
    public sealed class Services
    {
        private const string s_apiPath = "services/v1";

        public EncompassRestClient Client { get; }

        internal Services(EncompassRestClient client)
        {
            Client = client;
        }

        private async Task<T> OrderCreditServicesInternalAsync<T>(CreditResource resource,string partnerID, CancellationToken cancellationToken,string methodName, Func<HttpResponseMessage,Task<T>> func)
        {
            JsonStreamContent content;
            content = JsonStreamContent.Create(resource);

            using (var response = await Client.HttpClient.PostAsync($"{s_apiPath}/partners/{partnerID}/transactions", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(methodName, response).ConfigureAwait(false);
                }
                return await func(response).ConfigureAwait(false);
            }
        }

    }
}
