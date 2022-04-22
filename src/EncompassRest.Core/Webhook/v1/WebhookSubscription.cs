using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Webhook.v1
{
    /// <summary>
    /// WebhookSubscription
    /// </summary>
    public sealed class WebhookSubscription : ExtensibleObject, IIdentifiable
    {
        private IList<StringEnumValue<WebhookResourceEvent>>? _events;

        /// <summary>
        /// Unique identifier of the subscription.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? SubscriptionId { get; set; }

        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
        private WebhookFilters? _filters;

        /// <summary>
        /// List of attribute paths to which to subscribe.
        /// </summary>
        [JsonIgnore]
        public WebhookFilters Filters { get => _filters ??= new(); set => _filters = value; }

        /// <summary>
        /// Unique identifier per client assigned by Ellie Mae.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientId { get; set; }

        /// <summary>
        /// URN format of the subscribed resource.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? ObjectUrn { get; set; }

        /// <summary>
        /// Defines the events that make up the subscription.
        /// </summary>
        [JsonRequired]
        [AllowNull]
        public IList<StringEnumValue<WebhookResourceEvent>> Events { get => _events ??= new List<StringEnumValue<WebhookResourceEvent>>(); set => _events = value; }

        /// <summary>
        /// Subscriber's Encompass instance ID.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? InstanceId { get; set; }

        /// <summary>
        /// The callback URL where the event notification will be delivered. The URL is expected to be a functioning and reliable HTTPS URL that is known only to the subscriber (a client's application). The callback URLs need to be under one base domain.
        /// </summary>
        [JsonRequired]
        public string? Endpoint { get; set; }

        /// <summary>
        /// The password to assign to the subscription.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Signingkey { get; set; }

        /// <summary>
        /// Refers to the resource that is part of subscription.
        /// </summary>
        [JsonRequired]
        public StringEnumValue<WebhookResourceType> Resource { get; set; }

        [IdPropertyName(nameof(SubscriptionId))]
        string? IIdentifiable.Id { get => SubscriptionId; set => SubscriptionId = value; }

        /// <summary>
        /// WebhookSubscription constructor.
        /// </summary>
        /// <param name="endpoint">The callback URL where the event notification will be delivered.</param>
        /// <param name="resource">Refers to the resource that is part of subscription.</param>
        /// <param name="events">Defines the events that make up the subscription.</param>
        public WebhookSubscription(string endpoint, WebhookResourceType resource, IEnumerable<WebhookResourceEvent> events)
            : this(endpoint, resource.Validate(nameof(resource)).GetValue(), events?.Select(e => e.Validate(nameof(events)).GetValue())!)
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
            Events = events.Select(e => new StringEnumValue<WebhookResourceEvent>(e)).ToList();
        }
    }
}
