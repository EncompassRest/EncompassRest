using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// HOEPAStatus
/// </summary>
public enum HOEPAStatus
{
    /// <summary>
    /// 1. High-cost mortgage
    /// </summary>
    [Description("1. High-cost mortgage")]
    [EnumMember(Value = "HOEPA Loan")]
    HOEPALoan = 0,
    /// <summary>
    /// 2. Not a high-cost mortgage
    /// </summary>
    [Description("2. Not a high-cost mortgage")]
    [EnumMember(Value = "Not a HOEPA Loan")]
    NotAHOEPALoan = 1,
    /// <summary>
    /// 3. Not applicable
    /// </summary>
    [Description("3. Not applicable")]
    [EnumMember(Value = "Not applicable")]
    NotApplicable = 2
}