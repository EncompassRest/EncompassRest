using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Services.v1
{
    public static class ServicesCoreExtensions
    {
        public static IServicesCoreV1? V1 { get; set; }

        private static IServicesCoreV1 GetV1(IServices services)
        {
            var v1 = V1;
            if (services is Services s)
            {
                v1 = (IServicesCoreV1)s.ExtensionData.GetOrAdd("v1Core", k => new ServicesCoreV1(s.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(services, nameof(services));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Use this API transforms an Encompass Loan to a MISMO 3.4 XML format for ULAD (DU or LPA) and iLAD as a byte array.
        /// </summary>
        /// <param name="loanId">Unique identifier of the Encompass Loan</param>
        /// <param name="format">Format that you want to export the loan to.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<byte[]> ExportLoanToMismoAsync(this IServices services, string loanId, MismoFormat format, CancellationToken cancellationToken = default) => ExportLoanToMismoAsync(services, loanId, format.Validate(nameof(format)).GetValue()!, cancellationToken);

        /// <summary>
        /// Use this API transforms an Encompass Loan to a MISMO 3.4 XML format for ULAD (DU or LPA) and iLAD as a byte array.
        /// </summary>
        /// <param name="loanId">Unique identifier of the Encompass Loan</param>
        /// <param name="format">Format that you want to export the loan to.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<byte[]> ExportLoanToMismoAsync(this IServices services, string loanId, string format, CancellationToken cancellationToken = default) => GetV1(services).ExportLoanToMismoAsync(loanId, format, cancellationToken);

        /// <summary>
        /// Use this API transforms an Encompass Loan to a MISMO 3.4 XML format for ULAD (DU or LPA) and iLAD as a stream.
        /// </summary>
        /// <param name="loanId">Unique identifier of the Encompass Loan</param>
        /// <param name="format">Format that you want to export the loan to.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Stream> ExportLoanToMismoStreamAsync(this IServices services, string loanId, MismoFormat format, CancellationToken cancellationToken = default) => ExportLoanToMismoStreamAsync(services, loanId, format.Validate(nameof(format)).GetValue()!, cancellationToken);

        /// <summary>
        /// Use this API transforms an Encompass Loan to a MISMO 3.4 XML format for ULAD (DU or LPA) and iLAD as a stream.
        /// </summary>
        /// <param name="loanId">Unique identifier of the Encompass Loan</param>
        /// <param name="format">Format that you want to export the loan to.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Stream> ExportLoanToMismoStreamAsync(this IServices services, string loanId, string format, CancellationToken cancellationToken = default) => GetV1(services).ExportLoanToMismoStreamAsync(loanId, format, cancellationToken);
    }
}
