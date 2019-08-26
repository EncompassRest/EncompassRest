using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.FieldReader
{
    /// <summary>
    /// The Loan Field Reader Apis.
    /// </summary>
    public sealed class LoanFieldReader : LoanApiObject
    {
        internal LoanFieldReader(EncompassRestClient client, string loanId)
            : base(client, loanId, "fieldReader")
        {
        }

        /// <summary>
        /// Retrieve values for specific fields in a loan.
        /// </summary>
        /// <param name="fieldIds">Field IDs of the values you want to retrieve from the loan.</param>
        /// <returns></returns>
        public Task<List<LoanFieldValue>> GetLoanFieldValuesAsync(params string[] fieldIds) => GetLoanFieldValuesAsync(fieldIds, default);

        /// <summary>
        /// Retrieve values for specific fields in a loan.
        /// </summary>
        /// <param name="fieldIds">Field IDs of the values you want to retrieve from the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<List<LoanFieldValue>> GetLoanFieldValuesAsync(IEnumerable<string> fieldIds, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldIds, nameof(fieldIds));

            return PostAsync<List<LoanFieldValue>>(null, null, JsonStreamContent.Create(fieldIds), nameof(GetLoanFieldValuesAsync), null, cancellationToken);
        }

        /// <summary>
        /// Retrieve values for specific fields in a loan as raw json.
        /// </summary>
        /// <param name="fieldIds">Field IDs of the values you want to retrieve from the loan as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetLoanFieldValuesRawAsync(string fieldIds, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldIds, nameof(fieldIds));

            return PostRawAsync(null, queryString, new JsonStringContent(fieldIds), nameof(GetLoanFieldValuesRawAsync), null, cancellationToken);
        }
    }
}