using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [Obsolete("Use GetLoanApis(loanId).Documents instead")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public LoanDocuments GetLoanDocuments(string loanId)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return new LoanDocuments(Client, loanId);
        }

        [Obsolete("Use GetLoanApis(loanId).Attachments instead")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public LoanAttachments GetLoanAttachments(string loanId)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return new LoanAttachments(Client, loanId);
        }

        public LoanApis GetLoanApis(string loanId)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return new LoanApis(Client, loanId);
        }

        public Task<Loan> GetLoanAsync(string loanId, CancellationToken cancellationToken = default) => GetLoanAsync(loanId, (IEnumerable<string>)null, cancellationToken);

        public Task<Loan> GetLoanAsync(string loanId, IEnumerable<LoanEntity> entities, CancellationToken cancellationToken = default) => GetLoanAsync(loanId, entities?.Select(e => e.AsString()), cancellationToken);

        public async Task<Loan> GetLoanAsync(string loanId, IEnumerable<string> entities, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            var queryParameters = new QueryParameters();
            if (entities?.Any() == true)
            {
                queryParameters.Add("entities", string.Join(",", entities));
            }

            var loan = await GetDirtyAsync<Loan>(loanId, queryParameters.ToString(), nameof(GetLoanAsync), loanId, cancellationToken).ConfigureAwait(false);
            loan.Initialize(Client, loan.EncompassId);
            return loan;
        }

        public Task<string> GetLoanRawAsync(string loanId, CancellationToken cancellationToken = default) => GetLoanRawAsync(loanId, (string)null, cancellationToken);

        public Task<string> GetLoanRawAsync(string loanId, IEnumerable<LoanEntity> entities, CancellationToken cancellationToken = default) => GetLoanRawAsync(loanId, entities?.Select(e => e.AsString()), cancellationToken);

        public Task<string> GetLoanRawAsync(string loanId, IEnumerable<string> entities, CancellationToken cancellationToken = default)
        {
            var queryParameters = new QueryParameters();
            if (entities?.Any() == true)
            {
                queryParameters.Add("entities", string.Join(",", entities));
            }

            return GetLoanRawAsync(loanId, queryParameters.ToString(), cancellationToken);
        }

        public Task<string> GetLoanRawAsync(string loanId, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return GetRawAsync(loanId, queryString, nameof(GetLoanRawAsync), loanId, cancellationToken);
        }

        public Task<List<StringEnumValue<LoanEntity>>> GetSupportedEntitiesAsync(CancellationToken cancellationToken = default) => GetAsync<List<StringEnumValue<LoanEntity>>>("supportedEntities", null, nameof(GetSupportedEntitiesAsync), null, cancellationToken);

        public Task<string> GetSupportedEntitiesRawAsync(CancellationToken cancellationToken = default) => GetRawAsync("supportedEntities", null, nameof(GetSupportedEntitiesRawAsync), null, cancellationToken);

        public Task<string> CreateLoanAsync(Loan loan, CancellationToken cancellationToken = default) => CreateLoanAsync(loan, null, cancellationToken);

        public Task<string> CreateLoanAsync(Loan loan, bool populate, CancellationToken cancellationToken = default) => CreateLoanAsync(loan, new CreateLoanOptions { Populate = populate }, cancellationToken);

        public async Task<string> CreateLoanAsync(Loan loan, CreateLoanOptions createLoanOptions, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(loan, nameof(loan));
            Preconditions.NullOrEmpty(loan.EncompassId, $"{nameof(loan)}.{nameof(loan.EncompassId)}");

            var loanId = await PostPopulateDirtyAsync(null, createLoanOptions?.ToQueryParameters()?.ToString(), loan, nameof(CreateLoanAsync), createLoanOptions?.Populate == true, cancellationToken).ConfigureAwait(false);
            loan.Initialize(Client, loanId);
            return loanId;
        }

        public Task<string> CreateLoanRawAsync(string loan, CancellationToken cancellationToken = default) => CreateLoanRawAsync(loan, null, cancellationToken);

        public Task<string> CreateLoanRawAsync(string loan, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loan, nameof(loan));

            return PostAsync(null, queryString, new JsonStringContent(loan), nameof(CreateLoanRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
        }

        public Task UpdateLoanAsync(Loan loan, CancellationToken cancellationToken = default) => UpdateLoanAsync(loan, null, cancellationToken);

        public Task UpdateLoanAsync(Loan loan, bool populate, CancellationToken cancellationToken = default) => UpdateLoanAsync(loan, new UpdateLoanOptions { Populate = populate }, cancellationToken);

        public Task UpdateLoanAsync(Loan loan, UpdateLoanOptions updateLoanOptions, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(loan, nameof(loan));
            Preconditions.NotNullOrEmpty(loan.EncompassId, $"{nameof(loan)}.{nameof(loan.EncompassId)}");

            loan.Initialize(Client, loan.EncompassId);
            return PatchPopulateDirtyAsync(loan.EncompassId, updateLoanOptions?.ToQueryParameters()?.ToString(), JsonStreamContent.Create(loan), nameof(UpdateLoanAsync), loan.EncompassId, loan, updateLoanOptions?.Populate == true, cancellationToken);
        }

        public Task<string> UpdateLoanRawAsync(string loanId, string loan, CancellationToken cancellationToken = default) => UpdateLoanRawAsync(loanId, loan, null, cancellationToken);

        public Task<string> UpdateLoanRawAsync(string loanId, string loan, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));
            Preconditions.NotNullOrEmpty(loan, nameof(loan));

            return PatchRawAsync(loanId, queryString, new JsonStringContent(loan), nameof(UpdateLoanRawAsync), loanId, cancellationToken);
        }

        public Task<bool> DeleteLoanAsync(string loanId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return DeleteAsync(loanId, null, cancellationToken);
        }
    }
}