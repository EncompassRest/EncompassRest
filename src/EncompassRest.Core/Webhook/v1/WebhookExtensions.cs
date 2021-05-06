using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Webhook.v1
{
    public static class WebhookExtensions
    {
        public static IWebhookV1? V1 { get; set; }

        private static IWebhookV1 GetV1(IWebhook webhook)
        {
            var v1 = V1;
            if (webhook is Webhook w)
            {
                v1 = (IWebhookV1)w.ExtensionData.GetOrAdd("v1", k => new WebhookV1(w.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(webhook, nameof(webhook));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Creates a new subscription for specified Encompass instance and returns the created subscription's id.
        /// </summary>
        /// <param name="subscription">The webhook subscription to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateSubscriptionAsync(this IWebhook webhook, WebhookSubscription subscription, CancellationToken cancellationToken = default) => GetV1(webhook).CreateSubscriptionAsync(subscription, cancellationToken);

        /// <summary>
        /// Creates a new subscription for specified Encompass instance from raw json and returns the created subscription's id.
        /// </summary>
        /// <param name="subscription">The webhook subscription to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateSubscriptionRawAsync(this IWebhook webhook, string subscription, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(webhook).CreateSubscriptionRawAsync(subscription, queryString, cancellationToken);

        /// <summary>
        /// Deletes the specified subscription.
        /// </summary>
        /// <param name="subscriptionId">Unique identifier assigned to the subscription.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task DeleteSubscriptionAsync(this IWebhook webhook, string subscriptionId, CancellationToken cancellationToken = default) => GetV1(webhook).DeleteSubscriptionAsync(subscriptionId, cancellationToken);

        /// <summary>
        /// Returns the specified webhook resource and events that are available.
        /// </summary>
        /// <param name="resourceName">Name of the resource for which to return results.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<WebhookResource> GetResourceAsync(this IWebhook webhook, string resourceName, CancellationToken cancellationToken = default) => GetV1(webhook).GetResourceAsync(resourceName, cancellationToken);

        /// <summary>
        /// Returns the specified webhook resource and events that are available.
        /// </summary>
        /// <param name="resourceName">Name of the resource for which to return results.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<WebhookResource> GetResourceAsync(this IWebhook webhook, WebhookResourceType resourceName, CancellationToken cancellationToken = default) => GetResourceAsync(webhook, resourceName.Validate(nameof(resourceName)).GetValue()!, cancellationToken);

        /// <summary>
        /// Returns the specified webhook resource events that are available.
        /// </summary>
        /// <param name="resourceName">The resource name.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<WebhookResourceEventObject>> GetResourceEventsAsync(this IWebhook webhook, string resourceName, CancellationToken cancellationToken = default) => GetV1(webhook).GetResourceEventsAsync(resourceName, cancellationToken);

        /// <summary>
        /// Returns the specified webhook resource events that are available.
        /// </summary>
        /// <param name="resourceName">The resource name.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<WebhookResourceEventObject>> GetResourceEventsAsync(this IWebhook webhook, WebhookResourceType resourceName, CancellationToken cancellationToken = default) => GetResourceEventsAsync(webhook, resourceName.Validate(nameof(resourceName)).GetValue()!, cancellationToken);

        /// <summary>
        /// Returns the specified webhook resource events that are available as raw json.
        /// </summary>
        /// <param name="resourceName">The resource name.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetResourceEventsRawAsync(this IWebhook webhook, string resourceName, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(webhook).GetResourceEventsRawAsync(resourceName, queryString, cancellationToken);

        /// <summary>
        /// Returns the specified webhook resource and events that are available as raw json.
        /// </summary>
        /// <param name="resourceName">Name of the resource for which to return results.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetResourceRawAsync(this IWebhook webhook, string resourceName, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(webhook).GetResourceRawAsync(resourceName, queryString, cancellationToken);

        /// <summary>
        /// Returns all available webhook resources and events that are available for subscription.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<WebhookResource>> GetResourcesAsync(this IWebhook webhook, CancellationToken cancellationToken = default) => GetV1(webhook).GetResourcesAsync(cancellationToken);

        /// <summary>
        /// Returns all available webhook resources and events that are available for subscription as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetResourcesRawAsync(this IWebhook webhook, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(webhook).GetResourcesRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Returns the specified subscription.
        /// </summary>
        /// <param name="subscriptionId">Unique identifier assigned to the subscription.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<WebhookSubscription> GetSubscriptionAsync(this IWebhook webhook, string subscriptionId, CancellationToken cancellationToken = default) => GetV1(webhook).GetSubscriptionAsync(subscriptionId, cancellationToken);

        /// <summary>
        /// Returns the specified subscription as raw json.
        /// </summary>
        /// <param name="subscriptionId">Unique identifier assigned to the subscription.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetSubscriptionRawAsync(this IWebhook webhook, string subscriptionId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(webhook).GetSubscriptionRawAsync(subscriptionId, queryString, cancellationToken);

        /// <summary>
        /// Returns a list of subscriptions.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<WebhookSubscription>> GetSubscriptionsAsync(this IWebhook webhook, CancellationToken cancellationToken = default) => GetSubscriptionsAsync(webhook, (IEnumerable<string>?)null, null, cancellationToken);

        /// <summary>
        /// Returns a list of subscriptions.
        /// </summary>
        /// <param name="resources">Resource names to include.</param>
        /// <param name="events">Include subscriptions with these specified events.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<WebhookSubscription>> GetSubscriptionsAsync(this IWebhook webhook, IEnumerable<string>? resources, IEnumerable<string>? events, CancellationToken cancellationToken = default) => GetV1(webhook).GetSubscriptionsAsync(resources, events, cancellationToken);

        /// <summary>
        /// Returns a list of subscriptions.
        /// </summary>
        /// <param name="resources">Resource names to include.</param>
        /// <param name="events">Include subscriptions with these specified events.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<WebhookSubscription>> GetSubscriptionsAsync(this IWebhook webhook, IEnumerable<WebhookResourceType>? resources, IEnumerable<WebhookResourceEvent>? events, CancellationToken cancellationToken = default) => GetSubscriptionsAsync(webhook, resources?.Select(r => r.Validate(nameof(resources)).GetValue()!), events?.Select(e => e.Validate(nameof(events)).GetValue()!), cancellationToken);

        /// <summary>
        /// Returns a list of subscriptions as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetSubscriptionsRawAsync(this IWebhook webhook, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(webhook).GetSubscriptionsRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Deletes the specified subscription.
        /// </summary>
        /// <param name="subscriptionId">Unique identifier assigned to the subscription.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<bool> TryDeleteSubscriptionAsync(this IWebhook webhook, string subscriptionId, CancellationToken cancellationToken = default) => GetV1(webhook).TryDeleteSubscriptionAsync(subscriptionId, cancellationToken);

        /// <summary>
        /// Updates the specified subscription.
        /// </summary>
        /// <param name="subscription">The webhook subscription to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateSubscriptionAsync(this IWebhook webhook, WebhookSubscription subscription, CancellationToken cancellationToken = default) => GetV1(webhook).UpdateSubscriptionAsync(subscription, cancellationToken);

        /// <summary>
        /// Updates the specified subscription from raw json.
        /// </summary>
        /// <param name="subscriptionId">Unique identifier assigned to the subscription.</param>
        /// <param name="subscription">The webhook subscription to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> UpdateSubscriptionRawAsync(this IWebhook webhook, string subscriptionId, string subscription, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(webhook).UpdateSubscriptionRawAsync(subscriptionId, subscription, queryString, cancellationToken);

        /// <summary>
        /// Returns all webhook events that occurred on the Lender Platform.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<WebhookEvent>> GetEventsAsync(this IWebhook webhook, WebhookEventOptions? options = null, CancellationToken cancellationToken = default) => GetV1(webhook).GetEventsAsync(options, cancellationToken);

        /// <summary>
        /// Returns all webhook events that occurred on the Lender Platform as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetEventsRawAsync(this IWebhook webhook, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(webhook).GetEventsRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Returns the specified webhook event.
        /// </summary>
        /// <param name="eventId">Unique identifier of the event to return.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<WebhookEvent>> GetEventAsync(this IWebhook webhook, string eventId, CancellationToken cancellationToken = default) => GetV1(webhook).GetEventAsync(eventId, cancellationToken);

        /// <summary>
        /// Returns the specified webhook event as raw json.
        /// </summary>
        /// <param name="eventId">Unique identifier of the event to return.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetEventRawAsync(this IWebhook webhook, string eventId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(webhook).GetEventRawAsync(eventId, queryString, cancellationToken);
    }
}