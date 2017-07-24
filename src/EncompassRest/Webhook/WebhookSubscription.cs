using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassRest.Webhook
{
    [JsonObject(ItemRequired = Required.Always)]
    public sealed class WebhookSubscription
    {
        [JsonRequired]
        public string Endpoint { get; set; }

        public string ObjectUrn { get; set; }

        public string SubscriptionId { get; set; }

        public string Resource { get; set; }

        public string ClientId { get; set; }

        public string InstanceId { get; set; }

        public List<string> Events { get; set; }
    }
}