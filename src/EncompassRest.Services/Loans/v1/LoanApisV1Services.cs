using System.IO;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Services.v1;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// The Services Loan Apis.
    /// </summary>
    public interface ILoanApisV1Services : IApiObject
    {
        /// <summary>
        /// Use this API transforms an Encompass Loan to a MISMO 3.4 XML format for ULAD (DU or LPA) and iLAD as a byte array.
        /// </summary>
        /// <param name="format">Format that you want to export the loan to.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<byte[]> ExportToMismoAsync(string format, CancellationToken cancellationToken = default);
        /// <summary>
        /// Use this API transforms an Encompass Loan to a MISMO 3.4 XML format for ULAD (DU or LPA) and iLAD as a stream.
        /// </summary>
        /// <param name="format">Format that you want to export the loan to.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Stream> ExportToMismoStreamAsync(string format, CancellationToken cancellationToken = default);
    }

    internal sealed class LoanApisV1Services : LoanApiObjectV1, ILoanApisV1Services
    {
        internal LoanApisV1Services(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, null)
        {
        }

        public Task<byte[]> ExportToMismoAsync(string format, CancellationToken cancellationToken = default) => Client.Services.ExportLoanToMismoAsync(LoanId, format, cancellationToken);

        public Task<Stream> ExportToMismoStreamAsync(string format, CancellationToken cancellationToken = default) => Client.Services.ExportLoanToMismoStreamAsync(LoanId, format, cancellationToken);
    }
}