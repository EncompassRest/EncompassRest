using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// OtherNonAmortization
/// </summary>
public enum OtherNonAmortization
{
    /// <summary>
    /// 1. Other non-fully amortizing features
    /// </summary>
    [Description("1. Other non-fully amortizing features")]
    [EnumMember(Value = "Other non-fully amortizing features")]
    OtherNonFullyAmortizingFeatures = 0,
    /// <summary>
    /// 2. No other non-fully amortizing features
    /// </summary>
    [Description("2. No other non-fully amortizing features")]
    [EnumMember(Value = "No other non-fully amortizing features")]
    NoOtherNonFullyAmortizingFeatures = 1,
    /// <summary>
    /// 1111. Exempt
    /// </summary>
    [Description("1111. Exempt")]
    Exempt = 2
}