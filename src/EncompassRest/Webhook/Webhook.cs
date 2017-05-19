using System.Collections.Generic;
using System.IO;
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

        public async Task<WebhookSubscription> GetSubscriptionAsync(string subscriptionId)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/{subscriptionId}").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetSubscriptionAsync), response).ConfigureAwait(false);
                }

                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonHelper.FromJson<WebhookSubscription>(json);
            }
        }

        public async Task<List<WebhookSubscription>> GetSubscriptionsAsync()
        {
            using (var response = await Client.HttpClient.GetAsync(_apiPath).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetSubscriptionAsync), response).ConfigureAwait(false);
                }

                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonHelper.FromJson<List<WebhookSubscription>>(json);
            }
        }

        public async Task<string> CreateSubscriptionAsync(string endpoint)
        {
            Preconditions.NotNullOrEmpty(endpoint, nameof(endpoint));

            using (var response = await Client.HttpClient.PostAsync(_apiPath, JsonContent.Create(new Subscription { Endpoint = endpoint })).ConfigureAwait(false))
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

            using (var response = await Client.HttpClient.PutAsync($"{_apiPath}/{subscriptionId}", JsonContent.Create(new Subscription { Endpoint = newEndpoint })).ConfigureAwait(false))
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