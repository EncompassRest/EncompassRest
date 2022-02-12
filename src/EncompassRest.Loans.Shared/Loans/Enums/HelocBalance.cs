using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// HelocBalance
/// </summary>
public enum HelocBalance
{
    /// <summary>
    /// Initial Draw
    /// </summary>
    [Description("Initial Draw")]
    [EnumMember(Value = "1888")]
    n1888 = 0,
    /// <summary>
    /// Maximum Balance
    /// </summary>
    [Description("Maximum Balance")]
    [EnumMember(Value = "2")]
    n2 = 1
}