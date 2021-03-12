using System.Collections.Generic;

namespace EncompassApi.Webhook
{
    /// <summary>
    /// WebhookResource
    /// </summary>
    public sealed class WebhookResource : ExtensibleObject
    {
        /// <summary>
        /// Description of the resource.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// List of supported subscription events.
        /// </summary>
        public List<WebhookResourceEventObject>? Events { get; set; }

        /// <summary>
        /// Name of the resource.
        /// </summary>
        public StringEnumValue<WebhookResourceType> Name { get; set; }

        /// <summary>
        /// Status of the resource.
        /// </summary>
        public StringEnumValue<WebhookResourceStatus> Status { get; set; }
    }
}