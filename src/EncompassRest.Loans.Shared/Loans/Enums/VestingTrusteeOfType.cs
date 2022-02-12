using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// VestingTrusteeOfType
/// </summary>
public enum VestingTrusteeOfType
{
    /// <summary>
    /// Trust 1
    /// </summary>
    [EnumMember(Value = "Trust 1")]
    Trust1 = 1,
    /// <summary>
    /// Trust 2
    /// </summary>
    [EnumMember(Value = "Trust 2")]
    Trust2 = 2
}