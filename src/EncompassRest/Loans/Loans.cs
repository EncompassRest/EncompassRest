using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.Attachments;
using EncompassRest.Loans.Documents;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans
{
    public sealed class Loans : ApiObject
    {
        internal Loans(EncompassRestClient client)
            : base(client, "encompass/v1/loans")
        {
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

            return GetAsync(loanId, queryParameters.ToString(), nameof(GetLoanAsync), loanId, cancellationToken, async response =>
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

            return GetRawAsync(loanId, queryString, nameof(GetLoanRawAsync), loanId, cancellationToken);
        }

        public Task<List<StringEnumValue<LoanEntity>>> GetSupportedEntitiesAsync() => GetSupportedEntitiesAsync(CancellationToken.None);

        public Task<List<StringEnumValue<LoanEntity>>> GetSupportedEntitiesAsync(CancellationToken cancellationToken) => GetAsync<List<StringEnumValue<LoanEntity>>>("supportedEntities", null, nameof(GetSupportedEntitiesAsync), null, cancellationToken);

        public Task<string> GetSupportedEntitiesRawAsync() => GetSupportedEntitiesRawAsync(CancellationToken.None);

        public Task<string> GetSupportedEntitiesRawAsync(CancellationToken cancellationToken) => GetRawAsync("supportedEntities", null, nameof(GetSupportedEntitiesRawAsync), null, cancellationToken);

        public Task<string> CreateLoanAsync(Loan loan) => CreateLoanAsync(loan, false, CancellationToken.None);

        public Task<string> CreateLoanAsync(Loan loan, CancellationToken cancellationToken) => CreateLoanAsync(loan, false, cancellationToken);

        public Task<string> CreateLoanAsync(Loan loan, bool populate) => CreateLoanAsync(loan, populate, CancellationToken.None);

        public Task<string> CreateLoanAsync(Loan loan, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(loan, nameof(loan));
            Preconditions.NullOrEmpty(loan.EncompassId, $"{nameof(loan)}.{nameof(loan.EncompassId)}");

            return PostAsync(JsonStreamContent.Create(loan), null, populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, nameof(CreateLoanAsync), null, cancellationToken, async response =>
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

            return PostAsync(new JsonStringContent(loan), null, queryString, nameof(CreateLoanRawAsync), null, cancellationToken, async response =>
            {
                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return string.IsNullOrEmpty(json) ? Path.GetFileName(response.Headers.Location.OriginalString) : json;
            });
        }

        public Task UpdateLoanAsync(Loan loan) => UpdateLoanAsync(loan, false, CancellationToken.None);

        public Task UpdateLoanAsync(Loan loan, CancellationToken cancellationToken) => UpdateLoanAsync(loan, false, cancellationToken);

        public Task UpdateLoanAsync(Loan loan, bool populate) => UpdateLoanAsync(loan, populate, CancellationToken.None);

        public Task UpdateLoanAsync(Loan loan, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(loan, nameof(loan));
            Preconditions.NotNullOrEmpty(loan.EncompassId, $"{nameof(loan)}.{nameof(loan.EncompassId)}");

            loan.Initialize(Client);
            return PatchAsync(JsonStreamContent.Create(loan), loan.EncompassId, populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, nameof(UpdateLoanAsync), loan.EncompassId, cancellationToken, async response =>
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

            return PatchRawAsync(new JsonStringContent(loan), loanId, queryString, nameof(UpdateLoanRawAsync), loanId, cancellationToken);
        }

        public Task<bool> DeleteLoanAsync(string loanId) => DeleteLoanAsync(loanId, CancellationToken.None);

        public Task<bool> DeleteLoanAsync(string loanId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return DeleteAsync(loanId, cancellationToken);
        }
    }
}