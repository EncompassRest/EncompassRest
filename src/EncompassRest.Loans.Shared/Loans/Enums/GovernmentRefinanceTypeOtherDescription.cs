using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// GovernmentRefinanceTypeOtherDescription
/// </summary>
public enum GovernmentRefinanceTypeOtherDescription
{
    /// <summary>
    /// 203k
    /// </summary>
    [EnumMember(Value = "203k")]
    n203k = 0,
    /// <summary>
    /// Rate Term
    /// </summary>
    [Description("Rate Term")]
    RateTerm = 1,
    /// <summary>
    /// Short
    /// </summary>
    Short = 2,
    /// <summary>
    /// Simple
    /// </summary>
    Simple = 3,
    /// <summary>
    /// Streamline Credit
    /// </summary>
    [Description("Streamline Credit")]
    StreamlineCredit = 4,
    /// <summary>
    /// Streamline No Credit
    /// </summary>
    [Description("Streamline No Credit")]
    StreamlineNoCredit = 5
}