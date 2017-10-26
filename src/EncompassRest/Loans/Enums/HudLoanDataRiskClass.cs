using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum HudLoanDataRiskClass
    {
        [EnumMember(Value = "A/A")]
        AA = 0,
        Refer = 1
    }
}