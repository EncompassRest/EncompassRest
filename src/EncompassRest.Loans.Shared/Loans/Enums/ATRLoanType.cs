using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// ATRLoanType
/// </summary>
public enum ATRLoanType
{
    /// <summary>
    /// Exempt
    /// </summary>
    Exempt = 0,
    /// <summary>
    /// General ATR
    /// </summary>
    [EnumMember(Value = "General ATR")]
    GeneralATR = 1,
    /// <summary>
    /// Non-Standard to Standard Refinance
    /// </summary>
    [EnumMember(Value = "Non-Standard to Standard Refinance")]
    NonStandardToStandardRefinance = 2,
    /// <summary>
    /// Qualified Mortgage
    /// </summary>
    [EnumMember(Value = "Qualified Mortgage")]
    QualifiedMortgage = 3
}