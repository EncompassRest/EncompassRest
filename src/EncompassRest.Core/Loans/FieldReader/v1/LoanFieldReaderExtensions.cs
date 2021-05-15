using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.FieldReader.v1
{
    /// <summary>
    /// The Loan Field Reader Api extension methods.
    /// </summary>
    public static class LoanFieldReaderExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static ILoanFieldReaderV1? V1 { get; set; }

        private static ILoanFieldReaderV1 GetV1(ILoanFieldReader fieldReader)
        {
            var v1 = V1;
            if (fieldReader is LoanFieldReader r)
            {
                v1 = r.ExtensionData.GetOrAdd(() => new LoanFieldReaderV1(r.Client, r.LoanApis, r.LoanId));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(fieldReader, nameof(fieldReader));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Retrieve values for specific fields in a loan.
        /// </summary>
        /// <param name="fieldReader">The Loan Field Reader Api Object.</param>
        /// <param name="fieldIds">Field IDs of the values you want to retrieve from the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<LoanFieldValue>> GetLoanFieldValuesAsync(this ILoanFieldReader fieldReader, IEnumerable<string> fieldIds, CancellationToken cancellationToken = default) => GetLoanFieldValuesAsync(fieldReader, includeMetadata: null, fieldIds, cancellationToken);

        /// <summary>
        /// Retrieve values for specific fields in a loan.
        /// </summary>
        /// <param name="fieldReader">The Loan Field Reader Api Object.</param>
        /// <param name="fieldIds">Field IDs of the values you want to retrieve from the loan.</param>
        /// <returns></returns>
        public static Task<List<LoanFieldValue>> GetLoanFieldValuesAsync(this ILoanFieldReader fieldReader, params string[] fieldIds) => GetLoanFieldValuesAsync(fieldReader, includeMetadata: null, fieldIds, default);

        /// <summary>
        /// Retrieve values for specific fields in a loan as raw json.
        /// </summary>
        /// <param name="fieldReader">The Loan Field Reader Api Object.</param>
        /// <param name="fieldIds">Field IDs of the values you want to retrieve from the loan as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetLoanFieldValuesRawAsync(this ILoanFieldReader fieldReader, string fieldIds, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(fieldReader).GetLoanFieldValuesRawAsync(fieldIds, queryString, cancellationToken);

        /// <summary>
        /// Retrieve values for specific fields in a loan.
        /// </summary>
        /// <param name="fieldReader">The Loan Field Reader Api Object.</param>
        /// <param name="includeMetadata">If set to true, the response will include the metadata for the fields specified, and returns details such as format, description, type, options and readOnly indicator.Default behavior is false, in which case, only the fieldId and value are returned for the fields in the request body.</param>
        /// <param name="fieldIds">Field IDs of the values you want to retrieve from the loan.</param>
        /// <returns></returns>
        public static Task<List<LoanFieldValue>> GetLoanFieldValuesAsync(this ILoanFieldReader fieldReader, bool? includeMetadata, params string[] fieldIds) => GetLoanFieldValuesAsync(fieldReader, includeMetadata, fieldIds, default);

        /// <summary>
        /// Retrieve values for specific fields in a loan.
        /// </summary>
        /// <param name="fieldReader">The Loan Field Reader Api Object.</param>
        /// <param name="includeMetadata">If set to true, the response will include the metadata for the fields specified, and returns details such as format, description, type, options and readOnly indicator.Default behavior is false, in which case, only the fieldId and value are returned for the fields in the request body.</param>
        /// <param name="fieldIds">Field IDs of the values you want to retrieve from the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<LoanFieldValue>> GetLoanFieldValuesAsync(this ILoanFieldReader fieldReader, bool? includeMetadata, IEnumerable<string> fieldIds, CancellationToken cancellationToken = default) => GetV1(fieldReader).GetLoanFieldValuesAsync(includeMetadata, fieldIds, cancellationToken);
    }
}