using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// SecondaryFinancingType
/// </summary>
public enum SecondaryFinancingType
{
    /// <summary>
    /// No secondary financing
    /// </summary>
    [Description("No secondary financing")]
    [EnumMember(Value = "0")]
    n0 = 0,
    /// <summary>
    /// Hard
    /// </summary>
    [Description("Hard")]
    [EnumMember(Value = "1")]
    n1 = 1,
    /// <summary>
    /// Soft
    /// </summary>
    [Description("Soft")]
    [EnumMember(Value = "2")]
    n2 = 2,
    /// <summary>
    /// Very Soft
    /// </summary>
    [Description("Very Soft")]
    [EnumMember(Value = "3")]
    n3 = 3
}