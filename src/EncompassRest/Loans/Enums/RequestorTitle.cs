using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum RequestorTitle
    {
        CEO = 0,
        CFO = 1,
        [EnumMember(Value = "Managing Member")]
        ManagingMember = 2,
        [EnumMember(Value = "Member Manager")]
        MemberManager = 3,
        Owner = 4,
        Partner = 5,
        Partnership = 6,
        President = 7,
        Secretary = 8,
        Treasurer = 9,
        [EnumMember(Value = "Vice President")]
        VicePresident = 10
    }
}