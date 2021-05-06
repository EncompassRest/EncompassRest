using System.Runtime.Serialization;

namespace EncompassRest.Webhook.v1
{
    /// <summary>
    /// WebhookResourceStatus
    /// </summary>
    public enum WebhookResourceStatus
    {
        /// <summary>
        /// active
        /// </summary>
        [EnumMember(Value = "active")]
        Active = 0,
        /// <summary>
        /// not
        /// </summary>
        [EnumMember(Value = "not")]
        Not = 1,
    }
}