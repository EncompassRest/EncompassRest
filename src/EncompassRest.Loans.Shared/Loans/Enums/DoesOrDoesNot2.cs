using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// DoesOrDoesNot2
/// </summary>
public enum DoesOrDoesNot2
{
    /// <summary>
    /// does not
    /// </summary>
    [EnumMember(Value = "does not")]
    DoesNot = 0,
    /// <summary>
    /// does
    /// </summary>
    [EnumMember(Value = "does")]
    Does = 1
}