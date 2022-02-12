using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// FannieRelatedLoanAmortizationType
/// </summary>
public enum FannieRelatedLoanAmortizationType
{
    /// <summary>
    /// Adjustable Rate
    /// </summary>
    [EnumMember(Value = "Adjustable Rate")]
    AdjustableRate = 0,
    /// <summary>
    /// Fixed
    /// </summary>
    Fixed = 1,
    /// <summary>
    /// Graduated Payment ARM
    /// </summary>
    [EnumMember(Value = "Graduated Payment ARM")]
    GraduatedPaymentARM = 2,
    /// <summary>
    /// Graduated Payment Mortgage
    /// </summary>
    [EnumMember(Value = "Graduated Payment Mortgage")]
    GraduatedPaymentMortgage = 3,
    /// <summary>
    /// Growing Equity Mortgage
    /// </summary>
    [EnumMember(Value = "Growing Equity Mortgage")]
    GrowingEquityMortgage = 4,
    /// <summary>
    /// Step
    /// </summary>
    Step = 5
}