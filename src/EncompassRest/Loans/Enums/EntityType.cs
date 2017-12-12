using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum EntityType
    {
        [EnumMember(Value = "attachment")]
        Attachment = 0,
        [EnumMember(Value = "loan")]
        Loan = 1
    }
}