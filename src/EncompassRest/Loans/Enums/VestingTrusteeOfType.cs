using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum VestingTrusteeOfType
    {
        [EnumMember(Value = "Trust 1")]
        Trust1 = 1,
        [EnumMember(Value = "Trust 2")]
        Trust2 = 2
    }
}