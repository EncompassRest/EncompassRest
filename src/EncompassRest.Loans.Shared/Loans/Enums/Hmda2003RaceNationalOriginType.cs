using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// Hmda2003RaceNationalOriginType
/// </summary>
public enum Hmda2003RaceNationalOriginType
{
    /// <summary>
    /// American Indian or Alaska Native
    /// </summary>
    [Description("American Indian or Alaska Native")]
    AmericanIndianOrAlaskanNative = 0,
    /// <summary>
    /// Asian or Pacific Islander
    /// </summary>
    [Description("Asian or Pacific Islander")]
    AsianOrPacificIslander = 1,
    /// <summary>
    /// Black, not Hispanic
    /// </summary>
    [Description("Black, not Hispanic")]
    BlackNotOfHispanicOrigin = 2,
    /// <summary>
    /// Hispanic
    /// </summary>
    Hispanic = 3,
    /// <summary>
    /// White, not Hispanic
    /// </summary>
    [Description("White, not Hispanic")]
    WhiteNotOfHispanicOrigin = 4,
    /// <summary>
    /// Information Not Provided
    /// </summary>
    [Description("Information Not Provided")]
    InformationNotProvided = 5,
    /// <summary>
    /// Other
    /// </summary>
    Other = 6
}