using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.Attachments;
using EncompassRest.Loans.Documents;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans
{
    public sealed class Loans
    {
        private const string s_apiPath = "encompass/v1/loans";

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

        public Task<Loan> GetLoanAsync(string loanId) => GetLoanAsync(loanId, (IEnumerable<string>)null, CancellationToken.None);

        public Task<Loan> GetLoanAsync(string loanId, CancellationToken cancellationToken) => GetLoanAsync(loanId, (IEnumerable<string>)null, cancellationToken);

        public Task<Loan> GetLoanAsync(string loanId, IEnumerable<LoanEntity> entities) => GetLoanAsync(loanId, entities, CancellationToken.None);

        public Task<Loan> GetLoanAsync(string loanId, IEnumerable<LoanEntity> entities, CancellationToken cancellationToken) => GetLoanAsync(loanId, entities?.Select(e => e.AsString()), cancellationToken);

        public Task<Loan> GetLoanAsync(string loanId, IEnumerable<string> entities) => GetLoanAsync(loanId, entities, CancellationToken.None);

        public Task<Loan> GetLoanAsync(string loanId, IEnumerable<string> entities, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            var queryParameters = new QueryParameters();
            if (entities?.Any() == true)
            {
                queryParameters.Add("entities", string.Join(",", entities));
            }

            return GetLoanInternalAsync(loanId, queryParameters.ToString(), cancellationToken, async response =>
            {
                var loan = new Loan(Client, loanId);
                await response.Content.PopulateAsync(loan).ConfigureAwait(false);
                loan.Dirty = false;
                return loan;
            });
        }

        public Task<string> GetLoanRawAsync(string loanId) => GetLoanRawAsync(loanId, (string)null, CancellationToken.None);

        public Task<string> GetLoanRawAsync(string loanId, CancellationToken cancellationToken) => GetLoanRawAsync(loanId, (string)null, cancellationToken);

        public Task<string> GetLoanRawAsync(string loanId, IEnumerable<LoanEntity> entities) => GetLoanRawAsync(loanId, entities, CancellationToken.None);

        public Task<string> GetLoanRawAsync(string loanId, IEnumerable<LoanEntity> entities, CancellationToken cancellationToken) => GetLoanRawAsync(loanId, entities?.Select(e => e.AsString()), cancellationToken);

        public Task<string> GetLoanRawAsync(string loanId, IEnumerable<string> entities) => GetLoanRawAsync(loanId, entities, CancellationToken.None);

        public Task<string> GetLoanRawAsync(string loanId, IEnumerable<string> entities, CancellationToken cancellationToken)
        {
            var queryParameters = new QueryParameters();
            if (entities?.Any() == true)
            {
                queryParameters.Add("entities", string.Join(",", entities));
            }

            return GetLoanRawAsync(loanId, queryParameters.ToString(), cancellationToken);
        }

        public Task<string> GetLoanRawAsync(string loanId, string queryString) => GetLoanRawAsync(loanId, queryString, CancellationToken.None);

        public Task<string> GetLoanRawAsync(string loanId, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return GetLoanInternalAsync(loanId, queryString, cancellationToken, response => response.Content.ReadAsStringAsync());
        }

        private async Task<T> GetLoanInternalAsync<T>(string loanId, string queryString, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{s_apiPath}/{loanId}{(!string.IsNullOrEmpty(queryString) && queryString[0] != '?' ? "?" : string.Empty)}{queryString}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await EncompassRestException.CreateAsync($"{nameof(GetLoanAsync)}/{loanId}", response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<List<string>> GetSupportedEntitiesAsync() => GetSupportedEntitiesAsync(CancellationToken.None);

        public Task<List<string>> GetSupportedEntitiesAsync(CancellationToken cancellationToken) => GetSupportedEntitiesInternalAsync(cancellationToken, response => response.Content.ReadAsAsync<List<string>>());

        public Task<string> GetSupportedEntitiesRawAsync() => GetSupportedEntitiesRawAsync(CancellationToken.None);

        public Task<string> GetSupportedEntitiesRawAsync(CancellationToken cancellationToken) => GetSupportedEntitiesInternalAsync(cancellationToken, response => response.Content.ReadAsStringAsync());

        private async Task<T> GetSupportedEntitiesInternalAsync<T>(CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{s_apiPath}/supportedEntities").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await EncompassRestException.CreateAsync(nameof(GetSupportedEntitiesAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<string> CreateLoanAsync(Loan loan) => CreateLoanAsync(loan, false, CancellationToken.None);

        public Task<string> CreateLoanAsync(Loan loan, CancellationToken cancellationToken) => CreateLoanAsync(loan, false, cancellationToken);

        public Task<string> CreateLoanAsync(Loan loan, bool populate) => CreateLoanAsync(loan, populate, CancellationToken.None);

        public Task<string> CreateLoanAsync(Loan loan, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(loan, nameof(loan));
            Preconditions.NullOrEmpty(loan.EncompassId, $"{nameof(loan)}.{nameof(loan.EncompassId)}");

            return CreateLoanInternalAsync(JsonStreamContent.Create(loan), populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, cancellationToken, async response =>
            {
                var loanId = Path.GetFileName(response.Headers.Location.OriginalString);
                loan.EncompassId = loanId;
                loan.Initialize(Client);
                if (populate)
                {
                    await response.Content.PopulateAsync(loan).ConfigureAwait(false);
                }
                loan.Dirty = false;
                return loanId;
            });
        }

        public Task<string> CreateLoanRawAsync(string loan) => CreateLoanRawAsync(loan, null, CancellationToken.None);

        public Task<string> CreateLoanRawAsync(string loan, CancellationToken cancellationToken) => CreateLoanRawAsync(loan, null, cancellationToken);

        public Task<string> CreateLoanRawAsync(string loan, string queryString) => CreateLoanRawAsync(loan, queryString, CancellationToken.None);

        public Task<string> CreateLoanRawAsync(string loan, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(loan, nameof(loan));

            return CreateLoanInternalAsync(new JsonStringContent(loan), queryString, cancellationToken, async response =>
            {
                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return string.IsNullOrEmpty(json) ? Path.GetFileName(response.Headers.Location.OriginalString) : json;
            });
        }

        private async Task<string> CreateLoanInternalAsync(HttpContent content, string queryString, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<string>> func)
        {
            using (var response = await Client.HttpClient.PostAsync($"{s_apiPath}{(!string.IsNullOrEmpty(queryString) && queryString[0] != '?' ? "?" : string.Empty)}{queryString}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await EncompassRestException.CreateAsync(nameof(CreateLoanAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task UpdateLoanAsync(Loan loan) => UpdateLoanAsync(loan, false, CancellationToken.None);

        public Task UpdateLoanAsync(Loan loan, CancellationToken cancellationToken) => UpdateLoanAsync(loan, false, cancellationToken);

        public Task UpdateLoanAsync(Loan loan, bool populate) => UpdateLoanAsync(loan, populate, CancellationToken.None);

        public Task UpdateLoanAsync(Loan loan, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(loan, nameof(loan));
            Preconditions.NotNullOrEmpty(loan.EncompassId, $"{nameof(loan)}.{nameof(loan.EncompassId)}");

            loan.Initialize(Client);
            return UpdateLoanInternalAsync(loan.EncompassId, JsonStreamContent.Create(loan), populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, cancellationToken, async response =>
            {
                if (populate)
                {
                    await response.Content.PopulateAsync(loan).ConfigureAwait(false);
                }
                loan.Dirty = false;
                return string.Empty;
            });
        }

        public Task<string> UpdateLoanRawAsync(string loanId, string loan) => UpdateLoanRawAsync(loanId, loan, null, CancellationToken.None);

        public Task<string> UpdateLoanRawAsync(string loanId, string loan, CancellationToken cancellationToken) => UpdateLoanRawAsync(loanId, loan, null, cancellationToken);

        public Task<string> UpdateLoanRawAsync(string loanId, string loan, string queryString) => UpdateLoanRawAsync(loanId, loan, queryString, CancellationToken.None);

        public Task<string> UpdateLoanRawAsync(string loanId, string loan, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));
            Preconditions.NotNullOrEmpty(loan, nameof(loan));

            return UpdateLoanInternalAsync(loanId, new JsonStringContent(loan), queryString, cancellationToken, response => response.Content.ReadAsStringAsync());
        }

        private async Task<string> UpdateLoanInternalAsync(string loanId, HttpContent content, string queryString, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<string>> func)
        {
            using (var response = await Client.HttpClient.PatchAsync($"{s_apiPath}/{loanId}{(!string.IsNullOrEmpty(queryString) && queryString[0] != '?' ? "?" : string.Empty)}{queryString}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await EncompassRestException.CreateAsync(nameof(UpdateLoanAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<bool> DeleteLoanAsync(string loanId) => DeleteLoanAsync(loanId, CancellationToken.None);

        public async Task<bool> DeleteLoanAsync(string loanId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            using (var response = await Client.HttpClient.DeleteAsync($"{s_apiPath}/{loanId}", cancellationToken).ConfigureAwait(false))
            {
                return response.IsSuccessStatusCode;
            }
        }
    }
}