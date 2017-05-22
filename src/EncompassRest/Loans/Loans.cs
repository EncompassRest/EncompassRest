using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using EncompassRest.Loans.Attachments;
using EncompassRest.Loans.Documents;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed class Loans
    {
        private const string _apiPath = "encompass/v1/loans";

        #region Public Properties
        public EncompassRestClient Client { get; }
        #endregion

        internal Loans(EncompassRestClient client)
        {
            Client = client;
        }

        public LoanDocuments GetLoanDocuments(string loanId)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return new LoanDocuments(Client, loanId);
        }

        public LoanAttachments GetLoanAttachments(string loanId)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return new LoanAttachments(Client, loanId);
        }

        public Task<Loan> GetLoanAsync(string loanId) => GetLoanAsync(loanId, (IEnumerable<string>)null);

        public Task<Loan> GetLoanAsync(string loanId, params LoanEntity[] entities) => GetLoanAsync(loanId, (IEnumerable<LoanEntity>)entities);

        public Task<Loan> GetLoanAsync(string loanId, IEnumerable<LoanEntity> entities) => GetLoanAsync(loanId, entities?.Select(entity => entity.ToJson().Unquote()));

        public async Task<Loan> GetLoanAsync(string loanId, IEnumerable<string> entities)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            var queryParameters = new QueryParameters();
            if (entities?.Any() == true)
            {
                queryParameters.Add("entities", string.Join(",", entities));
            }

            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/{loanId}{queryParameters}").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw response.StatusCode == HttpStatusCode.NotFound ? await NotFoundException.CreateAsync($"{nameof(GetLoanAsync)}/{loanId}", response) : await RestException.CreateAsync(nameof(GetLoanAsync), response).ConfigureAwait(false);
                }

                var loan = new Loan(Client, loanId);
                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                JsonHelper.PopulateFromJson(json, loan);
                return loan;
            }
        }

        public async Task<List<string>> GetSupportedEntitiesAsync()
        {
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/supportedEntities").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetSupportedEntitiesAsync), response).ConfigureAwait(false);
                }

                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<List<string>>(json);
            }
        }

        public async Task<string> CreateLoanAsync(Loan loan)
        {
            Preconditions.NotNull(loan, nameof(loan));

            using (var response = await Client.HttpClient.PostAsync(_apiPath, JsonContent.Create(loan)).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(CreateLoanAsync), response).ConfigureAwait(false);
                }

                return Path.GetFileName(response.Headers.Location.OriginalString);
            }
        }

        public async Task UpdateLoanAsync(Loan loan)
        {
            Preconditions.NotNull(loan, nameof(loan));

            using (var response = await Client.HttpClient.PatchAsync($"{_apiPath}/{loan.EncompassId}", JsonContent.Create(loan)).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw response.StatusCode == HttpStatusCode.Conflict ? await LoanLockedException.CreateAsync(nameof(UpdateLoanAsync), response).ConfigureAwait(false) : await RestException.CreateAsync(nameof(UpdateLoanAsync), response).ConfigureAwait(false);
                }
            }
        }

        public async Task DeleteLoanAsync(string loanId)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            using (var response = await Client.HttpClient.DeleteAsync($"{_apiPath}/{loanId}").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(DeleteLoanAsync), response).ConfigureAwait(false);
                }
            }
        }
    }
}