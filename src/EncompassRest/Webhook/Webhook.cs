using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Webhook
{
    public sealed class Webhook
    {
        private const string _apiPath = "webhook/v1";

        public EncompassRestClient Client { get; }

        internal Webhook(EncompassRestClient client)
        {
            Client = client;
        }

        public Task<List<WebhookResource>> GetResourcesAsync() => GetResourcesInternalAsync(response => response.Content.ReadAsAsync<List<WebhookResource>>());

        public Task<string> GetResourcesRawAsync() => GetResourcesInternalAsync(response => response.Content.ReadAsStringAsync());

        public async Task<T> GetResourcesInternalAsync<T>(Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/resources").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetResourcesAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<WebhookSubscription> GetSubscriptionAsync(string subscriptionId)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            return GetSubscriptionInternalAsync(subscriptionId, response => response.Content.ReadAsAsync<WebhookSubscription>());
        }

        public Task<string> GetSubscriptionRawAsync(string subscriptionId)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            return GetSubscriptionInternalAsync(subscriptionId, response => response.Content.ReadAsStringAsync());
        }

        private async Task<T> GetSubscriptionInternalAsync<T>(string subscriptionId, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/subscriptions/{subscriptionId}").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetSubscriptionAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<List<WebhookSubscription>> GetSubscriptionsAsync() => GetSubscriptionsInternalAsync(response => response.Content.ReadAsAsync<List<WebhookSubscription>>());

        public Task<string> GetSubscriptionsRawAsync() => GetSubscriptionsInternalAsync(response => response.Content.ReadAsStringAsync());

        private async Task<T> GetSubscriptionsInternalAsync<T>(Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/subscriptions").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetSubscriptionsAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<string> CreateSubscriptionAsync(WebhookSubscription subscription)
        {
            Preconditions.NotNull(subscription, nameof(subscription));

            return CreateSubscriptionInternalAsync(JsonStreamContent.Create(subscription));
        }

        public Task<string> CreateSubscriptionRawAsync(string subscription)
        {
            Preconditions.NotNullOrEmpty(subscription, nameof(subscription));

            return CreateSubscriptionInternalAsync(new JsonContent(subscription));
        }

        private async Task<string> CreateSubscriptionInternalAsync(HttpContent content)
        {
            using (var response = await Client.HttpClient.PostAsync($"{_apiPath}/subscriptions", content).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(CreateSubscriptionAsync), response).ConfigureAwait(false);
                }

                return Path.GetFileName(response.Headers.Location.OriginalString);
            }
        }

        public Task UpdateSubscriptionAsync(string subscriptionId, WebhookSubscription subscription)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Preconditions.NotNull(subscription, nameof(subscription));

            return UpdateSubscriptionInternalAsync(subscriptionId, JsonStreamContent.Create(subscription));
        }

        public Task UpdateSubscriptionRawAsync(string subscriptionId, string subscription)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Preconditions.NotNullOrEmpty(subscription, nameof(subscription));

            return UpdateSubscriptionInternalAsync(subscriptionId, new JsonContent(subscription));
        }

        private async Task UpdateSubscriptionInternalAsync(string subscriptionId, HttpContent content)
        {
            using (var response = await Client.HttpClient.PutAsync($"{_apiPath}/subscriptions/{subscriptionId}", content).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(UpdateSubscriptionAsync), response).ConfigureAwait(false);
                }
            }
        }

        public Task DeleteSubscriptionAsync(string subscriptionId)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            return DeleteSubscriptionInternalAsync(subscriptionId);
        }

        private async Task DeleteSubscriptionInternalAsync(string subscriptionId)
        {
            using (var response = await Client.HttpClient.DeleteAsync($"{_apiPath}/subscriptions/{subscriptionId}").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(DeleteSubscriptionAsync), response).ConfigureAwait(false);
                }
            }
        }
    }
}