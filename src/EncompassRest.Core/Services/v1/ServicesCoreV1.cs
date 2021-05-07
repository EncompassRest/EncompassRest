using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Services.v1
{
    /// <summary>
    /// The Services Core Apis.
    /// </summary>
    public interface IServicesCoreV1 : IApiObject
    {
        /// <summary>
        /// Use this API transforms an Encompass Loan to a MISMO 3.4 XML format for ULAD (DU or LPA) and iLAD as a byte array.
        /// </summary>
        /// <param name="loanId">Unique identifier of the Encompass Loan</param>
        /// <param name="format">Format that you want to export the loan to.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<byte[]> ExportLoanToMismoAsync(string loanId, string format, CancellationToken cancellationToken = default);
        /// <summary>
        /// Use this API transforms an Encompass Loan to a MISMO 3.4 XML format for ULAD (DU or LPA) and iLAD as a stream.
        /// </summary>
        /// <param name="loanId">Unique identifier of the Encompass Loan</param>
        /// <param name="format">Format that you want to export the loan to.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Stream> ExportLoanToMismoStreamAsync(string loanId, string format, CancellationToken cancellationToken = default);
    }

    internal class ServicesCoreV1 : ApiObject, IServicesCoreV1
    {
        internal ServicesCoreV1(EncompassRestClient client)
            : base(client, "services/v1")
        {
        }

        public Task<byte[]> ExportLoanToMismoAsync(string loanId, string format, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));
            Preconditions.NotNullOrEmpty(format, nameof(format));

            var queryParamerters = new QueryParameters();
            queryParamerters.Add("loanId", loanId);
            queryParamerters.Add("format", format);

            return SendAsync(HttpMethod.Get, "transformer", queryParamerters.ToString(), null, nameof(ExportLoanToMismoAsync), loanId, cancellationToken, ReadAsByteArrayFunc);
        }

        public Task<Stream> ExportLoanToMismoStreamAsync(string loanId, string format, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));
            Preconditions.NotNullOrEmpty(format, nameof(format));

            var queryParamerters = new QueryParameters();
            queryParamerters.Add("loanId", loanId);
            queryParamerters.Add("format", format);

            return SendAsync(HttpMethod.Get, "transformer", queryParamerters.ToString(), null, nameof(ExportLoanToMismoAsync), loanId, cancellationToken, ReadAsStreamFunc, true, false);
        }
    }
}