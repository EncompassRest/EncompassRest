using System.Collections.Generic;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Webhook
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed class WebhookSubscription : IDirty
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
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty;
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _objectUrn.Dirty
                    || _subscriptionId.Dirty
                    || _resource.Dirty
                    || _clientId.Dirty
                    || _instanceId.Dirty
                    || _events?.Dirty == true
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _objectUrn.Dirty = value;
                _subscriptionId.Dirty = value;
                _resource.Dirty = value;
                _clientId.Dirty = value;
                _instanceId.Dirty = value;
                if (_events != null) _events.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }

        public WebhookSubscription(string endpoint)
        {
            Preconditions.NotNullOrEmpty(endpoint, nameof(endpoint));

            Endpoint = endpoint;
        }
    }
}