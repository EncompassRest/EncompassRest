using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// SpecialFeatureCodeSource
/// </summary>
public enum SpecialFeatureCodeSource
{
    /// <summary>
    /// Fannie Mae
    /// </summary>
    [Description("Fannie Mae")]
    FannieMae = 0,
    /// <summary>
    /// Freddie Mac
    /// </summary>
    [Description("Freddie Mac")]
    FreddieMac = 1,
    /// <summary>
    /// Other
    /// </summary>
    Other = 2
}