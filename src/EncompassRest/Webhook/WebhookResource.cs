using System.Collections.Generic;

namespace EncompassRest.Webhook
{
    public sealed class WebhookResource
    {
        public string Description { get; set; }

        public List<StringEnumValue<WebhookEvent>> Events { get; set; }

        public string Name { get; set; }

        public StringEnumValue<WebhookResourceStatus> Status { get; set; }
    }
}