using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Services.v1;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// The Loan Apis Services extension methods.
    /// </summary>
    public static class LoanApisServicesExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static ILoanApisV1Services? V1 { get; set; }

        private static ILoanApisV1Services GetV1(ILoanApis loanApis)
        {
            var v1 = V1;
            if (loanApis is LoanApis a)
            {
                v1 = a.ExtensionData.GetOrAdd(() => new LoanApisV1Services(a.Client, a.LoanApis, a.LoanId));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(loanApis, nameof(loanApis));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Use this API transforms an Encompass Loan to a MISMO 3.4 XML format for ULAD (DU or LPA) and iLAD as a byte array.
        /// </summary>
        /// <param name="loanApis">The Loan Apis Object.</param>
        /// <param name="format">Format that you want to export the loan to.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<byte[]> ExportToMismoAsync(this ILoanApis loanApis, MismoFormat format, CancellationToken cancellationToken = default) => ExportToMismoAsync(loanApis, format.Validate(nameof(format)).GetValue()!, cancellationToken);

        /// <summary>
        /// Use this API transforms an Encompass Loan to a MISMO 3.4 XML format for ULAD (DU or LPA) and iLAD as a byte array.
        /// </summary>
        /// <param name="loanApis">The Loan Apis Object.</param>
        /// <param name="format">Format that you want to export the loan to.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<byte[]> ExportToMismoAsync(this ILoanApis loanApis, string format, CancellationToken cancellationToken = default) => GetV1(loanApis).ExportToMismoAsync(format, cancellationToken);

        /// <summary>
        /// Use this API transforms an Encompass Loan to a MISMO 3.4 XML format for ULAD (DU or LPA) and iLAD as a stream.
        /// </summary>
        /// <param name="loanApis">The Loan Apis Object.</param>
        /// <param name="format">Format that you want to export the loan to.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Stream> ExportToMismoStreamAsync(this ILoanApis loanApis, MismoFormat format, CancellationToken cancellationToken = default) => ExportToMismoStreamAsync(loanApis, format.Validate(nameof(format)).GetValue()!, cancellationToken);

        /// <summary>
        /// Use this API transforms an Encompass Loan to a MISMO 3.4 XML format for ULAD (DU or LPA) and iLAD as a stream.
        /// </summary>
        /// <param name="loanApis">The Loan Apis Object.</param>
        /// <param name="format">Format that you want to export the loan to.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Stream> ExportToMismoStreamAsync(this ILoanApis loanApis, string format, CancellationToken cancellationToken = default) => GetV1(loanApis).ExportToMismoStreamAsync(format, cancellationToken);
    }
}
