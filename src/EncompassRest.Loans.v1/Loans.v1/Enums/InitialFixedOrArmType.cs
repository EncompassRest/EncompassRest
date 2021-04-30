using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// InitialFixedOrArmType
    /// </summary>
    public enum InitialFixedOrArmType
    {
        /// <summary>
        /// Fixed Rate Loan
        /// </summary>
        [EnumMember(Value = "Fixed Rate Loan")]
        FixedRateLoan = 0,
        /// <summary>
        /// Initial Fixed Rate Loan
        /// </summary>
        [EnumMember(Value = "Initial Fixed Rate Loan")]
        InitialFixedRateLoan = 1,
        /// <summary>
        /// Adjustable Rate Loan
        /// </summary>
        [EnumMember(Value = "Adjustable Rate Loan")]
        AdjustableRateLoan = 2,
        /// <summary>
        /// Initial Adjustable Rate Loan
        /// </summary>
        [EnumMember(Value = "Initial Adjustable Rate Loan")]
        InitialAdjustableRateLoan = 3
    }
}