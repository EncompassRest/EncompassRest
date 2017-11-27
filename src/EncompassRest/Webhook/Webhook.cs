using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Webhook
{
    public sealed class Webhook
    {
        private const string s_apiPath = "webhook/v1";

        public EncompassRestClient Client { get; }

        internal Webhook(EncompassRestClient client)
        {
            Client = client;
        }

        public Task<List<WebhookResource>> GetResourcesAsync() => GetResourcesAsync(CancellationToken.None);

        public Task<List<WebhookResource>> GetResourcesAsync(CancellationToken cancellationToken) => GetResourcesInternalAsync(cancellationToken, response => response.Content.ReadAsAsync<List<WebhookResource>>());

        public Task<string> GetResourcesRawAsync() => GetResourcesRawAsync(CancellationToken.None);

        public Task<string> GetResourcesRawAsync(CancellationToken cancellationToken) => GetResourcesInternalAsync(cancellationToken, response => response.Content.ReadAsStringAsync());

        private async Task<T> GetResourcesInternalAsync<T>(CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{s_apiPath}/resources", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await EncompassRestException.CreateAsync(nameof(GetResourcesAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<List<StringEnumValue<WebhookResourceEvent>>> GetResourceEventsAsync(WebhookResourceType resourceName) => GetResourceEventsAsync(resourceName, CancellationToken.None);

        public Task<List<StringEnumValue<WebhookResourceEvent>>> GetResourceEventsAsync(WebhookResourceType resourceName, CancellationToken cancellationToken) => GetResourceEventsAsync(resourceName.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name), cancellationToken);

        public Task<List<StringEnumValue<WebhookResourceEvent>>> GetResourceEventsAsync(string resourceName) => GetResourceEventsAsync(resourceName, CancellationToken.None);

        public Task<List<StringEnumValue<WebhookResourceEvent>>> GetResourceEventsAsync(string resourceName, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(resourceName, nameof(resourceName));

            return GetResourceEventsInternalAsync(resourceName, cancellationToken, response => response.Content.ReadAsAsync<List<StringEnumValue<WebhookResourceEvent>>>());
        }

        public Task<string> GetResourceEventsRawAsync(WebhookResourceType resourceName) => GetResourceEventsRawAsync(resourceName, CancellationToken.None);

        public Task<string> GetResourceEventsRawAsync(WebhookResourceType resourceName, CancellationToken cancellationToken) => GetResourceEventsRawAsync(resourceName.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name), cancellationToken);

        public Task<string> GetResourceEventsRawAsync(string resourceName) => GetResourceEventsRawAsync(resourceName, CancellationToken.None);

        public Task<string> GetResourceEventsRawAsync(string resourceName, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(resourceName, nameof(resourceName));

            return GetResourceEventsInternalAsync(resourceName, cancellationToken, response => response.Content.ReadAsStringAsync());
        }

        private async Task<T> GetResourceEventsInternalAsync<T>(string resourceName, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{s_apiPath}/resources/{resourceName}/events", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await EncompassRestException.CreateAsync(nameof(GetResourcesAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<WebhookSubscription> GetSubscriptionAsync(string subscriptionId) => GetSubscriptionAsync(subscriptionId, CancellationToken.None);

        public Task<WebhookSubscription> GetSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            return GetSubscriptionInternalAsync(subscriptionId, cancellationToken, async response =>
            {
                var subscription = await response.Content.ReadAsAsync<WebhookSubscription>().ConfigureAwait(false);
                subscription.Dirty = false;
                return subscription;
            });
        }

        public Task<string> GetSubscriptionRawAsync(string subscriptionId) => GetSubscriptionRawAsync(subscriptionId, CancellationToken.None);

        public Task<string> GetSubscriptionRawAsync(string subscriptionId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            return GetSubscriptionInternalAsync(subscriptionId, cancellationToken, response => response.Content.ReadAsStringAsync());
        }

        private async Task<T> GetSubscriptionInternalAsync<T>(string subscriptionId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{s_apiPath}/subscriptions/{subscriptionId}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await EncompassRestException.CreateAsync(nameof(GetSubscriptionAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<List<WebhookSubscription>> GetSubscriptionsAsync() => GetSubscriptionsAsync((IEnumerable<string>)null, null, CancellationToken.None);

        public Task<List<WebhookSubscription>> GetSubscriptionsAsync(CancellationToken cancellationToken) => GetSubscriptionsAsync((IEnumerable<string>)null, null, cancellationToken);

        public Task<List<WebhookSubscription>> GetSubscriptionsAsync(IEnumerable<WebhookResourceType> resources, IEnumerable<WebhookResourceEvent> events) => GetSubscriptionsAsync(resources, events, CancellationToken.None);

        public Task<List<WebhookSubscription>> GetSubscriptionsAsync(IEnumerable<WebhookResourceType> resources, IEnumerable<WebhookResourceEvent> events, CancellationToken cancellationToken) => GetSubscriptionsAsync(resources?.Select(r => r.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)), events?.Select(e => e.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)), cancellationToken);

        public Task<List<WebhookSubscription>> GetSubscriptionsAsync(IEnumerable<string> resources, IEnumerable<string> events) => GetSubscriptionsAsync(resources, events, CancellationToken.None);

        public Task<List<WebhookSubscription>> GetSubscriptionsAsync(IEnumerable<string> resources, IEnumerable<string> events, CancellationToken cancellationToken)
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

            return GetSubscriptionsInternalAsync(queryParameters.ToString(), cancellationToken, async response =>
            {
                var subscriptions = await response.Content.ReadAsAsync<List<WebhookSubscription>>().ConfigureAwait(false);
                foreach (var subscription in subscriptions)
                {
                    subscription.Dirty = false;
                }
                return subscriptions;
            });
        }

        public Task<string> GetSubscriptionsRawAsync() => GetSubscriptionsRawAsync(null, CancellationToken.None);

        public Task<string> GetSubscriptionsRawAsync(CancellationToken cancellationToken) => GetSubscriptionsRawAsync(null, cancellationToken);

        public Task<string> GetSubscriptionsRawAsync(IEnumerable<WebhookResourceType> resources, IEnumerable<WebhookResourceEvent> events) => GetSubscriptionsRawAsync(resources, events, CancellationToken.None);

        public Task<string> GetSubscriptionsRawAsync(IEnumerable<WebhookResourceType> resources, IEnumerable<WebhookResourceEvent> events, CancellationToken cancellationToken) => GetSubscriptionsRawAsync(resources?.Select(r => r.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)), events?.Select(e => e.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)), cancellationToken);

        public Task<string> GetSubscriptionsRawAsync(IEnumerable<string> resources, IEnumerable<string> events) => GetSubscriptionsRawAsync(resources, events, CancellationToken.None);

        public Task<string> GetSubscriptionsRawAsync(IEnumerable<string> resources, IEnumerable<string> events, CancellationToken cancellationToken)
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

        public Task<string> GetSubscriptionsRawAsync(string queryString) => GetSubscriptionsRawAsync(queryString, CancellationToken.None);

        public Task<string> GetSubscriptionsRawAsync(string queryString, CancellationToken cancellationToken) => GetSubscriptionsInternalAsync(queryString, cancellationToken, response => response.Content.ReadAsStringAsync());

        private async Task<T> GetSubscriptionsInternalAsync<T>(string queryString, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{s_apiPath}/subscriptions{(!string.IsNullOrEmpty(queryString) && queryString[0] != '?' ? "?" : string.Empty)}{queryString}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await EncompassRestException.CreateAsync(nameof(GetSubscriptionsAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<string> CreateSubscriptionAsync(WebhookSubscription subscription) => CreateSubscriptionAsync(subscription, false, CancellationToken.None);

        public Task<string> CreateSubscriptionAsync(WebhookSubscription subscription, CancellationToken cancellationToken) => CreateSubscriptionAsync(subscription, false, cancellationToken);

        private Task<string> CreateSubscriptionAsync(WebhookSubscription subscription, bool populate) => CreateSubscriptionAsync(subscription, populate, CancellationToken.None);

        private Task<string> CreateSubscriptionAsync(WebhookSubscription subscription, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(subscription, nameof(subscription));

            return CreateSubscriptionInternalAsync(JsonStreamContent.Create(subscription), populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, cancellationToken, async response =>
            {
                if (populate)
                {
                    await response.Content.PopulateAsync(subscription).ConfigureAwait(false);
                }
                subscription.Dirty = false;
                return Path.GetFileName(response.Headers.Location.OriginalString);
            });
        }

        public Task<string> CreateSubscriptionRawAsync(string subscription) => CreateSubscriptionRawAsync(subscription, null, CancellationToken.None);

        public Task<string> CreateSubscriptionRawAsync(string subscription, CancellationToken cancellationToken) => CreateSubscriptionRawAsync(subscription, null, cancellationToken);

        private Task<string> CreateSubscriptionRawAsync(string subscription, string queryString) => CreateSubscriptionRawAsync(subscription, queryString, CancellationToken.None);

        private Task<string> CreateSubscriptionRawAsync(string subscription, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(subscription, nameof(subscription));

            return CreateSubscriptionInternalAsync(new JsonStringContent(subscription), queryString, cancellationToken, response =>
            {
                // Do not retrieve json as result is not null or empty with an empty queryString
                return Task.FromResult(Path.GetFileName(response.Headers.Location.OriginalString));
            });
        }

        private async Task<string> CreateSubscriptionInternalAsync(HttpContent content, string queryString, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<string>> func)
        {
            using (var response = await Client.HttpClient.PostAsync($"{s_apiPath}/subscriptions{(!string.IsNullOrEmpty(queryString) && queryString[0] != '?' ? "?" : string.Empty)}{queryString}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await EncompassRestException.CreateAsync(nameof(CreateSubscriptionAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task UpdateSubscriptionAsync(WebhookSubscription subscription) => UpdateSubscriptionAsync(subscription, false, CancellationToken.None);

        public Task UpdateSubscriptionAsync(WebhookSubscription subscription, CancellationToken cancellationToken) => UpdateSubscriptionAsync(subscription, false, cancellationToken);

        private Task UpdateSubscriptionAsync(WebhookSubscription subscription, bool populate) => UpdateSubscriptionAsync(subscription, populate, CancellationToken.None);

        private Task UpdateSubscriptionAsync(WebhookSubscription subscription, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(subscription, nameof(subscription));
            Preconditions.NotNullOrEmpty(subscription.SubscriptionId, $"{nameof(subscription)}.{nameof(subscription.SubscriptionId)}");

            return UpdateSubscriptionInternalAsync(subscription.SubscriptionId, JsonStreamContent.Create(subscription), populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, cancellationToken, async response =>
            {
                if (populate)
                {
                    await response.Content.PopulateAsync(subscription).ConfigureAwait(false);
                }
                subscription.Dirty = false;
                return string.Empty;
            });
        }

        public Task<string> UpdateSubscriptionRawAsync(string subscriptionId, string subscription) => UpdateSubscriptionRawAsync(subscriptionId, subscription, null, CancellationToken.None);

        public Task<string> UpdateSubscriptionRawAsync(string subscriptionId, string subscription, CancellationToken cancellationToken) => UpdateSubscriptionRawAsync(subscriptionId, subscription, null, cancellationToken);

        private Task<string> UpdateSubscriptionRawAsync(string subscriptionId, string subscription, string queryString) => UpdateSubscriptionRawAsync(subscriptionId, subscription, queryString, CancellationToken.None);

        private Task<string> UpdateSubscriptionRawAsync(string subscriptionId, string subscription, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Preconditions.NotNullOrEmpty(subscription, nameof(subscription));

            return UpdateSubscriptionInternalAsync(subscriptionId, new JsonStringContent(subscription), queryString, cancellationToken, response => response.Content.ReadAsStringAsync());
        }

        private async Task<string> UpdateSubscriptionInternalAsync(string subscriptionId, HttpContent content, string queryString, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<string>> func)
        {
            using (var response = await Client.HttpClient.PutAsync($"{s_apiPath}/subscriptions/{subscriptionId}{(!string.IsNullOrEmpty(queryString) && queryString[0] != '?' ? "?" : string.Empty)}{queryString}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await EncompassRestException.CreateAsync(nameof(UpdateSubscriptionAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<bool> DeleteSubscriptionAsync(string subscriptionId) => DeleteSubscriptionAsync(subscriptionId, CancellationToken.None);

        public async Task<bool> DeleteSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using (var response = await Client.HttpClient.DeleteAsync($"{s_apiPath}/subscriptions/{subscriptionId}", cancellationToken).ConfigureAwait(false))
            {
                return response.IsSuccessStatusCode;
            }
        }
    }
}