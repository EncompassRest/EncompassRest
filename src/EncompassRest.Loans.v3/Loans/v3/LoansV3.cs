using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.v3
{
    /// <summary>
    /// The Loans Apis.
    /// </summary>
    public interface ILoansV3 : IApiObject
    {
        /// <summary>
        /// The loan field descriptors.
        /// </summary>
        ILoanFieldDescriptors FieldDescriptors { get; }

        /// <summary>
        /// Creates a new loan in Encompass with the optionally specified <paramref name="options"/> and returns the loan id of the loan created.
        /// </summary>
        /// <param name="loan">The loan to create.</param>
        /// <param name="options">The loan creation options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateLoanAsync(Loan loan, LoanCreationOptions options, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new loan in Encompass using raw json and returns the loan id of the loan created.
        /// </summary>
        /// <param name="loan">The loan to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateLoanRawAsync(string loan, string queryString, CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes a specified loan by moving it to the Recycle Bin or Trash folder.
        /// </summary>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task DeleteLoanAsync(string loanId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes a specified loan by moving it to the Recycle Bin or Trash folder.
        /// </summary>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<bool> TryDeleteLoanAsync(string loanId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the Loan Apis for the loan.
        /// </summary>
        /// <param name="loan">The loan.</param>
        /// <returns></returns>
        ILoanObjectBoundApis GetLoanApis(Loan loan);
        /// <summary>
        /// Returns the specific entities of a loan.
        /// </summary>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="options">The loan retrieval options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Loan> GetLoanAsync(string loanId, LoanRetrievalOptions? options = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the entire loan or specific entities of a loan as raw json.
        /// </summary>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetLoanRawAsync(string loanId, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an existing loan by modifying the values of the loan data elements passed with the optionally specified <paramref name="options"/>.
        /// </summary>
        /// <param name="loan">The loan to update.</param>
        /// <param name="options">The loan update options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UpdateLoanAsync(Loan loan, LoanUpdateOptions? options = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an existing loan by modifying the values of the loan data elements passed or by applying a loan template using raw json.
        /// </summary>
        /// <param name="loanId">The loan id of the loan to update.</param>
        /// <param name="loan">The loan to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> UpdateLoanRawAsync(string loanId, string loan, string? queryString = null, CancellationToken cancellationToken = default);
    }

    internal sealed class LoansV3 : ApiObject, ILoansV3
    {
        private LoanFieldDescriptors? _fieldDescriptors;

        public ILoanFieldDescriptors FieldDescriptors
        {
            get
            {
                var fieldDescriptors = _fieldDescriptors;
                return fieldDescriptors ?? Interlocked.CompareExchange(ref _fieldDescriptors, (fieldDescriptors = new LoanFieldDescriptors(Client)), null) ?? fieldDescriptors;
            }
        }

        internal LoansV3(EncompassRestClient client)
            : base(client, "encompass/v3")
        {
        }

        public ILoanObjectBoundApis GetLoanApis(Loan loan)
        {
            Preconditions.NotNull(loan, nameof(loan));
            Preconditions.NotNullOrEmpty(loan.Id, $"{nameof(loan)}.{nameof(loan.Id)}");

            return new LoanObjectBoundApis(Client, loan);
        }

        public async Task<Loan> GetLoanAsync(string loanId, LoanRetrievalOptions? options = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            var loan = await GetDirtyAsync<Loan>($"loans/{loanId}", options?.ToQueryParameters().ToString(), nameof(GetLoanAsync), loanId, cancellationToken).ConfigureAwait(false);
            loan.Initialize(Client, loan.Id!);
            return loan;
        }

        public Task<string> GetLoanRawAsync(string loanId, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return GetRawAsync($"loans/{loanId}", queryString, nameof(GetLoanRawAsync), loanId, cancellationToken);
        }

        public async Task<string> CreateLoanAsync(Loan loan, LoanCreationOptions options, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(loan, nameof(loan));
            Preconditions.NullOrEmpty(loan.Id, $"{nameof(loan)}.{nameof(loan.Id)}");
            Preconditions.NotNull(options, nameof(options));

            var loanId = await PostPopulateDirtyAsync("loans", options.ToQueryParameters().ToString(), nameof(CreateLoanAsync), loan, true, cancellationToken).ConfigureAwait(false);
            loan.Initialize(Client, loanId);
            return loanId;
        }

        public Task<string> CreateLoanRawAsync(string loan, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loan, nameof(loan));
            Preconditions.NotNullOrEmpty(queryString, nameof(queryString));

            return PostAsync("loans", queryString, new JsonStringContent(loan), nameof(CreateLoanRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
        }

        public Task UpdateLoanAsync(Loan loan, LoanUpdateOptions? options, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(loan, nameof(loan));
            Preconditions.NotNullOrEmpty(loan.Id, $"{nameof(loan)}.{nameof(loan.Id)}");

            loan.Initialize(Client, loan.Id);
            return PatchPopulateDirtyAsync($"loans/{loan.Id}", options?.ToQueryParameters().ToString(), JsonStreamContent.Create(loan), nameof(UpdateLoanAsync), loan.Id, loan, true, cancellationToken);
        }

        public Task<string> UpdateLoanRawAsync(string loanId, string loan, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));
            Preconditions.NotNullOrEmpty(loan, nameof(loan));

            return PatchRawAsync($"loans/{loanId}", queryString, new JsonStringContent(loan), nameof(UpdateLoanRawAsync), loanId, cancellationToken);
        }

        public Task DeleteLoanAsync(string loanId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return DeleteAsync($"loans/{loanId}", null, cancellationToken);
        }

        public Task<bool> TryDeleteLoanAsync(string loanId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return TryDeleteAsync($"loans/{loanId}", null, cancellationToken);
        }
    }
}