using System.Collections.Generic;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Webhook
{
    public sealed class WebhookSubscription : ExtensibleObject, IIdentifiable
    {
        [JsonRequired]
        public string Endpoint { get; }
        private DirtyValue<string> _objectUrn;
        public string ObjectUrn { get => _objectUrn; set => _objectUrn = value; }
        private DirtyValue<string> _subscriptionId;
        public string SubscriptionId { get => _subscriptionId; set => _subscriptionId = value; }
        private DirtyValue<StringEnumValue<WebhookResourceType>> _resource;
        public StringEnumValue<WebhookResourceType> Resource { get => _resource; set => _resource = value; }
        private DirtyValue<string> _clientId;
        public string ClientId { get => _clientId; set => _clientId = value; }
        private DirtyValue<string> _instanceId;
        public string InstanceId { get => _instanceId; set => _instanceId = value; }
        private DirtyList<StringEnumValue<WebhookResourceEvent>> _events;
        public IList<StringEnumValue<WebhookResourceEvent>> Events { get => _events ?? (_events = new DirtyList<StringEnumValue<WebhookResourceEvent>>()); set => _events = new DirtyList<StringEnumValue<WebhookResourceEvent>>(value); }
        [IdPropertyName(nameof(SubscriptionId))]
        string IIdentifiable.Id { get => SubscriptionId; set => SubscriptionId = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _objectUrn.Dirty
                    || _subscriptionId.Dirty
                    || _resource.Dirty
                    || _clientId.Dirty
                    || _instanceId.Dirty
                    || _events?.Dirty == true;
            }
            set
            {
                _objectUrn.Dirty = value;
                _subscriptionId.Dirty = value;
                _resource.Dirty = value;
                _clientId.Dirty = value;
                _instanceId.Dirty = value;
                if (_events != null) _events.Dirty = value;
            }
        }

        public WebhookSubscription(string endpoint)
        {
            Preconditions.NotNullOrEmpty(endpoint, nameof(endpoint));

            Endpoint = endpoint;
        }
    }
}