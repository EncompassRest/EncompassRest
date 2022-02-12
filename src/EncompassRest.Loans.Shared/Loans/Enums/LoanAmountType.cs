using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// LoanAmountType
/// </summary>
public enum LoanAmountType
{
    /// <summary>
    /// Total Loan
    /// </summary>
    [EnumMember(Value = "Total Loan")]
    TotalLoan = 0,
    /// <summary>
    /// Base Loan
    /// </summary>
    [EnumMember(Value = "Base Loan")]
    BaseLoan = 1
}