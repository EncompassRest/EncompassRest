using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
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

        public Task<Loan> GetLoanAsync(string loanId) => GetLoanAsync(loanId, (IEnumerable<string>)null, CancellationToken.None);

        public Task<Loan> GetLoanAsync(string loanId, CancellationToken cancellationToken) => GetLoanAsync(loanId, (IEnumerable<string>)null, cancellationToken);

        public Task<Loan> GetLoanAsync(string loanId, params LoanEntity[] entities) => GetLoanAsync(loanId, entities, CancellationToken.None);

        public Task<Loan> GetLoanAsync(string loanId, IEnumerable<LoanEntity> entities) => GetLoanAsync(loanId, entities, CancellationToken.None);

        public Task<Loan> GetLoanAsync(string loanId, IEnumerable<LoanEntity> entities, CancellationToken cancellationToken) => GetLoanAsync(loanId, entities?.Select(entity => entity.ToJson().Unquote()), cancellationToken);

        public Task<Loan> GetLoanAsync(string loanId, params string[] entities) => GetLoanAsync(loanId, entities, CancellationToken.None);

        public Task<Loan> GetLoanAsync(string loanId, IEnumerable<string> entities) => GetLoanAsync(loanId, entities, CancellationToken.None);

        public Task<Loan> GetLoanAsync(string loanId, IEnumerable<string> entities, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return GetLoanInternalAsync(loanId, entities, cancellationToken, async response =>
            {
                var loan = new Loan(Client, loanId);
                await response.Content.PopulateAsync(loan).ConfigureAwait(false);
                loan.Clean = true;
                return loan;
            });
        }

        public Task<string> GetLoanRawAsync(string loanId) => GetLoanRawAsync(loanId, (IEnumerable<string>)null, CancellationToken.None);

        public Task<string> GetLoanRawAsync(string loanId, CancellationToken cancellationToken) => GetLoanRawAsync(loanId, (IEnumerable<string>)null, cancellationToken);

        public Task<string> GetLoanRawAsync(string loanId, params LoanEntity[] entities) => GetLoanRawAsync(loanId, entities, CancellationToken.None);

        public Task<string> GetLoanRawAsync(string loanId, IEnumerable<LoanEntity> entities) => GetLoanRawAsync(loanId, entities, CancellationToken.None);

        public Task<string> GetLoanRawAsync(string loanId, IEnumerable<LoanEntity> entities, CancellationToken cancellationToken) => GetLoanRawAsync(loanId, entities?.Select(entity => entity.ToJson().Unquote()), cancellationToken);

        public Task<string> GetLoanRawAsync(string loanId, params string[] entities) => GetLoanRawAsync(loanId, entities, CancellationToken.None);

        public Task<string> GetLoanRawAsync(string loanId, IEnumerable<string> entities) => GetLoanRawAsync(loanId, entities, CancellationToken.None);

        public Task<string> GetLoanRawAsync(string loanId, IEnumerable<string> entities, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return GetLoanInternalAsync(loanId, entities, cancellationToken, response => response.Content.ReadAsStringAsync());
        }

        private async Task<T> GetLoanInternalAsync<T>(string loanId, IEnumerable<string> entities, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            var queryParameters = new QueryParameters();
            if (entities?.Any() == true)
            {
                queryParameters.Add("entities", string.Join(",", entities));
            }

            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/{loanId}{queryParameters}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw response.StatusCode == HttpStatusCode.NotFound ? await NotFoundException.CreateAsync($"{nameof(GetLoanAsync)}/{loanId}", response).ConfigureAwait(false) : await RestException.CreateAsync(nameof(GetLoanAsync), response).ConfigureAwait(false);
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
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/supportedEntities").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetSupportedEntitiesAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<string> CreateLoanAsync(Loan loan, bool populate) => CreateLoanAsync(loan, populate, CancellationToken.None);

        public Task<string> CreateLoanAsync(Loan loan, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(loan, nameof(loan));
            Preconditions.NullOrEmpty(loan.EncompassId, $"{nameof(loan)}.{nameof(loan.EncompassId)}");

            return CreateLoanInternalAsync(JsonStreamContent.Create(loan), populate ? new QueryParameters(new QueryParameter("view", "entity")) : null, cancellationToken, async response =>
            {
                var loanId = Path.GetFileName(response.Headers.Location.OriginalString);
                loan.EncompassId = loanId;
                loan.Initialize(Client);
                if (populate)
                {
                    await response.Content.PopulateAsync(loan).ConfigureAwait(false);
                }
                loan.Clean = true;
                return loanId;
            });
        }

        public Task<string> CreateLoanRawAsync(string loan) => CreateLoanRawAsync(loan, CancellationToken.None);

        public Task<string> CreateLoanRawAsync(string loan, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(loan, nameof(loan));

            return CreateLoanInternalAsync(new JsonStringContent(loan), null, cancellationToken, response => Task.FromResult(Path.GetFileName(response.Headers.Location.OriginalString)));
        }

        private async Task<string> CreateLoanInternalAsync(HttpContent content, QueryParameters queryParameters, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<string>> func)
        {
            using (var response = await Client.HttpClient.PostAsync($"{_apiPath}{queryParameters}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(CreateLoanAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task UpdateLoanAsync(Loan loan, bool populate) => UpdateLoanAsync(loan, populate, CancellationToken.None);

        public Task UpdateLoanAsync(Loan loan, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(loan, nameof(loan));
            Preconditions.NotNullOrEmpty(loan.EncompassId, $"{nameof(loan)}.{nameof(loan.EncompassId)}");

            loan.Initialize(Client);
            return UpdateLoanInternalAsync(loan.EncompassId, JsonStreamContent.Create(loan), populate ? new QueryParameters(new QueryParameter("view", "entity")) : null, cancellationToken, async response =>
            {
                if (populate)
                {
                    await response.Content.PopulateAsync(loan).ConfigureAwait(false);
                }
                loan.Clean = true;
            });
        }

        public Task UpdateLoanRawAsync(string loanId, string loan) => UpdateLoanRawAsync(loanId, loan, CancellationToken.None);

        public Task UpdateLoanRawAsync(string loanId, string loan, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));
            Preconditions.NotNullOrEmpty(loan, nameof(loan));

            return UpdateLoanInternalAsync(loanId, new JsonStringContent(loan), null, cancellationToken);
        }

        private async Task UpdateLoanInternalAsync(string loanId, HttpContent content, QueryParameters queryParameters, CancellationToken cancellationToken, Func<HttpResponseMessage, Task> func = null)
        {
            using (var response = await Client.HttpClient.PatchAsync($"{_apiPath}/{loanId}{queryParameters}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw response.StatusCode == HttpStatusCode.Conflict ? await LoanLockedException.CreateAsync(nameof(UpdateLoanAsync), response).ConfigureAwait(false) : await RestException.CreateAsync(nameof(UpdateLoanAsync), response).ConfigureAwait(false);
                }

                if (func != null)
                {
                    await func(response).ConfigureAwait(false);
                }
            }
        }

        public Task DeleteLoanAsync(string loanId) => DeleteLoanAsync(loanId, CancellationToken.None);

        public Task DeleteLoanAsync(string loanId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return DeleteLoanInternalAsync(loanId, cancellationToken);
        }

        private async Task DeleteLoanInternalAsync(string loanId, CancellationToken cancellationToken)
        {
            using (var response = await Client.HttpClient.DeleteAsync($"{_apiPath}/{loanId}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(DeleteLoanAsync), response).ConfigureAwait(false);
                }
            }
        }
    }
}