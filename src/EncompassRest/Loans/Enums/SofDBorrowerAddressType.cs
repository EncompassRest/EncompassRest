using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum SofDBorrowerAddressType
    {
        [EnumMember(Value = "Present Address")]
        PresentAddress = 0,
        [EnumMember(Value = "Mailing Address")]
        MailingAddress = 1,
        [EnumMember(Value = "Subject Address")]
        SubjectAddress = 2
    }
}