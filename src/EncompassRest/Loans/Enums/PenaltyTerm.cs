using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PenaltyTerm
    {
        [EnumMember(Value = "1 Year")]
        n1Year = 1,
        [EnumMember(Value = "2 Years")]
        n2Years = 2,
        [EnumMember(Value = "3 Years")]
        n3Years = 3
    }
}