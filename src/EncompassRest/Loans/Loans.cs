using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using EncompassRest.Loans.Attachments;
using EncompassRest.Loans.Documents;
using EncompassRest.Utilities;

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

        public Task<Loan> GetLoanAsync(string loanId, IEnumerable<string> entities)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return GetLoanInternalAsync(loanId, entities, async response =>
            {
                var loan = new Loan(Client, loanId);
                using (var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                {
                    using (var reader = new StreamReader(stream))
                    {
                        JsonHelper.PopulateFromJson(reader, loan);
                    }
                }
                loan.Clean = true;
                return loan;
            });
        }

        public Task<string> GetLoanRawAsync(string loanId) => GetLoanRawAsync(loanId, (IEnumerable<string>)null);

        public Task<string> GetLoanRawAsync(string loanId, params LoanEntity[] entities) => GetLoanRawAsync(loanId, (IEnumerable<LoanEntity>)entities);

        public Task<string> GetLoanRawAsync(string loanId, IEnumerable<LoanEntity> entities) => GetLoanRawAsync(loanId, entities?.Select(entity => entity.ToJson().Unquote()));

        public Task<string> GetLoanRawAsync(string loanId, IEnumerable<string> entities)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return GetLoanInternalAsync(loanId, entities, response => response.Content.ReadAsStringAsync());
        }

        private async Task<T> GetLoanInternalAsync<T>(string loanId, IEnumerable<string> entities, Func<HttpResponseMessage, Task<T>> func)
        {
            var queryParameters = new QueryParameters();
            if (entities?.Any() == true)
            {
                queryParameters.Add("entities", string.Join(",", entities));
            }

            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/{loanId}{queryParameters}").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw response.StatusCode == HttpStatusCode.NotFound ? await NotFoundException.CreateAsync($"{nameof(GetLoanAsync)}/{loanId}", response).ConfigureAwait(false) : await RestException.CreateAsync(nameof(GetLoanAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<List<string>> GetSupportedEntitiesAsync() => GetSupportedEntitiesInternalAsync(response => response.Content.ReadAsAsync<List<string>>());

        public Task<string> GetSupportedEntitiesRawAsync() => GetSupportedEntitiesInternalAsync(response => response.Content.ReadAsStringAsync());

        private async Task<T> GetSupportedEntitiesInternalAsync<T>(Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/supportedEntities").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetSupportedEntitiesAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<string> CreateLoanAsync(Loan loan)
        {
            Preconditions.NotNull(loan, nameof(loan));

            return CreateLoanInternalAsync(loan);
        }

        private async Task<string> CreateLoanInternalAsync(Loan loan)
        {
            var loanId = await CreateLoanInternalAsync(JsonStreamContent.Create(loan)).ConfigureAwait(false);
            loan.Clean = true;
            return loanId;
        }

        public Task<string> CreateLoanRawAsync(string loan)
        {
            Preconditions.NotNullOrEmpty(loan, nameof(loan));

            return CreateLoanInternalAsync(new JsonContent(loan));
        }

        private async Task<string> CreateLoanInternalAsync(HttpContent content)
        {
            using (var response = await Client.HttpClient.PostAsync(_apiPath, content).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(CreateLoanAsync), response).ConfigureAwait(false);
                }
                
                return Path.GetFileName(response.Headers.Location.OriginalString);
            }
        }

        public Task UpdateLoanAsync(Loan loan)
        {
            Preconditions.NotNull(loan, nameof(loan));

            return UpdateLoanInternalAsync(loan);
        }

        private async Task UpdateLoanInternalAsync(Loan loan)
        {
            await UpdateLoanInternalAsync(loan.EncompassId, JsonStreamContent.Create(loan));
            loan.Clean = true;
        }

        public Task UpdateLoanRawAsync(string loanId, string loan)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));
            Preconditions.NotNullOrEmpty(loan, nameof(loan));

            return UpdateLoanInternalAsync(loanId, new JsonContent(loan));
        }

        private async Task UpdateLoanInternalAsync(string loanId, HttpContent content)
        {
            using (var response = await Client.HttpClient.PatchAsync($"{_apiPath}/{loanId}", content).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw response.StatusCode == HttpStatusCode.Conflict ? await LoanLockedException.CreateAsync(nameof(UpdateLoanAsync), response).ConfigureAwait(false) : await RestException.CreateAsync(nameof(UpdateLoanAsync), response).ConfigureAwait(false);
                }
            }
        }

        public Task DeleteLoanAsync(string loanId)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return DeleteLoanInternalAsync(loanId);
        }

        private async Task DeleteLoanInternalAsync(string loanId)
        {
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