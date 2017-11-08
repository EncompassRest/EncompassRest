using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum NegativeAmortization
    {
        [EnumMember(Value = "scheduled")]
        Scheduled = 0,
        [EnumMember(Value = "potential")]
        Potential = 1,
        [EnumMember(Value = "none")]
        None = 2
    }
}