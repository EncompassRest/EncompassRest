using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.LoanBatch
{
    public sealed class BatchUpdate
    {
        private const string _apiPath = "encompass/v1/loanBatch";

        public EncompassRestClient Client { get; }

        internal BatchUpdate(EncompassRestClient client)
        {
            Client = client;
        }

        public Task<BatchUpdateStatus> GetStatusAsync(string requestId)
        {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));

            return GetStatusInternalAsync(requestId, response => response.Content.ReadAsAsync<BatchUpdateStatus>());
        }

        public Task<string> GetStatusRawAsync(string requestId)
        {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));

            return GetStatusInternalAsync(requestId, response => response.Content.ReadAsStringAsync());
        }

        private async Task<T> GetStatusInternalAsync<T>(string requestId, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/updateRequests/{requestId}").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetStatusAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<string> UpdateLoansAsync(BatchUpdateParameters parameters)
        {
            Preconditions.NotNull(parameters, nameof(parameters));

            return UpdateLoansInternalAsync(JsonStreamContent.Create(parameters));
        }

        public Task<string> UpdateLoansRawAsync(string parameters)
        {
            Preconditions.NotNull(parameters, nameof(parameters));

            return UpdateLoansInternalAsync(new JsonContent(parameters));
        }

        private async Task<string> UpdateLoansInternalAsync(HttpContent content)
        {
            using (var response = await Client.HttpClient.PostAsync($"{_apiPath}/updateRequests", content).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(UpdateLoansAsync), response).ConfigureAwait(false);
                }

                return Path.GetFileName(response.Headers.Location.OriginalString);
            }
        }
    }
}