using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans
{
    /// <summary>
    /// The Loans Apis.
    /// </summary>
    public sealed class Loans : ApiObject
    {
        private LoanFieldDescriptors _fieldDescriptors;

        /// <summary>
        /// The loan field descriptors.
        /// </summary>
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

        /// <summary>
        /// Gets the Loan Apis for the loan with the specified <paramref name="loanId"/>.
        /// </summary>
        /// <param name="loanId">The loan id.</param>
        /// <returns></returns>
        public LoanApis GetLoanApis(string loanId)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return new LoanApis(Client, loanId);
        }

        /// <summary>
        /// Returns the entire loan.
        /// </summary>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<Loan> GetLoanAsync(string loanId, CancellationToken cancellationToken = default) => GetLoanAsync(loanId, (IEnumerable<string>)null, cancellationToken);

        /// <summary>
        /// Returns the specific entities of a loan.
        /// </summary>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="entities">The list of loan entities to retrieve from the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<Loan> GetLoanAsync(string loanId, IEnumerable<LoanEntity> entities, CancellationToken cancellationToken = default) => GetLoanAsync(loanId, entities?.Select(e => e.Validate(nameof(entities)).GetValue()), cancellationToken);

        /// <summary>
        /// Returns the specific entities of a loan.
        /// </summary>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="entities">The list of loan entities to retrieve from the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns the entire loan or specific entities of a loan as raw json.
        /// </summary>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetLoanRawAsync(string loanId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return GetRawAsync(loanId, queryString, nameof(GetLoanRawAsync), loanId, cancellationToken);
        }

        /// <summary>
        /// Returns the list of loan entities that can be retrieved from a loan.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<List<StringEnumValue<LoanEntity>>> GetSupportedEntitiesAsync(CancellationToken cancellationToken = default) => GetAsync<List<StringEnumValue<LoanEntity>>>("supportedEntities", null, nameof(GetSupportedEntitiesAsync), null, cancellationToken);

        /// <summary>
        /// Returns the list of loan entities that can be retrieved from a loan as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetSupportedEntitiesRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync("supportedEntities", queryString, nameof(GetSupportedEntitiesRawAsync), null, cancellationToken);

        /// <summary>
        /// Creates a new loan in Encompass and returns the loan id of the loan created.
        /// </summary>
        /// <param name="loan">The loan to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> CreateLoanAsync(Loan loan, CancellationToken cancellationToken = default) => CreateLoanAsync(loan, null, cancellationToken);

        /// <summary>
        /// Creates a new loan in Encompass and returns the loan id of the loan created and optionally populates the loan object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="loan">The loan to create.</param>
        /// <param name="populate">Indicates if the loan object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> CreateLoanAsync(Loan loan, bool populate, CancellationToken cancellationToken = default) => CreateLoanAsync(loan, new CreateLoanOptions { Populate = populate }, cancellationToken);

        /// <summary>
        /// Creates a new loan in Encompass with the optionally specified <paramref name="createLoanOptions"/> and returns the loan id of the loan created.
        /// </summary>
        /// <param name="loan">The loan to create.</param>
        /// <param name="createLoanOptions">The loan creation options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task<string> CreateLoanAsync(Loan loan, CreateLoanOptions createLoanOptions, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(loan, nameof(loan));
            Preconditions.NullOrEmpty(loan.EncompassId, $"{nameof(loan)}.{nameof(loan.EncompassId)}");

            var loanId = await PostPopulateDirtyAsync(null, createLoanOptions?.ToQueryParameters().ToString(), nameof(CreateLoanAsync), loan, createLoanOptions?.Populate == true, cancellationToken).ConfigureAwait(false);
            loan.Initialize(Client, loanId);
            return loanId;
        }

        /// <summary>
        /// Creates a new loan in Encompass using raw json and returns the loan id of the loan created.
        /// </summary>
        /// <param name="loan">The loan to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> CreateLoanRawAsync(string loan, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loan, nameof(loan));

            return PostAsync(null, queryString, new JsonStringContent(loan), nameof(CreateLoanRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
        }

        /// <summary>
        /// Updates an existing loan by modifying the values of the loan data elements passed.
        /// </summary>
        /// <param name="loan">The loan to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task UpdateLoanAsync(Loan loan, CancellationToken cancellationToken = default) => UpdateLoanAsync(loan, null, cancellationToken);

        /// <summary>
        /// Updates an existing loan by modifying the values of the loan data elements passed and optionally populates the loan object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="loan">The loan to update.</param>
        /// <param name="populate">Indicates if the loan object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task UpdateLoanAsync(Loan loan, bool populate, CancellationToken cancellationToken = default) => UpdateLoanAsync(loan, new UpdateLoanOptions { Populate = populate }, cancellationToken);

        /// <summary>
        /// Updates an existing loan by modifying the values of the loan data elements passed with the optionally specified <paramref name="updateLoanOptions"/>.
        /// </summary>
        /// <param name="loan">The loan to update.</param>
        /// <param name="updateLoanOptions">The loan update options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task UpdateLoanAsync(Loan loan, UpdateLoanOptions updateLoanOptions, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(loan, nameof(loan));
            Preconditions.NotNullOrEmpty(loan.EncompassId, $"{nameof(loan)}.{nameof(loan.EncompassId)}");

            loan.Initialize(Client, loan.EncompassId);
            return PatchPopulateDirtyAsync(loan.EncompassId, updateLoanOptions?.ToQueryParameters().ToString(), JsonStreamContent.Create(loan), nameof(UpdateLoanAsync), loan.EncompassId, loan, updateLoanOptions?.Populate == true, cancellationToken);
        }

        /// <summary>
        /// Updates an existing loan by modifying the values of the loan data elements passed or by applying a loan template using raw json.
        /// </summary>
        /// <param name="loanId">The loan id of the loan to update.</param>
        /// <param name="loan">The loan to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> UpdateLoanRawAsync(string loanId, string loan, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));
            Preconditions.NotNullOrEmpty(loan, nameof(loan));

            return PatchRawAsync(loanId, queryString, new JsonStringContent(loan), nameof(UpdateLoanRawAsync), loanId, cancellationToken);
        }

        /// <summary>
        /// Deletes a specified loan by moving it to the Recycle Bin or Trash folder.
        /// </summary>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<bool> DeleteLoanAsync(string loanId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return DeleteAsync(loanId, null, cancellationToken);
        }
    }
}