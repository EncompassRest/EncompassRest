using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Services
{
    public sealed class Services : ApiObject
    {
        internal Services(EncompassRestClient client)
            : base(client, "services/v1/partners")
        {
        }

        /// <summary>
        /// This is an UNTESTED feature. Please report back to GitHub for any issues.
        /// </summary>
        /// <param name="partnerId"></param>
        /// <param name="parameters"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<string> OrderServiceAsync(string partnerId, OrderServiceParameters parameters, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(partnerId, nameof(partnerId));
            Preconditions.NotNull(parameters, nameof(parameters));

            return PostAsync($"{partnerId}/transactions", null, JsonStreamContent.Create(parameters), nameof(OrderServiceAsync), partnerId, cancellationToken, ReadLocationFunc);
        }

        public Task<string> OrderServiceRawAsync(string partnerId, string parameters, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(partnerId, nameof(partnerId));
            Preconditions.NotNullOrEmpty(parameters, nameof(parameters));

            return PostAsync($"{partnerId}/transactions", queryString, new JsonStringContent(parameters), nameof(OrderServiceRawAsync), partnerId, cancellationToken, ReadAsStringElseLocationFunc);
        }

        public Task<ServiceTransaction> GetServiceOrderStatusAsync(string partnerId, string transactionId, CancellationToken cancellationToken = default) => GetServiceOrderStatusAsync(partnerId, transactionId, null, cancellationToken);

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

        public Task<string> GetServiceOrderStatusRawAsync(string partnerId, string transactionId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(partnerId, nameof(partnerId));
            Preconditions.NotNullOrEmpty(transactionId, nameof(transactionId));

            return GetRawAsync($"{partnerId}/transactions/{transactionId}", queryString, nameof(GetServiceOrderStatusRawAsync), $"{partnerId}/{transactionId}", cancellationToken);
        }
    }
}