using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Services
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
        Task<string> GetServiceOrderStatusRawAsync(string partnerId, string transactionId, string queryString = null, CancellationToken cancellationToken = default);
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
        Task<string> OrderServiceRawAsync(string partnerId, string parameters, string queryString = null, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The Services Apis.
    /// </summary>
    public sealed class Services : ApiObject, IServices
    {
        internal Services(EncompassRestClient client)
            : base(client, "services/v1/partners")
        {
        }

        /// <summary>
        /// Submits an order for a service and creates a transaction object and returns the transaction id.
        /// </summary>
        /// <param name="partnerId">Ellie Mae's unique identifier for the Partner service provider.</param>
        /// <param name="parameters">The parameters for ordering a service.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> OrderServiceAsync(string partnerId, OrderServiceParameters parameters, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(partnerId, nameof(partnerId));
            Preconditions.NotNull(parameters, nameof(parameters));

            return PostAsync($"{partnerId}/transactions", null, JsonStreamContent.Create(parameters), nameof(OrderServiceAsync), partnerId, cancellationToken, ReadLocationFunc);
        }

        /// <summary>
        /// Submits an order for a service from raw json and creates a transaction object and returns the response body if not empty else the transaction id.
        /// </summary>
        /// <param name="partnerId">Ellie Mae's unique identifier for the Partner service provider.</param>
        /// <param name="parameters">The parameters for ordering a service as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> OrderServiceRawAsync(string partnerId, string parameters, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(partnerId, nameof(partnerId));
            Preconditions.NotNullOrEmpty(parameters, nameof(parameters));

            return PostAsync($"{partnerId}/transactions", queryString, new JsonStringContent(parameters), nameof(OrderServiceRawAsync), partnerId, cancellationToken, ReadAsStringElseLocationFunc);
        }

        /// <summary>
        /// Retrieves details on a service order transaction.
        /// </summary>
        /// <param name="partnerId">Ellie Mae's unique identifier for the Partner service provider.</param>
        /// <param name="transactionId">The unique identifier of the transaction provided in the response header when the order was submitted.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<ServiceTransaction> GetServiceOrderStatusAsync(string partnerId, string transactionId, CancellationToken cancellationToken = default) => GetServiceOrderStatusAsync(partnerId, transactionId, null, cancellationToken);

        /// <summary>
        /// Retrieves details on a service order transaction.
        /// </summary>
        /// <param name="partnerId">Ellie Mae's unique identifier for the Partner service provider.</param>
        /// <param name="transactionId">The unique identifier of the transaction provided in the response header when the order was submitted.</param>
        /// <param name="generateFileUrls">Generates temporary URL's for the resources returned by the service provider as part of their response.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<ServiceTransaction> GetServiceOrderStatusAsync(string partnerId, string transactionId, bool? generateFileUrls, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(partnerId, nameof(partnerId));
            Preconditions.NotNullOrEmpty(transactionId, nameof(transactionId));

            var queryParameters = new QueryParameters();
            if (generateFileUrls.HasValue)
            {
                queryParameters.Add("generateFileUrls", generateFileUrls.ToString().ToLower());
            }

            return GetAsync<ServiceTransaction>($"{partnerId}/transactions/{transactionId}", queryParameters.ToString(), nameof(GetServiceOrderStatusAsync), $"{partnerId}/{transactionId}", cancellationToken);
        }

        /// <summary>
        /// Retrieves details on a service order transaction as raw json.
        /// </summary>
        /// <param name="partnerId">Ellie Mae's unique identifier for the Partner service provider.</param>
        /// <param name="transactionId">The unique identifier of the transaction provided in the response header when the order was submitted.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetServiceOrderStatusRawAsync(string partnerId, string transactionId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(partnerId, nameof(partnerId));
            Preconditions.NotNullOrEmpty(transactionId, nameof(transactionId));

            return GetRawAsync($"{partnerId}/transactions/{transactionId}", queryString, nameof(GetServiceOrderStatusRawAsync), $"{partnerId}/{transactionId}", cancellationToken);
        }
    }
}