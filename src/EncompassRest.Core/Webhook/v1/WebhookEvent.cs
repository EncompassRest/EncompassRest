using System;

namespace EncompassRest.Webhook.v1
{
    /// <summary>
    /// WebhookEvent
    /// </summary>
    public sealed class WebhookEvent : ExtensibleObject
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        /// <summary>
        /// The unique identifier of the event.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The type of event.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The timestamp (ISO8601 format) of when the event occurred.
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// Object containing the payload.
        /// </summary>
        public WebhookEventPayload Event { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}