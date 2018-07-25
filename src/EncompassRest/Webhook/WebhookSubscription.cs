using System;
using System.Collections.Generic;
using System.Linq;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Webhook
{
    public sealed class WebhookSubscription : ExtensibleObject, IIdentifiable
    {
        [JsonRequired]
        public string Endpoint { get; set; }
        public string SubscriptionId { get; set; }
        [JsonRequired]
        public StringEnumValue<WebhookResourceType> Resource { get; set; }
        private List<StringEnumValue<WebhookResourceEvent>> _events;
        [JsonRequired]
        public IList<StringEnumValue<WebhookResourceEvent>> Events { get => _events ?? (_events = new List<StringEnumValue<WebhookResourceEvent>>()); set => _events = value != null ? new List<StringEnumValue<WebhookResourceEvent>>(value) : null; }
        private WebhookFilters _filters;
        public WebhookFilters Filters { get => _filters ?? (_filters = new WebhookFilters()); set => _filters = value; }
        private NeverSerializeValue<string> _objectUrn;
        public string ObjectUrn { get => _objectUrn; set => _objectUrn = value; }
        private NeverSerializeValue<string> _clientId;
        public string ClientId { get => _clientId; set => _clientId = value; }
        private NeverSerializeValue<string> _instanceId;
        public string InstanceId { get => _instanceId; set => _instanceId = value; }
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