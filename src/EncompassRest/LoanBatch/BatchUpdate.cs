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

        public async Task<BatchUpdateStatus> GetStatusAsync(string requestId)
        {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));
            
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/updateRequests/{requestId}").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException("Bad request");
                }

                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonHelper.FromJson<BatchUpdateStatus>(json);
            }
        }

        public async Task<string> UpdateLoansAsync(BatchUpdateParameters parameters)
        {
            Preconditions.NotNull(parameters, nameof(parameters));

            using (var response = await Client.HttpClient.PostAsync($"{_apiPath}/updateRequests", JsonContent.Create(parameters)).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException("Bad request");
                }

                return Path.GetFileName(response.Headers.Location.OriginalString);
            }
        }
    }
}