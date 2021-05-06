using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Services.v1
{
    public static class ServicesExtensions
    {
        public static IServicesV1? V1 { get; set; }

        private static IServicesV1 GetV1(IServices services)
        {
            var v1 = V1;
            if (services is Services s)
            {
                v1 = (IServicesV1)s.ExtensionData.GetOrAdd("v1", k => new ServicesV1(s.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(services, nameof(services));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Retrieves details on a service order transaction.
        /// </summary>
        /// <param name="partnerId">Ellie Mae's unique identifier for the Partner service provider.</param>
        /// <param name="transactionId">The unique identifier of the transaction provided in the response header when the order was submitted.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<ServiceTransaction> GetServiceOrderStatusAsync(this IServices services, string partnerId, string transactionId, CancellationToken cancellationToken = default) => GetServiceOrderStatusAsync(services, partnerId, transactionId, generateFileUrls: null, cancellationToken);

        /// <summary>
        /// Retrieves details on a service order transaction.
        /// </summary>
        /// <param name="partnerId">Ellie Mae's unique identifier for the Partner service provider.</param>
        /// <param name="transactionId">The unique identifier of the transaction provided in the response header when the order was submitted.</param>
        /// <param name="generateFileUrls">Generates temporary URL's for the resources returned by the service provider as part of their response.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<ServiceTransaction> GetServiceOrderStatusAsync(this IServices services, string partnerId, string transactionId, bool? generateFileUrls, CancellationToken cancellationToken = default) => GetV1(services).GetServiceOrderStatusAsync(partnerId, transactionId, generateFileUrls, cancellationToken);

        /// <summary>
        /// Retrieves details on a service order transaction as raw json.
        /// </summary>
        /// <param name="partnerId">Ellie Mae's unique identifier for the Partner service provider.</param>
        /// <param name="transactionId">The unique identifier of the transaction provided in the response header when the order was submitted.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetServiceOrderStatusRawAsync(this IServices services, string partnerId, string transactionId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(services).GetServiceOrderStatusRawAsync(partnerId, transactionId, queryString, cancellationToken);

        /// <summary>
        /// Submits an order for a service and creates a transaction object and returns the transaction id.
        /// </summary>
        /// <param name="partnerId">Ellie Mae's unique identifier for the Partner service provider.</param>
        /// <param name="parameters">The parameters for ordering a service.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> OrderServiceAsync(this IServices services, string partnerId, OrderServiceParameters parameters, CancellationToken cancellationToken = default) => GetV1(services).OrderServiceAsync(partnerId, parameters, cancellationToken);

        /// <summary>
        /// Submits an order for a service from raw json and creates a transaction object and returns the response body if not empty else the transaction id.
        /// </summary>
        /// <param name="partnerId">Ellie Mae's unique identifier for the Partner service provider.</param>
        /// <param name="parameters">The parameters for ordering a service as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> OrderServiceRawAsync(this IServices services, string partnerId, string parameters, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(services).OrderServiceRawAsync(partnerId, parameters, queryString, cancellationToken);

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