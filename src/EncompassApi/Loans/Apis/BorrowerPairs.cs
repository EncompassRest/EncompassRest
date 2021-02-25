using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassApi.Utilities;

namespace EncompassApi.Loans.Apis
{
    /// <summary>
    /// The Loan Borrower Pairs Apis.
    /// </summary>
    public interface IBorrowerPairs : ILoanApiObject
    {
        /// <summary>
        /// Creates a new borrower pair for the loan and returns the application id.
        /// </summary>
        /// <param name="application">The borrower pair to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateBorrowerPairAsync(Application application, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new borrower pair for the loan from raw json and returns the response body if not empty or else the application id.
        /// </summary>
        /// <param name="application">The borrower pair to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateBorrowerPairRawAsync(string application, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Permanently deletes the borrower pair with the specified <paramref name="applicationId"/> from the loan.
        /// </summary>
        /// <param name="applicationId">The application id of the borrower pair to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task DeleteBorrowerPairAsync(string applicationId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves the loan's borrower pair with the specified <paramref name="applicationId"/>.
        /// </summary>
        /// <param name="applicationId">The application id of the borrower pair to get.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Application> GetBorrowerPairAsync(string applicationId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves the loan's borrower pair with the specified <paramref name="applicationId"/>.
        /// </summary>
        /// <param name="applicationId">The application id of the borrower pair to get.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetBorrowerPairRawAsync(string applicationId, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves all borrower pairs for the loan.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<IList<Application>> GetBorrowerPairsAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves all borrower pairs for the loan as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetBorrowerPairsRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Swaps the position of borrower pairs in the loan. Note that the <see cref="Borrower.AltId"/> of the borrower and co-borrower do not change on the applications.
        /// </summary>
        /// <param name="applications">The applications to swap.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task MoveBorrowerPairsAsync(IList<Application> applications, CancellationToken cancellationToken = default);
        /// <summary>
        /// Swaps the position of borrower pairs in the loan from raw json. Note that the altIds of the borrower and co-borrower do not change on the applications.
        /// </summary>
        /// <param name="applications">The applications to swap as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task MoveBorrowerPairsRawAsync(string applications, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Permanently deletes the borrower pair with the specified <paramref name="applicationId"/> from the loan.
        /// </summary>
        /// <param name="applicationId">The application id of the borrower pair to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<bool> TryDeleteBorrowerPairAsync(string applicationId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an existing borrower pair for the loan.
        /// </summary>
        /// <param name="application">The borrower pair to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UpdateBorrowerPairAsync(Application application, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an existing borrower pair for the loan from raw json.
        /// </summary>
        /// <param name="applicationId">The application id of the borrower pair to update.</param>
        /// <param name="application">The borrower pair to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> UpdateBorrowerPairRawAsync(string applicationId, string application, string? queryString = null, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The Loan Borrower Pairs Apis.
    /// </summary>
    public sealed class BorrowerPairs : LoanApiObject<Application>, IBorrowerPairs
    {
        internal BorrowerPairs(EncompassApiClient client, LoanObjectBoundApis? loanObjectBoundApis, string loanId)
            : base(client, loanObjectBoundApis, loanId, "applications")
        {
        }

        internal override IList<Application> GetInLoan(Loan loan) => loan.Applications;

        /// <inheritdoc/>
        public Task<IList<Application>> GetBorrowerPairsAsync(CancellationToken cancellationToken = default) => GetAllAsync(nameof(GetBorrowerPairsAsync), cancellationToken);

        /// <inheritdoc/>
        public Task<string> GetBorrowerPairsRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetBorrowerPairsRawAsync), null, cancellationToken);

        /// <inheritdoc/>
        public Task<Application> GetBorrowerPairAsync(string applicationId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(applicationId, nameof(applicationId));

            return GetAsync(applicationId, nameof(GetBorrowerPairAsync), cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> GetBorrowerPairRawAsync(string applicationId, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(applicationId, nameof(applicationId));

            return GetRawAsync(applicationId, queryString, nameof(GetBorrowerPairRawAsync), applicationId, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> CreateBorrowerPairAsync(Application application, CancellationToken cancellationToken = default) => CreateBorrowerPairAsync(application, false, cancellationToken);

        private Task<string> CreateBorrowerPairAsync(Application application, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(application, nameof(application));
            Preconditions.NullOrEmpty(application.Id, $"{nameof(application)}.{nameof(application.Id)}");

            return CreateAsync(application, nameof(CreateBorrowerPairAsync), populate, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> CreateBorrowerPairRawAsync(string application, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(application, nameof(application));

            return PostAsync(null, queryString, new JsonStringContent(application), nameof(CreateBorrowerPairRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
        }

        /// <inheritdoc/>
        public Task UpdateBorrowerPairAsync(Application application, CancellationToken cancellationToken = default) => UpdateBorrowerPairAsync(application, false, cancellationToken);

        private Task UpdateBorrowerPairAsync(Application application, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(application, nameof(application));
            Preconditions.NotNullOrEmpty(application.Id, $"{nameof(application)}.{nameof(application.Id)}");

            return UpdateAsync(application, nameof(UpdateBorrowerPairAsync), populate, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> UpdateBorrowerPairRawAsync(string applicationId, string application, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(applicationId, nameof(applicationId));
            Preconditions.NotNullOrEmpty(application, nameof(application));

            return PatchRawAsync(applicationId, queryString, new JsonStringContent(application), nameof(UpdateBorrowerPairRawAsync), applicationId, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<bool> TryDeleteBorrowerPairAsync(string applicationId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(applicationId, nameof(applicationId));

            return TryDeleteAsync(applicationId, cancellationToken);
        }

        /// <inheritdoc/>
        public Task DeleteBorrowerPairAsync(string applicationId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(applicationId, nameof(applicationId));

            return DeleteAsync(applicationId, cancellationToken);
        }

        /// <inheritdoc/>
        public async Task MoveBorrowerPairsAsync(IList<Application> applications, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(applications, nameof(applications));
            Preconditions.NotAnyNull(applications, nameof(applications));

            await PatchAsync(null, null, JsonStreamContent.Create(applications), nameof(MoveBorrowerPairsAsync), null, cancellationToken).ConfigureAwait(false);
            if (LoanObjectBoundApis?.ReflectToLoanObject == true)
            {
                var bps = LoanObjectBoundApis.Loan.Applications;
                var borrowers = new Dictionary<string, Tuple<int, Borrower>>(StringComparer.OrdinalIgnoreCase);
                foreach (var bp in bps)
                {
                    var borrower = bp.Borrower;
                    var altId = borrower.AltId;
                    if (!string.IsNullOrEmpty(altId))
                    {
                        borrowers.Add(altId!, Tuple.Create(0, borrower));
                    }
                    borrower = bp.Coborrower;
                    altId = borrower.AltId;
                    if (!string.IsNullOrEmpty(altId))
                    {
                        borrowers.Add(altId!, Tuple.Create(1, borrower));
                    }
                }
                var altIds = bps.Select(bp => new[] { bp.Borrower.AltId, bp.Coborrower.AltId }).ToList();
                foreach (var application in applications)
                {
                    var id = application.Id;
                    var found = false;
                    for (var i = 0; i < bps.Count; ++i)
                    {
                        var bp = bps[i];
                        if (string.Equals(id, bp.Id, StringComparison.OrdinalIgnoreCase))
                        {
                            var index = application.ApplicationIndex;
                            if (index.HasValue)
                            {
                                bp.ApplicationIndex = index;
                            }
                            var altId = application.Borrower.AltId;
                            if (string.IsNullOrEmpty(altId))
                            {
                                bp.Borrower = null;
                            }
                            else
                            {
                                if (borrowers.TryGetValue(altId!, out var tuple))
                                {
                                    bp.Borrower = tuple.Item2;
                                    bp.Borrower.AltId = altIds[i][tuple.Item1];
                                }
                                else
                                {
                                    break;
                                }
                            }
                            altId = application.Coborrower.AltId;
                            if (string.IsNullOrEmpty(altId))
                            {
                                bp.Coborrower = null;
                            }
                            else
                            {
                                if (borrowers.TryGetValue(altId!, out var tuple))
                                {
                                    bp.Coborrower = tuple.Item2;
                                    bp.Coborrower.AltId = altIds[i][tuple.Item1];
                                }
                                else
                                {
                                    break;
                                }
                            }
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        break;
                    }
                }
            }
        }

        /// <inheritdoc/>
        public Task MoveBorrowerPairsRawAsync(string applications, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(applications, nameof(applications));

            return PatchAsync(null, queryString, new JsonStringContent(applications), nameof(MoveBorrowerPairsRawAsync), null, cancellationToken);
        }
    }
}