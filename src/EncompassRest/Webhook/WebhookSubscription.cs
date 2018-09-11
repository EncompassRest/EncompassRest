using System;
using System.Collections.Generic;
using System.Linq;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Webhook
{
    public sealed class WebhookSubscription : DirtyExtensibleObject, IIdentifiable
    {
        private string _endpoint;
        [JsonRequired]
        public string Endpoint { get => _endpoint; set => SetField(ref _endpoint, value); }
        private string _subscriptionId;
        public string SubscriptionId { get => _subscriptionId; set => SetField(ref _subscriptionId, value); }
        private StringEnumValue<WebhookResourceType> _resource;
        [JsonRequired]
        public StringEnumValue<WebhookResourceType> Resource { get => _resource; set => SetField(ref _resource, value); }
        private IList<StringEnumValue<WebhookResourceEvent>> _events;
        [JsonRequired]
        public IList<StringEnumValue<WebhookResourceEvent>> Events { get => GetField(ref _events); set => SetField(ref _events, value); }
        private WebhookFilters _filters;
        public WebhookFilters Filters { get => GetField(ref _filters); set => SetField(ref _filters, value); }
        private NeverSerializeValue<string> _objectUrn;
        public string ObjectUrn { get => _objectUrn; set => SetField(ref _objectUrn, value); }
        private NeverSerializeValue<string> _clientId;
        public string ClientId { get => _clientId; set => SetField(ref _clientId, value); }
        private NeverSerializeValue<string> _instanceId;
        public string InstanceId { get => _instanceId; set => SetField(ref _instanceId, value); }
        [IdPropertyName(nameof(SubscriptionId))]
        string IIdentifiable.Id { get => SubscriptionId; set => SubscriptionId = value; }

        [Obsolete("Use other constructor overloads instead.")]
        public WebhookSubscription(string endpoint)
        {
            Preconditions.NotNullOrEmpty(endpoint, nameof(endpoint));

            Endpoint = endpoint;
        }

        public WebhookSubscription(string endpoint, WebhookResourceType resource, IEnumerable<WebhookResourceEvent> events)
            : this(endpoint, resource.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name), events?.Select(e => e.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)))
        {
        }

        [JsonConstructor]
        public WebhookSubscription(string endpoint, string resource, IEnumerable<string> events)
        {
            Preconditions.NotNullOrEmpty(endpoint, nameof(endpoint));
            Preconditions.NotNullOrEmpty(resource, nameof(resource));
            Preconditions.NotNullOrEmpty(events, nameof(events));

            Endpoint = endpoint;
            Resource = resource;
            _events = events.Select(e => new StringEnumValue<WebhookResourceEvent>(e)).ToList();
        }
    }
}