using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Webhook.v1
{
    /// <summary>
    /// The Webhook Apis.
    /// </summary>
    public interface IWebhookV1 : IApiObject
    {
        /// <summary>
        /// Creates a new subscription for specified Encompass instance and returns the created subscription's id.
        /// </summary>
        /// <param name="subscription">The webhook subscription to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateSubscriptionAsync(WebhookSubscription subscription, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new subscription for specified Encompass instance from raw json and returns the created subscription's id.
        /// </summary>
        /// <param name="subscription">The webhook subscription to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateSubscriptionRawAsync(string subscription, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes the specified subscription.
        /// </summary>
        /// <param name="subscriptionId">Unique identifier assigned to the subscription.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task DeleteSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the specified webhook resource and events that are available.
        /// </summary>
        /// <param name="resourceName">Name of the resource for which to return results.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<WebhookResource> GetResourceAsync(string resourceName, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the specified webhook resource events that are available.
        /// </summary>
        /// <param name="resourceName">The resource name.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<WebhookResourceEventObject>> GetResourceEventsAsync(string resourceName, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the specified webhook resource events that are available as raw json.
        /// </summary>
        /// <param name="resourceName">The resource name.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetResourceEventsRawAsync(string resourceName, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the specified webhook resource and events that are available as raw json.
        /// </summary>
        /// <param name="resourceName">Name of the resource for which to return results.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetResourceRawAsync(string resourceName, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns all available webhook resources and events that are available for subscription.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<WebhookResource>> GetResourcesAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns all available webhook resources and events that are available for subscription as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetResourcesRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the specified subscription.
        /// </summary>
        /// <param name="subscriptionId">Unique identifier assigned to the subscription.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<WebhookSubscription> GetSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the specified subscription as raw json.
        /// </summary>
        /// <param name="subscriptionId">Unique identifier assigned to the subscription.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetSubscriptionRawAsync(string subscriptionId, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns a list of subscriptions.
        /// </summary>
        /// <param name="resources">Resource names to include.</param>
        /// <param name="events">Include subscriptions with these specified events.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<WebhookSubscription>> GetSubscriptionsAsync(IEnumerable<string>? resources, IEnumerable<string>? events, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns a list of subscriptions as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetSubscriptionsRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes the specified subscription.
        /// </summary>
        /// <param name="subscriptionId">Unique identifier assigned to the subscription.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<bool> TryDeleteSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates the specified subscription.
        /// </summary>
        /// <param name="subscription">The webhook subscription to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UpdateSubscriptionAsync(WebhookSubscription subscription, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates the specified subscription from raw json.
        /// </summary>
        /// <param name="subscriptionId">Unique identifier assigned to the subscription.</param>
        /// <param name="subscription">The webhook subscription to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> UpdateSubscriptionRawAsync(string subscriptionId, string subscription, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns all webhook events that occurred on the Lender Platform.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<WebhookEvent>> GetEventsAsync(WebhookEventOptions? options = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns all webhook events that occurred on the Lender Platform as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetEventsRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the specified webhook event.
        /// </summary>
        /// <param name="eventId">Unique identifier of the event to return.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<WebhookEvent>> GetEventAsync(string eventId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the specified webhook event as raw json.
        /// </summary>
        /// <param name="eventId">Unique identifier of the event to return.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetEventRawAsync(string eventId, string? queryString = null, CancellationToken cancellationToken = default);
    }

    internal sealed class WebhookV1 : ApiObject, IWebhookV1
    {
        internal WebhookV1(EncompassRestClient client)
            : base(client, "webhook/v1")
        {
        }

        public Task<List<WebhookResource>> GetResourcesAsync(CancellationToken cancellationToken = default) => GetListAsync<WebhookResource>("resources", null, nameof(GetResourcesAsync), null, cancellationToken);

        public Task<string> GetResourcesRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync("resources", queryString, nameof(GetResourcesRawAsync), null, cancellationToken);

        public Task<WebhookResource> GetResourceAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceName, nameof(resourceName));

            return GetAsync<WebhookResource>($"resources/{resourceName}", null, nameof(GetResourcesAsync), null, cancellationToken);
        }

        public Task<string> GetResourceRawAsync(string resourceName, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceName, nameof(resourceName));

            return GetRawAsync($"resources/{resourceName}", queryString, nameof(GetResourcesRawAsync), null, cancellationToken);
        }

        public Task<List<WebhookResourceEventObject>> GetResourceEventsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceName, nameof(resourceName));

            return GetListAsync<WebhookResourceEventObject>($"resources/{resourceName}/events", null, nameof(GetResourceEventsAsync), resourceName, cancellationToken);
        }

        public Task<string> GetResourceEventsRawAsync(string resourceName, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceName, nameof(resourceName));

            return GetRawAsync($"resources/{resourceName}/events", queryString, nameof(GetResourceEventsRawAsync), resourceName, cancellationToken);
        }

        public Task<List<WebhookSubscription>> GetSubscriptionsAsync(IEnumerable<string>? resources, IEnumerable<string>? events, CancellationToken cancellationToken = default)
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

            return GetListAsync<WebhookSubscription>("subscriptions", queryParameters.ToString(), nameof(GetSubscriptionsAsync), null, cancellationToken);
        }

        public Task<string> GetSubscriptionsRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync("subscriptions", queryString, nameof(GetSubscriptionsRawAsync), null, cancellationToken);

        public Task<WebhookSubscription> GetSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            return GetAsync<WebhookSubscription>($"subscriptions/{subscriptionId}", null, nameof(GetSubscriptionAsync), subscriptionId, cancellationToken);
        }

        public Task<string> GetSubscriptionRawAsync(string subscriptionId, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            return GetRawAsync($"subscriptions/{subscriptionId}", queryString, nameof(GetSubscriptionRawAsync), subscriptionId, cancellationToken);
        }

        public Task<string> CreateSubscriptionAsync(WebhookSubscription subscription, CancellationToken cancellationToken = default) => CreateSubscriptionAsync(subscription, false, cancellationToken);

        private Task<string> CreateSubscriptionAsync(WebhookSubscription subscription, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(subscription, nameof(subscription));
            Preconditions.NullOrEmpty(subscription.SubscriptionId, $"{nameof(subscription)}.{nameof(subscription.SubscriptionId)}");

            return PostPopulateDirtyAsync("subscriptions", nameof(CreateSubscriptionAsync), subscription, populate, cancellationToken);
        }

        public Task<string> CreateSubscriptionRawAsync(string subscription, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(subscription, nameof(subscription));

            return PostAsync("subscriptions", queryString, new JsonStringContent(subscription), nameof(CreateSubscriptionRawAsync), null, cancellationToken, ReadLocationFunc);
        }

        public Task UpdateSubscriptionAsync(WebhookSubscription subscription, CancellationToken cancellationToken = default) => UpdateSubscriptionAsync(subscription, false, cancellationToken);

        private Task UpdateSubscriptionAsync(WebhookSubscription subscription, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(subscription, nameof(subscription));
            Preconditions.NotNullOrEmpty(subscription.SubscriptionId, $"{nameof(subscription)}.{nameof(subscription.SubscriptionId)}");

            return PutPopulateDirtyAsync($"subscriptions/{subscription.SubscriptionId}", JsonStreamContent.Create(subscription), nameof(UpdateSubscriptionAsync), subscription.SubscriptionId, subscription, populate, cancellationToken);
        }

        public Task<string> UpdateSubscriptionRawAsync(string subscriptionId, string subscription, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Preconditions.NotNullOrEmpty(subscription, nameof(subscription));

            return PutRawAsync($"subscriptions/{subscriptionId}", queryString, new JsonStringContent(subscription), nameof(UpdateSubscriptionRawAsync), null, cancellationToken);
        }

        public Task<bool> TryDeleteSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            return TryDeleteAsync($"subscriptions/{subscriptionId}", null, cancellationToken);
        }

        public Task DeleteSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            return DeleteAsync($"subscriptions/{subscriptionId}", null, cancellationToken);
        }

        public Task<List<WebhookEvent>> GetEventsAsync(WebhookEventOptions? options = null, CancellationToken cancellationToken = default) => GetListAsync<WebhookEvent>("events", options?.ToQueryParameters().ToString(), nameof(GetEventsAsync), null, cancellationToken);

        public Task<string> GetEventsRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync("events", queryString, nameof(GetEventsRawAsync), null, cancellationToken);

        public Task<List<WebhookEvent>> GetEventAsync(string eventId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(eventId, nameof(eventId));

            return GetListAsync<WebhookEvent>($"events/{eventId}", null, nameof(GetEventAsync), eventId, cancellationToken);
        }

        public Task<string> GetEventRawAsync(string eventId, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(eventId, nameof(eventId));

            return GetRawAsync($"events/{eventId}", queryString, nameof(GetEventRawAsync), eventId, cancellationToken);
        }
    }
}