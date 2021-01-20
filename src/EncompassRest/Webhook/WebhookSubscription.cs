using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Webhook
{
    /// <summary>
    /// WebhookSubscription
    /// </summary>
    public sealed class WebhookSubscription : DirtyExtensibleObject, IIdentifiable
    {
        private string? _subscriptionId;
        private WebhookFilters? _filters;
        private NeverSerializeValue<string?>? _clientId;
        private NeverSerializeValue<string?>? _objectUrn;
        private List<StringEnumValue<WebhookResourceEvent>>? _events;
        private NeverSerializeValue<string?>? _instanceId;
        private string? _endpoint;
        private StringEnumValue<WebhookResourceType> _resource;
        private string? _signingkey;

        /// <summary>
        /// Unique identifier of the subscription.
        /// </summary>
        public string? SubscriptionId { get => _subscriptionId; set => SetField(ref _subscriptionId, value); }

        /// <summary>
        /// List of attribute paths to which to subscribe.
        /// </summary>
        [AllowNull]
        public WebhookFilters Filters { get => GetField(ref _filters); set => SetField(ref _filters, value); }

        /// <summary>
        /// Unique identifier per client assigned by Ellie Mae.
        /// </summary>
        public string? ClientId { get => _clientId; set => SetField(ref _clientId, value); }

        /// <summary>
        /// URN format of the subscribed resource.
        /// </summary>
        public string? ObjectUrn { get => _objectUrn; set => SetField(ref _objectUrn, value); }

        /// <summary>
        /// Defines the events that make up the subscription.
        /// </summary>
        [JsonRequired]
        [AllowNull]
        public IList<StringEnumValue<WebhookResourceEvent>> Events { get => GetField(ref _events); set => SetField(ref _events, value?.ToList()); }

        /// <summary>
        /// Subscriber's Encompass instance ID.
        /// </summary>
        public string? InstanceId { get => _instanceId; set => SetField(ref _instanceId, value); }

        /// <summary>
        /// The callback URL where the event notification will be delivered. The URL is expected to be a functioning and reliable HTTPS URL that is known only to the subscriber (a client's application). The callback URLs need to be under one base domain.
        /// </summary>
        [JsonRequired]
        public string? Endpoint { get => _endpoint; set => SetField(ref _endpoint, value); }

        /// <summary>
        /// The password to assign to the subscription.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Signingkey { get => _signingkey; set => SetField(ref _signingkey, value); }

        /// <summary>
        /// Refers to the resource that is part of subscription.
        /// </summary>
        [JsonRequired]
        public StringEnumValue<WebhookResourceType> Resource { get => _resource; set => SetField(ref _resource, value); }

        [IdPropertyName(nameof(SubscriptionId))]
        string? IIdentifiable.Id { get => SubscriptionId; set => SubscriptionId = value; }

        /// <summary>
        /// WebhookSubscription constructor.
        /// </summary>
        /// <param name="endpoint">The callback URL where the event notification will be delivered.</param>
        /// <param name="resource">Refers to the resource that is part of subscription.</param>
        /// <param name="events">Defines the events that make up the subscription.</param>
        public WebhookSubscription(string endpoint, WebhookResourceType resource, IEnumerable<WebhookResourceEvent> events)
            : this(endpoint, resource.Validate(nameof(resource)).GetValue()!, events.Select(e => e.Validate(nameof(events)).GetValue()!))
        {
        }

        /// <summary>
        /// WebhookSubscription constructor.
        /// </summary>
        /// <param name="endpoint">The callback URL where the event notification will be delivered.</param>
        /// <param name="resource">Refers to the resource that is part of subscription.</param>
        /// <param name="events">Defines the events that make up the subscription.</param>
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
