using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// RoundingMethod
/// </summary>
public enum RoundingMethod
{
    /// <summary>
    /// To Nearest Cent
    /// </summary>
    [EnumMember(Value = "To Nearest Cent")]
    ToNearestCent = 0,
    /// <summary>
    /// To Nearest Dollar
    /// </summary>
    [EnumMember(Value = "To Nearest Dollar")]
    ToNearestDollar = 1
}