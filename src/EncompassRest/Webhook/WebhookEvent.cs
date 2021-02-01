using System;

namespace EncompassRest.Webhook
{
    /// <summary>
    /// WebhookEvent
    /// </summary>
    public sealed class WebhookEvent : ExtensibleObject
    {
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
    }
}