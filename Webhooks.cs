using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using EncompassREST.Exceptions;
using Newtonsoft.Json.Linq;

namespace EncompassREST
{
    public class Webhooks
    {
        private const string _apiPath = "webhook/v1/subscriptions";

        public Session Session { get; }

        public Webhooks(Session session)
        {
            Session = session;
        }

        public async Task<string> PutSubscriptionAsync(string newEndpoint)
        {
            string exitingEndpointJSONstring = await GetSubscriptionAsync();
            var existingEndpoint = JToken.Parse(exitingEndpointJSONstring);
            string subscriptionId = existingEndpoint["subscriptionId"].ToString();
            return await PutSubscriptionAsync(subscriptionId, newEndpoint);
        }

        public async Task<string> PutSubscriptionAsync(string subscriptionId, string newEndpoint)
        {
            //string api = API_PATH + "/" + subscriptionID;

            var newEndpointJSONstring = $"{{\"endpoint\": \"{newEndpoint}\"}}";

            var message = new HttpRequestMessage(HttpMethod.Put, $"{_apiPath}/{subscriptionId}")
            {
                Content = new StringContent(newEndpointJSONstring)
            };
            var response = await Session.RESTClient.SendAsync(message);
                //await _Session.RESTClient.PutAsync(api, new StringContent(newEndpointJSONstring, Encoding.Unicode, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                return subscriptionId;
            }
            else
            {
                throw new RESTException(nameof(PutSubscriptionAsync), response);
            }
        }

        public async Task<string> SubscribeAsync(string endpoint)
        {
            var jsonData = $"{{\"endpoint\": \"{endpoint}\"}}";

            var message = new HttpRequestMessage(HttpMethod.Post, _apiPath)
            {
                Content = new StringContent(jsonData)
            };
            var response = await Session.RESTClient.SendAsync(message);
                //await _Session.RESTClient.PostAsync(API_PATH, new StringContent(jsonData, Encoding.UTF8, "application/json"));
            if (response.StatusCode == HttpStatusCode.Created)
            {
                return response.Headers.Location.ToString().Split("/".ToCharArray()).Last();
            }
            else
            {
                throw new RESTException(nameof(SubscribeAsync), response);
            }
        }

        public async Task<string> GetSubscriptionAsync()
        {
            var message = new HttpRequestMessage(HttpMethod.Get, _apiPath);

            var response = await Session.RESTClient.SendAsync(message);
            //await _Session.RESTClient.GetAsync(API_PATH);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new RESTException(nameof(GetSubscriptionAsync), response);
            }
        }

        public async Task CancelSubscriptionAsync(string subscriptionId)
        {
            var message = new HttpRequestMessage(HttpMethod.Delete, $"{_apiPath}/{subscriptionId}");
            var response = await Session.RESTClient.SendAsync(message);
                //await _Session.RESTClient.DeleteAsync(API_PATH + "/" + SubscriptionID);

            if (response.StatusCode == HttpStatusCode.NoContent)
                return;

            throw new RESTException(nameof(CancelSubscriptionAsync), response);
        }
    }
}
