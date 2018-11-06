using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Webhook
{
    /// <summary>
    /// The Webhook Apis.
    /// </summary>
    public sealed class Webhook : ApiObject
    {
        internal Webhook(EncompassRestClient client)
            : base(client, "webhook/v1")
        {
        }

        /// <summary>
        /// Returns all available webhook resources and events that are available for subscription.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<List<WebhookResource>> GetResourcesAsync(CancellationToken cancellationToken = default) => GetAsync<List<WebhookResource>>("resources", null, nameof(GetResourcesAsync), null, cancellationToken);

        /// <summary>
        /// Returns all available webhook resources and events that are available for subscription as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetResourcesRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync("resources", queryString, nameof(GetResourcesRawAsync), null, cancellationToken);

        /// <summary>
        /// Returns the specified webhook resource and events that are available.
        /// </summary>
        /// <param name="resourceName">Name of the resource for which to return results.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<WebhookResource> GetResourceAsync(WebhookResourceType resourceName, CancellationToken cancellationToken = default) => GetResourceAsync(resourceName.Validate(nameof(resourceName)).GetValue(), cancellationToken);

        /// <summary>
        /// Returns the specified webhook resource and events that are available.
        /// </summary>
        /// <param name="resourceName">Name of the resource for which to return results.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<WebhookResource> GetResourceAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceName, nameof(resourceName));

            return GetAsync<WebhookResource>($"resources/{resourceName}", null, nameof(GetResourcesAsync), null, cancellationToken);
        }

        /// <summary>
        /// Returns the specified webhook resource and events that are available as raw json.
        /// </summary>
        /// <param name="resourceName">Name of the resource for which to return results.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetResourceRawAsync(string resourceName, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceName, nameof(resourceName));

            return GetRawAsync($"resources/{resourceName}", queryString, nameof(GetResourcesRawAsync), null, cancellationToken);
        }

        /// <summary>
        /// Returns the specified webhook resource events that are available.
        /// </summary>
        /// <param name="resourceName">The resource name.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<List<WebhookResourceEventObject>> GetResourceEventsAsync(WebhookResourceType resourceName, CancellationToken cancellationToken = default) => GetResourceEventsAsync(resourceName.Validate(nameof(resourceName)).GetValue(), cancellationToken);

        /// <summary>
        /// Returns the specified webhook resource events that are available.
        /// </summary>
        /// <param name="resourceName">The resource name.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<List<WebhookResourceEventObject>> GetResourceEventsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceName, nameof(resourceName));

            return GetAsync<List<WebhookResourceEventObject>>($"resources/{resourceName}/events", null, nameof(GetResourceEventsAsync), resourceName, cancellationToken);
        }

        /// <summary>
        /// Returns the specified webhook resource events that are available as raw json.
        /// </summary>
        /// <param name="resourceName">The resource name.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetResourceEventsRawAsync(string resourceName, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceName, nameof(resourceName));

            return GetRawAsync($"resources/{resourceName}/events", queryString, nameof(GetResourceEventsRawAsync), resourceName, cancellationToken);
        }

        /// <summary>
        /// Returns a list of subscriptions.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<List<WebhookSubscription>> GetSubscriptionsAsync(CancellationToken cancellationToken = default) => GetSubscriptionsAsync((IEnumerable<string>)null, null, cancellationToken);

        /// <summary>
        /// Returns a list of subscriptions.
        /// </summary>
        /// <param name="resources">Resource names to include.</param>
        /// <param name="events">Include subscriptions with these specified events.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<List<WebhookSubscription>> GetSubscriptionsAsync(IEnumerable<WebhookResourceType> resources, IEnumerable<WebhookResourceEvent> events, CancellationToken cancellationToken = default) => GetSubscriptionsAsync(resources?.Select(r => r.Validate(nameof(resources)).GetValue()), events?.Select(e => e.Validate(nameof(events)).GetValue()), cancellationToken);

        /// <summary>
        /// Returns a list of subscriptions.
        /// </summary>
        /// <param name="resources">Resource names to include.</param>
        /// <param name="events">Include subscriptions with these specified events.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<List<WebhookSubscription>> GetSubscriptionsAsync(IEnumerable<string> resources, IEnumerable<string> events, CancellationToken cancellationToken = default)
        {
            var queryParameters = new QueryParameters();
            if (resources?.Any() == true)
            {
                queryParameters.Add("resource", string.Join(",", resources));
            }
            if (events?.Any() == true)
            {
                queryParameters.Add("events", string.Join(",", events));
            }

            return GetDirtyListAsync<WebhookSubscription>("subscriptions", queryParameters.ToString(), nameof(GetSubscriptionsAsync), null, cancellationToken);
        }

        /// <summary>
        /// Returns a list of subscriptions as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetSubscriptionsRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync("subscriptions", queryString, nameof(GetSubscriptionsRawAsync), null, cancellationToken);

        /// <summary>
        /// Returns the specified subscription.
        /// </summary>
        /// <param name="subscriptionId">Unique identifier assigned to the subscription.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<WebhookSubscription> GetSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            return GetDirtyAsync<WebhookSubscription>($"subscriptions/{subscriptionId}", null, nameof(GetSubscriptionAsync), subscriptionId, cancellationToken);
        }

        /// <summary>
        /// Returns the specified subscription as raw json.
        /// </summary>
        /// <param name="subscriptionId">Unique identifier assigned to the subscription.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetSubscriptionRawAsync(string subscriptionId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            return GetRawAsync($"subscriptions/{subscriptionId}", queryString, nameof(GetSubscriptionRawAsync), subscriptionId, cancellationToken);
        }

        /// <summary>
        /// Creates a new subscription for specified Encompass instance and returns the created subscription's id.
        /// </summary>
        /// <param name="subscription">The webhook subscription to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> CreateSubscriptionAsync(WebhookSubscription subscription, CancellationToken cancellationToken = default) => CreateSubscriptionAsync(subscription, false, cancellationToken);

        private Task<string> CreateSubscriptionAsync(WebhookSubscription subscription, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(subscription, nameof(subscription));
            Preconditions.NullOrEmpty(subscription.SubscriptionId, $"{nameof(subscription)}.{nameof(subscription.SubscriptionId)}");

            return PostPopulateDirtyAsync("subscriptions", nameof(CreateSubscriptionAsync), subscription, populate, cancellationToken);
        }

        /// <summary>
        /// Creates a new subscription for specified Encompass instance from raw json and returns the created subscription's id.
        /// </summary>
        /// <param name="subscription">The webhook subscription to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> CreateSubscriptionRawAsync(string subscription, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(subscription, nameof(subscription));

            return PostAsync("subscriptions", queryString, new JsonStringContent(subscription), nameof(CreateSubscriptionRawAsync), null, cancellationToken, ReadLocationFunc);
        }

        /// <summary>
        /// Updates the specified subscription.
        /// </summary>
        /// <param name="subscription">The webhook subscription to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task UpdateSubscriptionAsync(WebhookSubscription subscription, CancellationToken cancellationToken = default) => UpdateSubscriptionAsync(subscription, false, cancellationToken);

        private Task UpdateSubscriptionAsync(WebhookSubscription subscription, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(subscription, nameof(subscription));
            Preconditions.NotNullOrEmpty(subscription.SubscriptionId, $"{nameof(subscription)}.{nameof(subscription.SubscriptionId)}");

            return PutPopulateDirtyAsync($"subscriptions/{subscription.SubscriptionId}", JsonStreamContent.Create(subscription), nameof(UpdateSubscriptionAsync), subscription.SubscriptionId, subscription, populate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified subscription from raw json.
        /// </summary>
        /// <param name="subscriptionId">Unique identifier assigned to the subscription.</param>
        /// <param name="subscription">The webhook subscription to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> UpdateSubscriptionRawAsync(string subscriptionId, string subscription, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Preconditions.NotNullOrEmpty(subscription, nameof(subscription));

            return PutRawAsync($"subscriptions/{subscriptionId}", queryString, new JsonStringContent(subscription), nameof(UpdateSubscriptionRawAsync), null, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified subscription.
        /// </summary>
        /// <param name="subscriptionId">Unique identifier assigned to the subscription.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<bool> DeleteSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            return DeleteAsync($"subscriptions/{subscriptionId}", null, cancellationToken);
        }
    }
}