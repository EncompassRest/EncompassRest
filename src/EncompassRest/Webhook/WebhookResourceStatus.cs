using System.Runtime.Serialization;

namespace EncompassRest.Webhook
{
    public enum WebhookResourceStatus
    {
        [EnumMember(Value = "active")]
        Active = 0
    }
}