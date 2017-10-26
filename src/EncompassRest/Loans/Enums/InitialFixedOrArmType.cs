using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum InitialFixedOrArmType
    {
        [EnumMember(Value = "Fixed Rate Loan")]
        FixedRateLoan = 0,
        [EnumMember(Value = "Initial Fixed Rate Loan")]
        InitialFixedRateLoan = 1,
        [EnumMember(Value = "Adjustable Rate Loan")]
        AdjustableRateLoan = 2,
        [EnumMember(Value = "Initial Adjustable Rate Loan")]
        InitialAdjustableRateLoan = 3
    }
}