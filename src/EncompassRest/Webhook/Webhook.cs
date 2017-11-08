using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

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
                    throw await RestException.CreateAsync(nameof(GetResourcesAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<List<string>> GetResourceEventsAsync(string resourceName) => GetResourceEventsAsync(resourceName, CancellationToken.None);

        public Task<List<string>> GetResourceEventsAsync(string resourceName, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(resourceName, nameof(resourceName));

            return GetResourceEventsInternalAsync(resourceName, cancellationToken, response => response.Content.ReadAsAsync<List<string>>());
        }

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
                    throw await RestException.CreateAsync(nameof(GetResourcesAsync), response).ConfigureAwait(false);
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
                    throw await RestException.CreateAsync(nameof(GetSubscriptionAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<List<WebhookSubscription>> GetSubscriptionsAsync() => GetSubscriptionsAsync(null, null, CancellationToken.None);

        public Task<List<WebhookSubscription>> GetSubscriptionsAsync(CancellationToken cancellationToken) => GetSubscriptionsAsync(null, null, cancellationToken);

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
                    throw await RestException.CreateAsync(nameof(GetSubscriptionsAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<string> CreateSubscriptionAsync(WebhookSubscription subscription) => CreateSubscriptionAsync(subscription, CancellationToken.None);

        public Task<string> CreateSubscriptionAsync(WebhookSubscription subscription, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(subscription, nameof(subscription));

            return CreateSubscriptionInternalAsync(JsonStreamContent.Create(subscription), cancellationToken, () =>
            {
                subscription.Dirty = false;
            });
        }

        public Task<string> CreateSubscriptionRawAsync(string subscription) => CreateSubscriptionRawAsync(subscription, CancellationToken.None);

        public Task<string> CreateSubscriptionRawAsync(string subscription, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(subscription, nameof(subscription));

            return CreateSubscriptionInternalAsync(new JsonStringContent(subscription), cancellationToken);
        }

        private async Task<string> CreateSubscriptionInternalAsync(HttpContent content, CancellationToken cancellationToken, Action action = null)
        {
            using (var response = await Client.HttpClient.PostAsync($"{s_apiPath}/subscriptions", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(CreateSubscriptionAsync), response).ConfigureAwait(false);
                }

                action?.Invoke();
                return Path.GetFileName(response.Headers.Location.OriginalString);
            }
        }

        public Task UpdateSubscriptionAsync(WebhookSubscription subscription) => UpdateSubscriptionAsync(subscription, CancellationToken.None);

        public Task UpdateSubscriptionAsync(WebhookSubscription subscription, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(subscription, nameof(subscription));
            Preconditions.NotNullOrEmpty(subscription.SubscriptionId, $"{nameof(subscription)}.{nameof(subscription.SubscriptionId)}");

            return UpdateSubscriptionInternalAsync(subscription.SubscriptionId, JsonStreamContent.Create(subscription), cancellationToken, () =>
            {
                subscription.Dirty = false;
            });
        }

        public Task UpdateSubscriptionRawAsync(string subscriptionId, string subscription) => UpdateSubscriptionRawAsync(subscriptionId, subscription, CancellationToken.None);

        public Task UpdateSubscriptionRawAsync(string subscriptionId, string subscription, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Preconditions.NotNullOrEmpty(subscription, nameof(subscription));

            return UpdateSubscriptionInternalAsync(subscriptionId, new JsonStringContent(subscription), cancellationToken);
        }

        private async Task UpdateSubscriptionInternalAsync(string subscriptionId, HttpContent content, CancellationToken cancellationToken, Action action = null)
        {
            using (var response = await Client.HttpClient.PutAsync($"{s_apiPath}/subscriptions/{subscriptionId}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(UpdateSubscriptionAsync), response).ConfigureAwait(false);
                }

                action?.Invoke();
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