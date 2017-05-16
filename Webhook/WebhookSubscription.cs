using Newtonsoft.Json;

namespace EncompassRest.Webhook
{
    [JsonObject(ItemRequired = Required.Always)]
    public sealed class WebhookSubscription
    {
        public string Endpoint { get; set; }

        public string ObjectUrn { get; set; }

        public string SubscriptionId { get; set; }
    }
}