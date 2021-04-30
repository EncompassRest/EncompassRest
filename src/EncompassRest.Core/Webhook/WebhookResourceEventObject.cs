namespace EncompassRest.Webhook
{
    /// <summary>
    /// WebhookResourceEventObject
    /// </summary>
    public sealed class WebhookResourceEventObject : ExtensibleObject
    {
        /// <summary>
        /// Event name.
        /// </summary>
        public StringEnumValue<WebhookResourceEvent> Name { get; set; }

        /// <summary>
        /// WebhookResourceEventObject ExtraPayload
        /// </summary>
        public bool? ExtraPayload { get; set; }
    }
}