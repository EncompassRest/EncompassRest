using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

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