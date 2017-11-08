using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum OpenEndLineOfCredit
    {
        [EnumMember(Value = "Open-end line of credit")]
        OpenEndLineOfCredit = 0,
        [EnumMember(Value = "Not an open-end line of credit")]
        NotAnOpenEndLineOfCredit = 1
    }
}