using System.Collections.Generic;
using System.Threading.Tasks;
using EncompassRest.Exceptions;
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

            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/{subscriptionId}"))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new RestException(nameof(GetSubscriptionAsync), response);
                }

                var json = await response.Content.ReadAsStringAsync();
                return JsonHelper.FromJson<WebhookSubscription>(json);
            }
        }

        public async Task<List<WebhookSubscription>> GetSubscriptionsAsync()
        {
            using (var response = await Client.HttpClient.GetAsync(_apiPath))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new RestException(nameof(GetSubscriptionAsync), response);
                }

                var json = await response.Content.ReadAsStringAsync();
                return JsonHelper.FromJson<List<WebhookSubscription>>(json);
            }
        }

        public async Task<string> CreateSubscriptionAsync(string endpoint)
        {
            Preconditions.NotNullOrEmpty(endpoint, nameof(endpoint));

            using (var response = await Client.HttpClient.PostAsync(_apiPath, JsonContent.Create(new { Endpoint = endpoint })))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new RestException(nameof(CreateSubscriptionAsync), response);
                }

                var location = response.Headers.Location.OriginalString;
                return location.Substring(location.LastIndexOf('/') + 1);
            }
        }

        public async Task UpdateSubscriptionAsync(string subscriptionId, string newEndpoint)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Preconditions.NotNullOrEmpty(newEndpoint, nameof(newEndpoint));

            using (var response = await Client.HttpClient.PutAsync($"{_apiPath}/{subscriptionId}", JsonContent.Create(new { Endpoint = newEndpoint })))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new RestException(nameof(UpdateSubscriptionAsync), response);
                }
            }
        }

        public async Task DeleteSubscriptionAsync(string subscriptionId)
        {
            Preconditions.NotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using (var response = await Client.HttpClient.DeleteAsync($"{_apiPath}/{subscriptionId}"))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new RestException(nameof(DeleteSubscriptionAsync), response);
                }
            }
        }
    }
}