using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EncompassRest.Exceptions;
using EncompassRest.Utilities;

namespace EncompassRest.LoanPipeline
{
    public sealed class Pipeline
    {
        private const string _apiPath = "encompass/v1/loanPipeline";

        public EncompassRestClient Client { get; }

        internal Pipeline(EncompassRestClient client)
        {
            Client = client;
        }

        public async Task GetCanonicalNamesAsync()
        {
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/fieldDefinitions"))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new RestException(nameof(GetCanonicalNamesAsync), response);
                }

                var json = await response.Content.ReadAsStringAsync();
                // TODO: Parse json to .NET object
            }
        }
        
        public async Task<List<LoanPipelineData>> ViewPipelineAsync(ViewPipelineParameters parameters, int? limit = null)
        {
            Preconditions.NotNull(parameters, nameof(parameters));
            if (limit <= 0)
            {
                throw new ArgumentException("must be null or greater than 0", nameof(limit));
            }

            using (var response = await Client.HttpClient.PostAsync($"{_apiPath}{(limit.HasValue ? $"?limit={limit}" : string.Empty)}", JsonContent.Create(parameters)))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new RestException(nameof(ViewPipelineAsync), response);
                }

                var json = await response.Content.ReadAsStringAsync();
                return JsonHelper.FromJson<List<LoanPipelineData>>(json);
            }
        }
    }
}