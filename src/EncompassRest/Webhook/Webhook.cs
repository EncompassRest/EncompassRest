using System;
using System.Collections.Generic;
using System.IO;
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

        public Task<WebhookSubscription> GetSubscriptionAsync(string subscriptionId) => GetSubscriptionAsync(subscriptionId, CancellationToken.None);

        public Task<WebhookSubscription> GetSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            return GetSubscriptionInternalAsync(subscriptionId, cancellationToken, response => response.Content.ReadAsAsync<WebhookSubscription>());
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

        public Task<List<WebhookSubscription>> GetSubscriptionsAsync() => GetSubscriptionsAsync(CancellationToken.None);

        public Task<List<WebhookSubscription>> GetSubscriptionsAsync(CancellationToken cancellationToken) => GetSubscriptionsInternalAsync(cancellationToken, response => response.Content.ReadAsAsync<List<WebhookSubscription>>());

        public Task<string> GetSubscriptionsRawAsync() => GetSubscriptionsRawAsync(CancellationToken.None);

        public Task<string> GetSubscriptionsRawAsync(CancellationToken cancellationToken) => GetSubscriptionsInternalAsync(cancellationToken, response => response.Content.ReadAsStringAsync());

        private async Task<T> GetSubscriptionsInternalAsync<T>(CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{s_apiPath}/subscriptions", cancellationToken).ConfigureAwait(false))
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

            return CreateSubscriptionInternalAsync(JsonStreamContent.Create(subscription), cancellationToken);
        }

        public Task<string> CreateSubscriptionRawAsync(string subscription) => CreateSubscriptionRawAsync(subscription, CancellationToken.None);

        public Task<string> CreateSubscriptionRawAsync(string subscription, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(subscription, nameof(subscription));

            return CreateSubscriptionInternalAsync(new JsonStringContent(subscription), cancellationToken);
        }

        private async Task<string> CreateSubscriptionInternalAsync(HttpContent content, CancellationToken cancellationToken)
        {
            using (var response = await Client.HttpClient.PostAsync($"{s_apiPath}/subscriptions", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(CreateSubscriptionAsync), response).ConfigureAwait(false);
                }

                return Path.GetFileName(response.Headers.Location.OriginalString);
            }
        }

        public Task UpdateSubscriptionAsync(string subscriptionId, WebhookSubscription subscription) => UpdateSubscriptionAsync(subscriptionId, subscription, CancellationToken.None);

        public Task UpdateSubscriptionAsync(string subscriptionId, WebhookSubscription subscription, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Preconditions.NotNull(subscription, nameof(subscription));

            return UpdateSubscriptionInternalAsync(subscriptionId, JsonStreamContent.Create(subscription), cancellationToken);
        }

        public Task UpdateSubscriptionRawAsync(string subscriptionId, string subscription) => UpdateSubscriptionRawAsync(subscriptionId, subscription, CancellationToken.None);

        public Task UpdateSubscriptionRawAsync(string subscriptionId, string subscription, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Preconditions.NotNullOrEmpty(subscription, nameof(subscription));

            return UpdateSubscriptionInternalAsync(subscriptionId, new JsonStringContent(subscription), cancellationToken);
        }

        private async Task UpdateSubscriptionInternalAsync(string subscriptionId, HttpContent content, CancellationToken cancellationToken)
        {
            using (var response = await Client.HttpClient.PutAsync($"{s_apiPath}/subscriptions/{subscriptionId}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(UpdateSubscriptionAsync), response).ConfigureAwait(false);
                }
            }
        }

        public Task DeleteSubscriptionAsync(string subscriptionId) => DeleteSubscriptionAsync(subscriptionId, CancellationToken.None);

        public Task DeleteSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            return DeleteSubscriptionInternalAsync(subscriptionId, cancellationToken);
        }

        private async Task DeleteSubscriptionInternalAsync(string subscriptionId, CancellationToken cancellationToken)
        {
            using (var response = await Client.HttpClient.DeleteAsync($"{s_apiPath}/subscriptions/{subscriptionId}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(DeleteSubscriptionAsync), response).ConfigureAwait(false);
                }
            }
        }
    }
}