using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// RdsfhRefinancedLoanIndicatorType
    /// </summary>
    public enum RdsfhRefinancedLoanIndicatorType
    {
        /// <summary>
        /// Guaranteed Loan
        /// </summary>
        [EnumMember(Value = "Guaranteed Loan")]
        GuaranteedLoan = 0,
        /// <summary>
        /// Direct Loan
        /// </summary>
        [EnumMember(Value = "Direct Loan")]
        DirectLoan = 1
    }
}