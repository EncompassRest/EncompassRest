using System;

namespace EncompassRest.Webhook
{
    /// <summary>
    /// WebhookEventPayload
    /// </summary>
    public sealed class WebhookEventPayload : ExtensibleObject
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        /// <summary>
        /// Unique identifier per client assigned by Ellie Mae. This is an optional field. It will be populated automatically based on authentication details.
        /// </summary>
        public string? ClientId { get; set; }

        /// <summary>
        /// Unique identifier for the event, which ensures events are only digested once.
        /// </summary>
        public string EventId { get; set; }

        /// <summary>
        /// The timestamp (ISO8601 format) of when the event occurred.
        /// </summary>
        public DateTime EventTime { get; set; }

        /// <summary>
        /// The type of event that occurred.
        /// </summary>
        public StringEnumValue<WebhookResourceEvent> EventType { get; set; }

        /// <summary>
        /// The delay or amount of time between receiving the event and processing the event.
        /// </summary>
        public DateTime IngressTime { get; set; }

        /// <summary>
        /// Encompass instance ID.
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// The unique identifier of the resource this event is associated with (that is, the loan GUID).
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// The type of resource that generated this event.
        /// </summary>
        public StringEnumValue<WebhookResourceType> ResourceType { get; set; }

        /// <summary>
        /// WebhookEventPayload Status
        /// </summary>
        public StringEnumValue<WebhookStatus> Status { get; set; }

        /// <summary>
        /// Additional details about the webhook’s status.
        /// </summary>
        public string StatusDetails { get; set; }

        /// <summary>
        /// The unique ID assigned to the subscription when it is created.
        /// </summary>
        public string? SubscriptionId { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}