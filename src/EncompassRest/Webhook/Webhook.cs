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
        private const string _apiPath = "webhook/v1/subscriptions";

        public EncompassRestClient Client { get; }

        internal Webhook(EncompassRestClient client)
        {
            Client = client;
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
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/{subscriptionId}").ConfigureAwait(false))
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
            using (var response = await Client.HttpClient.GetAsync(_apiPath).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetSubscriptionAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public async Task<string> CreateSubscriptionAsync(string endpoint)
        {
            Preconditions.NotNullOrEmpty(endpoint, nameof(endpoint));

            using (var response = await Client.HttpClient.PostAsync(_apiPath, JsonStreamContent.Create(new Subscription { Endpoint = endpoint })).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(CreateSubscriptionAsync), response).ConfigureAwait(false);
                }

                return Path.GetFileName(response.Headers.Location.OriginalString);
            }
        }

        public async Task UpdateSubscriptionAsync(string subscriptionId, string newEndpoint)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Preconditions.NotNullOrEmpty(newEndpoint, nameof(newEndpoint));

            using (var response = await Client.HttpClient.PutAsync($"{_apiPath}/{subscriptionId}", JsonStreamContent.Create(new Subscription { Endpoint = newEndpoint })).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(UpdateSubscriptionAsync), response).ConfigureAwait(false);
                }
            }
        }

        public async Task DeleteSubscriptionAsync(string subscriptionId)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using (var response = await Client.HttpClient.DeleteAsync($"{_apiPath}/{subscriptionId}").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(DeleteSubscriptionAsync), response).ConfigureAwait(false);
                }
            }
        }

        private sealed class Subscription
        {
            public string Endpoint { get; set; }
        }
    }
}