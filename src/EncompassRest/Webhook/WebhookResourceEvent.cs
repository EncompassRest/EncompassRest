using System.Runtime.Serialization;

namespace EncompassRest.Webhook
{
    /// <summary>
    /// WebhookResourceEvent
    /// </summary>
    public enum WebhookResourceEvent
    {
        /// <summary>
        /// create
        /// </summary>
        [EnumMember(Value = "create")]
        Create = 0,
        /// <summary>
        /// update
        /// </summary>
        [EnumMember(Value = "update")]
        Update = 1,
        /// <summary>
        /// submit
        /// </summary>
        [EnumMember(Value = "submit")]
        Submit = 2,
        /// <summary>
        /// change
        /// </summary>
        [EnumMember(Value = "change")]
        Change = 3,
        /// <summary>
        /// move
        /// </summary>
        [EnumMember(Value = "move")]
        Move = 4
    }
}