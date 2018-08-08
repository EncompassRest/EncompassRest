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

        public Task<string> GetResourcesRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync("resources", queryString, nameof(GetResourcesRawAsync), null, cancellationToken);

        public Task<List<StringEnumValue<WebhookResourceEvent>>> GetResourceEventsAsync(WebhookResourceType resourceName, CancellationToken cancellationToken = default) => GetResourceEventsAsync(resourceName.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name), cancellationToken);

        public Task<List<StringEnumValue<WebhookResourceEvent>>> GetResourceEventsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceName, nameof(resourceName));

            return GetAsync<List<StringEnumValue<WebhookResourceEvent>>>($"resources/{resourceName}/events", null, nameof(GetResourceEventsAsync), resourceName, cancellationToken);
        }

        public Task<string> GetResourceEventsRawAsync(string resourceName, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceName, nameof(resourceName));

            return GetRawAsync($"resources/{resourceName}/events", queryString, nameof(GetResourceEventsRawAsync), resourceName, cancellationToken);
        }

        public Task<WebhookSubscription> GetSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            return GetDirtyAsync<WebhookSubscription>($"subscriptions/{subscriptionId}", null, nameof(GetSubscriptionAsync), subscriptionId, cancellationToken);
        }

        public Task<string> GetSubscriptionRawAsync(string subscriptionId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            return GetRawAsync($"subscriptions/{subscriptionId}", queryString, nameof(GetSubscriptionRawAsync), subscriptionId, cancellationToken);
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

        public Task<string> GetSubscriptionsRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync("subscriptions", queryString, nameof(GetSubscriptionsRawAsync), null, cancellationToken);

        public Task<string> CreateSubscriptionAsync(WebhookSubscription subscription, CancellationToken cancellationToken = default) => CreateSubscriptionAsync(subscription, false, cancellationToken);

        private Task<string> CreateSubscriptionAsync(WebhookSubscription subscription, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(subscription, nameof(subscription));
            Preconditions.NullOrEmpty(subscription.SubscriptionId, $"{nameof(subscription)}.{nameof(subscription.SubscriptionId)}");

            return PostPopulateDirtyAsync("subscriptions", nameof(CreateSubscriptionAsync), subscription, populate, cancellationToken);
        }

        public Task<string> CreateSubscriptionRawAsync(string subscription, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(subscription, nameof(subscription));

            return PostAsync("subscriptions", queryString, new JsonStringContent(subscription), nameof(CreateSubscriptionRawAsync), null, cancellationToken, ReadLocationFunc);
        }

        public Task UpdateSubscriptionAsync(WebhookSubscription subscription, CancellationToken cancellationToken = default) => UpdateSubscriptionAsync(subscription, false, cancellationToken);

        private Task UpdateSubscriptionAsync(WebhookSubscription subscription, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(subscription, nameof(subscription));
            Preconditions.NotNullOrEmpty(subscription.SubscriptionId, $"{nameof(subscription)}.{nameof(subscription.SubscriptionId)}");

            return PutPopulateDirtyAsync($"subscriptions/{subscription.SubscriptionId}", JsonStreamContent.Create(subscription), nameof(UpdateSubscriptionAsync), subscription.SubscriptionId, subscription, populate, true, cancellationToken);
        }

        public Task<string> UpdateSubscriptionRawAsync(string subscriptionId, string subscription, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Preconditions.NotNullOrEmpty(subscription, nameof(subscription));

            return PutRawAsync($"subscriptions/{subscriptionId}", queryString, new JsonStringContent(subscription), nameof(UpdateSubscriptionRawAsync), null, cancellationToken);
        }

        public Task<bool> DeleteSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            return DeleteAsync($"subscriptions/{subscriptionId}", null, cancellationToken);
        }
    }
}