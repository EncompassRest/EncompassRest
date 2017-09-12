using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassRest.Webhook
{
    public sealed class WebhookSubscription
    {
        [JsonRequired]
        public string Endpoint { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectUrn { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Resource { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Events { get; set; }
    }
}