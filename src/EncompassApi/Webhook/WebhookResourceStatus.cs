using System.Runtime.Serialization;

namespace EncompassApi.Webhook
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