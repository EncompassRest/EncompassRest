using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// YOrN
/// </summary>
public enum YOrN
{
    /// <summary>
    /// No
    /// </summary>
    [Description("No")]
    N = 0,
    /// <summary>
    /// Yes
    /// </summary>
    [Description("Yes")]
    Y = 1
}