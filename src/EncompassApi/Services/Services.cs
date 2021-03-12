using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EncompassApi.Utilities;
using EnumsNET;

namespace EncompassApi.Services
{
    /// <summary>
    /// The Services Apis.
    /// </summary>
    public interface IServices : IApiObject
    {
        /// <summary>
        /// Retrieves details on a service order transaction.
        /// </summary>
        /// <param name="partnerId">Ellie Mae's unique identifier for the Partner service provider.</param>
        /// <param name="transactionId">The unique identifier of the transaction provided in the response header when the order was submitted.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<ServiceTransaction> GetServiceOrderStatusAsync(string partnerId, string transactionId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves details on a service order transaction.
        /// </summary>
        /// <param name="partnerId">Ellie Mae's unique identifier for the Partner service provider.</param>
        /// <param name="transactionId">The unique identifier of the transaction provided in the response header when the order was submitted.</param>
        /// <param name="generateFileUrls">Generates temporary URL's for the resources returned by the service provider as part of their response.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<ServiceTransaction> GetServiceOrderStatusAsync(string partnerId, string transactionId, bool? generateFileUrls, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves details on a service order transaction as raw json.
        /// </summary>
        /// <param name="partnerId">Ellie Mae's unique identifier for the Partner service provider.</param>
        /// <param name="transactionId">The unique identifier of the transaction provided in the response header when the order was submitted.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetServiceOrderStatusRawAsync(string partnerId, string transactionId, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Submits an order for a service and creates a transaction object and returns the transaction id.
        /// </summary>
        /// <param name="partnerId">Ellie Mae's unique identifier for the Partner service provider.</param>
        /// <param name="parameters">The parameters for ordering a service.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> OrderServiceAsync(string partnerId, OrderServiceParameters parameters, CancellationToken cancellationToken = default);
        /// <summary>
        /// Submits an order for a service from raw json and creates a transaction object and returns the response body if not empty else the transaction id.
        /// </summary>
        /// <param name="partnerId">Ellie Mae's unique identifier for the Partner service provider.</param>
        /// <param name="parameters">The parameters for ordering a service as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> OrderServiceRawAsync(string partnerId, string parameters, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Use this API transforms an Encompass Loan to a MISMO 3.4 XML format for ULAD (DU or LPA) and iLAD as a byte array.
        /// </summary>
        /// <param name="loanId">Unique identifier of the Encompass Loan</param>
        /// <param name="format">Format that you want to export the loan to.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<byte[]> ExportLoanToMismoAsync(string loanId, MismoFormat format, CancellationToken cancellationToken = default);
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
        Task<Stream> ExportLoanToMismoStreamAsync(string loanId, MismoFormat format, CancellationToken cancellationToken = default);
        /// <summary>
        /// Use this API transforms an Encompass Loan to a MISMO 3.4 XML format for ULAD (DU or LPA) and iLAD as a stream.
        /// </summary>
        /// <param name="loanId">Unique identifier of the Encompass Loan</param>
        /// <param name="format">Format that you want to export the loan to.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Stream> ExportLoanToMismoStreamAsync(string loanId, string format, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The Services Apis.
    /// </summary>
    public sealed class Services : ApiObject, IServices
    {
        internal Services(IEncompassApiClient client)
            : base(client, "services")
        {
        }

        /// <inheritdoc/>
        public Task<string> OrderServiceAsync(string partnerId, OrderServiceParameters parameters, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(partnerId, nameof(partnerId));
            Preconditions.NotNull(parameters, nameof(parameters));

            return PostAsync($"v1/partners/{partnerId}/transactions", null, JsonStreamContent.Create(parameters), nameof(OrderServiceAsync), partnerId, cancellationToken, ReadLocationFunc);
        }

        /// <inheritdoc/>
        public Task<string> OrderServiceRawAsync(string partnerId, string parameters, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(partnerId, nameof(partnerId));
            Preconditions.NotNullOrEmpty(parameters, nameof(parameters));

            return PostAsync($"v1/partners/{partnerId}/transactions", queryString, new JsonStringContent(parameters), nameof(OrderServiceRawAsync), partnerId, cancellationToken, ReadAsStringElseLocationFunc);
        }

        /// <inheritdoc/>
        public Task<ServiceTransaction> GetServiceOrderStatusAsync(string partnerId, string transactionId, CancellationToken cancellationToken = default) => GetServiceOrderStatusAsync(partnerId, transactionId, null, cancellationToken);

        /// <inheritdoc/>
        public Task<ServiceTransaction> GetServiceOrderStatusAsync(string partnerId, string transactionId, bool? generateFileUrls, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(partnerId, nameof(partnerId));
            Preconditions.NotNullOrEmpty(transactionId, nameof(transactionId));

            var queryParameters = new QueryParameters();
            if (generateFileUrls.HasValue)
            {
                queryParameters.Add("generateFileUrls", generateFileUrls.ToString().ToLower());
            }

            return GetAsync<ServiceTransaction>($"v1/partners/{partnerId}/transactions/{transactionId}", queryParameters.ToString(), nameof(GetServiceOrderStatusAsync), $"{partnerId}/{transactionId}", cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> GetServiceOrderStatusRawAsync(string partnerId, string transactionId, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(partnerId, nameof(partnerId));
            Preconditions.NotNullOrEmpty(transactionId, nameof(transactionId));

            return GetRawAsync($"v1/partners/{partnerId}/transactions/{transactionId}", queryString, nameof(GetServiceOrderStatusRawAsync), $"{partnerId}/{transactionId}", cancellationToken);
        }

        /// <inheritdoc/>
        public Task<byte[]> ExportLoanToMismoAsync(string loanId, MismoFormat format, CancellationToken cancellationToken = default) => ExportLoanToMismoAsync(loanId, format.Validate(nameof(format)).GetValue()!, cancellationToken);

        /// <inheritdoc/>
        public Task<byte[]> ExportLoanToMismoAsync(string loanId, string format, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));
            Preconditions.NotNullOrEmpty(format, nameof(format));

            var queryParamerters = new QueryParameters();
            queryParamerters.Add("loanId", loanId);
            queryParamerters.Add("format", format);

            return SendAsync(HttpMethod.Get, "v1/transformer", queryParamerters.ToString(), null, nameof(ExportLoanToMismoAsync), loanId, cancellationToken, ReadAsByteArrayFunc);
        }

        /// <inheritdoc/>
        public Task<Stream> ExportLoanToMismoStreamAsync(string loanId, MismoFormat format, CancellationToken cancellationToken = default) => ExportLoanToMismoStreamAsync(loanId, format.Validate(nameof(format)).GetValue()!, cancellationToken);

        /// <inheritdoc/>
        public Task<Stream> ExportLoanToMismoStreamAsync(string loanId, string format, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));
            Preconditions.NotNullOrEmpty(format, nameof(format));

            var queryParamerters = new QueryParameters();
            queryParamerters.Add("loanId", loanId);
            queryParamerters.Add("format", format);

            return SendAsync(HttpMethod.Get, "v1/transformer", queryParamerters.ToString(), null, nameof(ExportLoanToMismoAsync), loanId, cancellationToken, ReadAsStreamFunc, true, false);
        }
    }
}