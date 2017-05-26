using System.IO;
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

        public async Task<BatchUpdateStatus> GetStatusAsync(string requestId)
        {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));
            
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/updateRequests/{requestId}").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetStatusAsync), response).ConfigureAwait(false);
                }

                return await response.Content.ReadAsAsync<BatchUpdateStatus>().ConfigureAwait(false);
            }
        }

        public async Task<string> UpdateLoansAsync(BatchUpdateParameters parameters)
        {
            Preconditions.NotNull(parameters, nameof(parameters));

            using (var response = await Client.HttpClient.PostAsync($"{_apiPath}/updateRequests", JsonStreamContent.Create(parameters)).ConfigureAwait(false))
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