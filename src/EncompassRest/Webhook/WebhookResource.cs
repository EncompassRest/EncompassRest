using System.Collections.Generic;

namespace EncompassRest.Webhook
{
    public sealed class WebhookResource : ExtensibleObject
    {
        public string Description { get; set; }

        public List<StringEnumValue<WebhookResourceEvent>> Events { get; set; }

        public StringEnumValue<WebhookResourceType> Name { get; set; }

        public StringEnumValue<WebhookResourceStatus> Status { get; set; }
    }
}