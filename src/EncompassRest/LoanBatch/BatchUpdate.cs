using System;
using System.IO;
using System.Net.Http;
using System.Threading;
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

        public Task<BatchUpdateStatus> GetStatusAsync(string requestId) => GetStatusAsync(requestId, CancellationToken.None);

        public Task<BatchUpdateStatus> GetStatusAsync(string requestId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));

            return GetStatusInternalAsync(requestId, cancellationToken, response => response.Content.ReadAsAsync<BatchUpdateStatus>());
        }

        public Task<string> GetStatusRawAsync(string requestId) => GetStatusRawAsync(requestId, CancellationToken.None);

        public Task<string> GetStatusRawAsync(string requestId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));

            return GetStatusInternalAsync(requestId, cancellationToken, response => response.Content.ReadAsStringAsync());
        }

        private async Task<T> GetStatusInternalAsync<T>(string requestId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/updateRequests/{requestId}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetStatusAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<string> UpdateLoansAsync(BatchUpdateParameters parameters) => UpdateLoansAsync(parameters, CancellationToken.None);

        public Task<string> UpdateLoansAsync(BatchUpdateParameters parameters, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(parameters, nameof(parameters));

            return UpdateLoansInternalAsync(JsonStreamContent.Create(parameters), cancellationToken);
        }

        public Task<string> UpdateLoansRawAsync(string parameters) => UpdateLoansRawAsync(parameters, CancellationToken.None);

        public Task<string> UpdateLoansRawAsync(string parameters, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(parameters, nameof(parameters));

            return UpdateLoansInternalAsync(new JsonContent(parameters), cancellationToken);
        }

        private async Task<string> UpdateLoansInternalAsync(HttpContent content, CancellationToken cancellationToken)
        {
            using (var response = await Client.HttpClient.PostAsync($"{_apiPath}/updateRequests", content, cancellationToken).ConfigureAwait(false))
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