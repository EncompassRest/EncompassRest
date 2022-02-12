using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// NoteRateType
/// </summary>
public enum NoteRateType
{
    /// <summary>
    /// Note Rate
    /// </summary>
    [Description("Note Rate")]
    NoteRate = 0,
    /// <summary>
    /// Bought Dn Rate
    /// </summary>
    [Description("Bought Dn Rate")]
    BoughtDownRate = 1,
    /// <summary>
    /// % Above
    /// </summary>
    [Description("% Above")]
    Above = 2,
    /// <summary>
    /// % Below
    /// </summary>
    [Description("% Below")]
    Below = 3,
    /// <summary>
    /// Other
    /// </summary>
    Other = 4
}