using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans
{
    public sealed class Loans : ApiObject
    {
        private LoanFieldDescriptors _fieldDescriptors;

        public LoanFieldDescriptors FieldDescriptors
        {
            get
            {
                var fieldDescriptors = _fieldDescriptors;
                return fieldDescriptors ?? Interlocked.CompareExchange(ref _fieldDescriptors, (fieldDescriptors = new LoanFieldDescriptors(Client)), null) ?? fieldDescriptors;
            }
        }

        internal Loans(EncompassRestClient client)
            : base(client, "encompass/v1/loans")
        {
        }

        public LoanApis GetLoanApis(string loanId)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return new LoanApis(Client, loanId);
        }

        public Task<Loan> GetLoanAsync(string loanId, CancellationToken cancellationToken = default) => GetLoanAsync(loanId, (IEnumerable<string>)null, cancellationToken);

        public Task<Loan> GetLoanAsync(string loanId, IEnumerable<LoanEntity> entities, CancellationToken cancellationToken = default) => GetLoanAsync(loanId, entities?.Select(e => e.Validate(nameof(entities)).GetValue()), cancellationToken);

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

        public Task<string> GetLoanRawAsync(string loanId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return GetRawAsync(loanId, queryString, nameof(GetLoanRawAsync), loanId, cancellationToken);
        }

        public Task<List<StringEnumValue<LoanEntity>>> GetSupportedEntitiesAsync(CancellationToken cancellationToken = default) => GetAsync<List<StringEnumValue<LoanEntity>>>("supportedEntities", null, nameof(GetSupportedEntitiesAsync), null, cancellationToken);

        public Task<string> GetSupportedEntitiesRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync("supportedEntities", queryString, nameof(GetSupportedEntitiesRawAsync), null, cancellationToken);

        public Task<string> CreateLoanAsync(Loan loan, CancellationToken cancellationToken = default) => CreateLoanAsync(loan, null, cancellationToken);

        public Task<string> CreateLoanAsync(Loan loan, bool populate, CancellationToken cancellationToken = default) => CreateLoanAsync(loan, new CreateLoanOptions { Populate = populate }, cancellationToken);

        public async Task<string> CreateLoanAsync(Loan loan, CreateLoanOptions createLoanOptions, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(loan, nameof(loan));
            Preconditions.NullOrEmpty(loan.EncompassId, $"{nameof(loan)}.{nameof(loan.EncompassId)}");

            var loanId = await PostPopulateDirtyAsync(null, createLoanOptions?.ToQueryParameters().ToString(), nameof(CreateLoanAsync), loan, createLoanOptions?.Populate == true, cancellationToken).ConfigureAwait(false);
            loan.Initialize(Client, loanId);
            return loanId;
        }

        public Task<string> CreateLoanRawAsync(string loan, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loan, nameof(loan));

            return PostAsync(null, queryString, new JsonStringContent(loan), nameof(CreateLoanRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
        }

        public Task UpdateLoanAsync(Loan loan, CancellationToken cancellationToken = default) => UpdateLoanAsync(loan, null, cancellationToken);

        public Task UpdateLoanAsync(Loan loan, bool populate, CancellationToken cancellationToken = default) => UpdateLoanAsync(loan, new UpdateLoanOptions { Populate = populate }, cancellationToken);

        public async Task UpdateLoanAsync(Loan loan, UpdateLoanOptions updateLoanOptions, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(loan, nameof(loan));
            Preconditions.NotNullOrEmpty(loan.EncompassId, $"{nameof(loan)}.{nameof(loan.EncompassId)}");

            loan.Initialize(Client, loan.EncompassId);
            HttpContent content;
            if (updateLoanOptions?.Persistent == false)
            {
                var body = loan.ToJson();
                content = new JsonStringContent(body);
            }
            else
            {
                var transientLoanUpdates = loan.TransientLoanUpdates;
                if (transientLoanUpdates?.Count > 0)
                {
                    foreach (var transientLoanUpdate in transientLoanUpdates)
                    {
                        await PatchAsync(loan.EncompassId, transientLoanUpdate.QueryString, new JsonStringContent(transientLoanUpdate.Body), nameof(UpdateLoanAsync), loan.EncompassId, cancellationToken).ConfigureAwait(false);
                    }
                    transientLoanUpdates.Clear();
                }
                content = JsonStreamContent.Create(loan);
            }
            await PatchAsync(loan.EncompassId, updateLoanOptions?.ToQueryParameters().ToString(), content, nameof(UpdateLoanAsync), loan.EncompassId, cancellationToken, async (HttpResponseMessage response) =>
            {
                if (updateLoanOptions?.Populate == true)
                {
                    await response.Content.PopulateAsync(loan).ConfigureAwait(false);
                }
                loan.Dirty = false;
                if (updateLoanOptions?.Persistent == false)
                {
                    var transientLoanUpdates = loan.TransientLoanUpdates;
                    if (transientLoanUpdates == null)
                    {
                        transientLoanUpdates = new List<Loan.TransientLoanUpdate>();
                        loan.TransientLoanUpdates = transientLoanUpdates;
                    }
                    transientLoanUpdates.Add(new Loan.TransientLoanUpdate { Body = ((JsonStringContent)content).Json, QueryString = updateLoanOptions.ToQueryParameters(true).ToString() });
                }
                return string.Empty;
            }).ConfigureAwait(false);
        }

        public Task<string> UpdateLoanRawAsync(string loanId, string loan, string queryString = null, CancellationToken cancellationToken = default)
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