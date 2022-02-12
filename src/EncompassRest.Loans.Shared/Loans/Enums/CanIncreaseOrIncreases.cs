using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// CanIncreaseOrIncreases
/// </summary>
public enum CanIncreaseOrIncreases
{
    /// <summary>
    /// Can increase
    /// </summary>
    [EnumMember(Value = "Can increase")]
    CanIncrease = 0,
    /// <summary>
    /// Increases
    /// </summary>
    Increases = 1
}