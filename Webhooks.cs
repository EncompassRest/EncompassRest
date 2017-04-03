using EncompassREST.Exceptions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST
{
    public class Webhooks
    {
        private string API_PATH = "webhook/v1/subscriptions";
        private Session _Session;

        public Webhooks(Session Session)
        {
            _Session = Session;
        }

        public Session Session
        {
            get { return _Session; }
        }

        public async Task<string> PutSubscriptionAsync(string newEndpoint)
        {

            string exitingEndpointJSONstring = await GetSubscriptionAsync();
            var existingEndpoint = JToken.Parse(exitingEndpointJSONstring);
            string subscriptionID = existingEndpoint["subscriptionId"].ToString();
            return await PutSubscriptionAsync(subscriptionID, newEndpoint);
        }

        public async Task<string> PutSubscriptionAsync(string subscriptionID, string newEndpoint)
        {
            //string api = API_PATH + "/" + subscriptionID;
        
            string newEndpointJSONstring = "{\"endpoint\": \"" + newEndpoint + "\"}";

            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Put, string.Format("{0}/{1}", API_PATH, subscriptionID));
            message.Content = new StringContent(newEndpointJSONstring);
            var response = await _Session.RESTClient.SendAsync(message);
                //await _Session.RESTClient.PutAsync(api, new StringContent(newEndpointJSONstring, Encoding.Unicode, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                return subscriptionID;
            }
            else
            {
                throw new RESTException("PutSubscriptionAsync", response);
            }
        }



        public async Task<string> SubscribeAsync(string endpoint)
        {
            string jsonData = "{\"endpoint\": \"" + endpoint + "\"}";

            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, API_PATH);
            message.Content = new StringContent(jsonData);

            var response = await _Session.RESTClient.SendAsync(message);
                //await _Session.RESTClient.PostAsync(API_PATH, new StringContent(jsonData, Encoding.UTF8, "application/json"));
            if (response.StatusCode == HttpStatusCode.Created)
            {
                return response.Headers.Location.ToString().Split("/".ToCharArray()).Last();
            }
            else
            {
                throw new RESTException("SubscribeAsync", response);
            }
        }


        public async Task<string> GetSubscriptionAsync()
        {
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, API_PATH);

            var response = await _Session.RESTClient.SendAsync(message);
            //await _Session.RESTClient.GetAsync(API_PATH);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new RESTException("GetSubscriptionAsync", response);
            }
        }

        public async Task CancelSubscriptionAsync(string SubscriptionID)
        {
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Delete, string.Format("{0}/{1}",API_PATH,SubscriptionID));
            var response = await _Session.RESTClient.SendAsync(message);
                //await _Session.RESTClient.DeleteAsync(API_PATH + "/" + SubscriptionID);

            if (response.StatusCode == HttpStatusCode.NoContent)
                return;

            throw new RESTException("CancelSubscription", response);
        }
    }
}
