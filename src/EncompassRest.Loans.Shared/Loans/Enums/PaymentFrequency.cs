using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// PaymentFrequency
/// </summary>
public enum PaymentFrequency
{
    /// <summary>
    /// Monthly
    /// </summary>
    Monthly = 0,
    /// <summary>
    /// Annually
    /// </summary>
    Annually = 1,
    /// <summary>
    /// One time lump sum
    /// </summary>
    [EnumMember(Value = "One time lump sum")]
    OneTimeLumpSum = 2,
    /// <summary>
    /// Single Specific
    /// </summary>
    [EnumMember(Value = "Single Specific")]
    SingleSpecific = 3,
    /// <summary>
    /// Not applicable
    /// </summary>
    [EnumMember(Value = "Not applicable")]
    NotApplicable = 4
}