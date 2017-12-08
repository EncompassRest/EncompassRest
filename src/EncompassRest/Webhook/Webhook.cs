using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Webhook
{
    public sealed class Webhook : ApiObject
    {
        internal Webhook(EncompassRestClient client)
            : base(client, "webhook/v1")
        {
        }

        public Task<List<WebhookResource>> GetResourcesAsync(CancellationToken cancellationToken = default) => GetAsync<List<WebhookResource>>("resources", null, nameof(GetResourcesAsync), null, cancellationToken);

        public Task<string> GetResourcesRawAsync(CancellationToken cancellationToken = default) => GetRawAsync("resources", null, nameof(GetResourcesRawAsync), null, cancellationToken);

        public Task<List<StringEnumValue<WebhookResourceEvent>>> GetResourceEventsAsync(WebhookResourceType resourceName, CancellationToken cancellationToken = default) => GetResourceEventsAsync(resourceName.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name), cancellationToken);

        public Task<List<StringEnumValue<WebhookResourceEvent>>> GetResourceEventsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceName, nameof(resourceName));

            return GetAsync<List<StringEnumValue<WebhookResourceEvent>>>($"resources/{resourceName}/events", null, nameof(GetResourceEventsAsync), resourceName, cancellationToken);
        }

        public Task<string> GetResourceEventsRawAsync(WebhookResourceType resourceName, CancellationToken cancellationToken = default) => GetResourceEventsRawAsync(resourceName.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name), cancellationToken);

        public Task<string> GetResourceEventsRawAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceName, nameof(resourceName));

            return GetRawAsync($"resources/{resourceName}/events", null, nameof(GetResourceEventsRawAsync), resourceName, cancellationToken);
        }

        public Task<WebhookSubscription> GetSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            return GetDirtyAsync<WebhookSubscription>($"subscriptions/{subscriptionId}", null, nameof(GetSubscriptionAsync), subscriptionId, cancellationToken);
        }

        public Task<string> GetSubscriptionRawAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            return GetRawAsync($"subscriptions/{subscriptionId}", null, nameof(GetSubscriptionRawAsync), subscriptionId, cancellationToken);
        }

        public Task<List<WebhookSubscription>> GetSubscriptionsAsync(CancellationToken cancellationToken = default) => GetSubscriptionsAsync((IEnumerable<string>)null, null, cancellationToken);

        public Task<List<WebhookSubscription>> GetSubscriptionsAsync(IEnumerable<WebhookResourceType> resources, IEnumerable<WebhookResourceEvent> events, CancellationToken cancellationToken = default) => GetSubscriptionsAsync(resources?.Select(r => r.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)), events?.Select(e => e.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)), cancellationToken);

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

        public Task<string> GetSubscriptionsRawAsync(CancellationToken cancellationToken = default) => GetSubscriptionsRawAsync(null, cancellationToken);

        public Task<string> GetSubscriptionsRawAsync(IEnumerable<WebhookResourceType> resources, IEnumerable<WebhookResourceEvent> events, CancellationToken cancellationToken = default) => GetSubscriptionsRawAsync(resources?.Select(r => r.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)), events?.Select(e => e.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)), cancellationToken);

        public Task<string> GetSubscriptionsRawAsync(IEnumerable<string> resources, IEnumerable<string> events, CancellationToken cancellationToken = default)
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

            return GetSubscriptionsRawAsync(queryParameters.ToString(), cancellationToken);
        }

        public Task<string> GetSubscriptionsRawAsync(string queryString, CancellationToken cancellationToken = default) => GetRawAsync("subscriptions", queryString, nameof(GetSubscriptionsRawAsync), null, cancellationToken);

        public Task<string> CreateSubscriptionAsync(WebhookSubscription subscription, CancellationToken cancellationToken = default) => CreateSubscriptionAsync(subscription, false, cancellationToken);

        private Task<string> CreateSubscriptionAsync(WebhookSubscription subscription, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(subscription, nameof(subscription));
            Preconditions.NullOrEmpty(subscription.SubscriptionId, $"{nameof(subscription)}.{nameof(subscription.SubscriptionId)}");

            return PostAsync("subscriptions", populate ? ViewEntityQueryString : null, JsonStreamContent.Create(subscription), nameof(CreateSubscriptionAsync), null, cancellationToken, async response =>
            {
                var subscriptionId = GetLocation(response);
                subscription.SubscriptionId = subscriptionId;
                if (populate)
                {
                    await response.Content.PopulateAsync(subscription).ConfigureAwait(false);
                }
                subscription.Dirty = false;
                return subscriptionId;
            });
        }

        public Task<string> CreateSubscriptionRawAsync(string subscription, CancellationToken cancellationToken = default) => CreateSubscriptionRawAsync(subscription, null, cancellationToken);

        private Task<string> CreateSubscriptionRawAsync(string subscription, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(subscription, nameof(subscription));

            return PostAsync("subscriptions", queryString, new JsonStringContent(subscription), nameof(CreateSubscriptionRawAsync), null, cancellationToken, ReadLocationFunc);
        }

        public Task UpdateSubscriptionAsync(WebhookSubscription subscription, CancellationToken cancellationToken = default) => UpdateSubscriptionAsync(subscription, false, cancellationToken);

        private Task UpdateSubscriptionAsync(WebhookSubscription subscription, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(subscription, nameof(subscription));
            Preconditions.NotNullOrEmpty(subscription.SubscriptionId, $"{nameof(subscription)}.{nameof(subscription.SubscriptionId)}");

            return PutPopulateDirtyAsync($"subscriptions/{subscription.SubscriptionId}", JsonStreamContent.Create(subscription), nameof(UpdateSubscriptionAsync), subscription.SubscriptionId, cancellationToken, subscription, populate);
        }

        public Task<string> UpdateSubscriptionRawAsync(string subscriptionId, string subscription, CancellationToken cancellationToken = default) => UpdateSubscriptionRawAsync(subscriptionId, subscription, null, cancellationToken);

        private Task<string> UpdateSubscriptionRawAsync(string subscriptionId, string subscription, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Preconditions.NotNullOrEmpty(subscription, nameof(subscription));

            return PutRawAsync($"subscriptions/{subscriptionId}", queryString, new JsonStringContent(subscription), nameof(UpdateSubscriptionRawAsync), null, cancellationToken);
        }

        public Task<bool> DeleteSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            return DeleteAsync($"subscriptions/{subscriptionId}", cancellationToken);
        }
    }
}