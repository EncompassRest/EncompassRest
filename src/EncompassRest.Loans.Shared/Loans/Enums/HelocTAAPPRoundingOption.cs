using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// HelocTAAPPRoundingOption
/// </summary>
public enum HelocTAAPPRoundingOption
{
    /// <summary>
    /// to the nearest dollar
    /// </summary>
    [EnumMember(Value = "to the nearest dollar")]
    ToTheNearestDollar = 0,
    /// <summary>
    /// up to the nearest dollar
    /// </summary>
    [EnumMember(Value = "up to the nearest dollar")]
    UpToTheNearestDollar = 1
}