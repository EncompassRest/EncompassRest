using System.Collections.Generic;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Webhook
{
    public sealed class WebhookSubscription : IDirty
    {
        [JsonRequired]
        public string Endpoint { get; }
        private DirtyValue<string> _objectUrn;
        public string ObjectUrn { get { return _objectUrn; } set { _objectUrn = value; } }
        private DirtyValue<string> _subscriptionId;
        public string SubscriptionId { get { return _subscriptionId; } set { _subscriptionId = value; } }
        private DirtyValue<string> _resource;
        public string Resource { get { return _resource; } set { _resource = value; } }
        private DirtyValue<string> _clientId;
        public string ClientId { get { return _clientId; } set { _clientId = value; } }
        private DirtyValue<string> _instanceId;
        public string InstanceId { get { return _instanceId; } set { _instanceId = value; } }
        private DirtyList<string> _events;
        public IList<string> Events { get { return _events ?? (_events = new DirtyList<string>()); } set { _events = new DirtyList<string>(value); } }
        private ExtensionDataObject _extensionDataInternal;
        [JsonExtensionData]
        private ExtensionDataObject ExtensionDataInternal { get { return _extensionDataInternal ?? (_extensionDataInternal = new ExtensionDataObject()); } set { _extensionDataInternal = value; } }
        [JsonIgnore]
        public IDictionary<string, object> ExtensionData { get { return ExtensionDataInternal.InternalDictionary; } set { _extensionDataInternal = new ExtensionDataObject(value); } }
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
                    || _extensionDataInternal?.Dirty == true;
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
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }

        public WebhookSubscription(string endpoint)
        {
            Preconditions.NotNullOrEmpty(endpoint, nameof(endpoint));

            Endpoint = endpoint;
        }
    }
}