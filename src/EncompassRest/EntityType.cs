using System.Runtime.Serialization;

namespace EncompassRest
{
    public enum EntityType
    {
        [EnumMember(Value = "attachment")]
        Attachment = 0,
        [EnumMember(Value = "loan")]
        Loan = 1
    }
}