using System.Collections.Generic;

namespace EncompassRest.Webhook
{
    public sealed class WebhookResource
    {
        public string Description { get; set; }

        public List<StringEnumValue<WebhookResourceEvent>> Events { get; set; }

        public StringEnumValue<WebhookResourceType> Name { get; set; }

        public StringEnumValue<WebhookResourceStatus> Status { get; set; }

        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
    }
}