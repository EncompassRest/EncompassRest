using System.Runtime.Serialization;

namespace EncompassRest.Webhook
{
    public enum WebhookEvent
    {
        [EnumMember(Value = "create")]
        Create = 0,
        [EnumMember(Value = "update")]
        Update = 1,
        [EnumMember(Value = "submit")]
        Submit = 2
    }
}