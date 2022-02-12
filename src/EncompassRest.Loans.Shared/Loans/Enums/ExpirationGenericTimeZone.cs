using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// ExpirationGenericTimeZone
/// </summary>
public enum ExpirationGenericTimeZone
{
    /// <summary>
    /// (UTC -10:00) Hawaii Time
    /// </summary>
    [Description("(UTC -10:00) Hawaii Time")]
    HST = 0,
    /// <summary>
    /// (UTC -08:00/09:00) Alaska Time
    /// </summary>
    [Description("(UTC -08:00/09:00) Alaska Time")]
    AKT = 1,
    /// <summary>
    /// (UTC -07:00/08:00) Pacific Time
    /// </summary>
    [Description("(UTC -07:00/08:00) Pacific Time")]
    PT = 2,
    /// <summary>
    /// (UTC -07:00) Arizona Time
    /// </summary>
    [Description("(UTC -07:00) Arizona Time")]
    MST = 3,
    /// <summary>
    /// (UTC -06:00/07:00) Mountain Time
    /// </summary>
    [Description("(UTC -06:00/07:00) Mountain Time")]
    MT = 4,
    /// <summary>
    /// (UTC -05:00/06:00) Central Time
    /// </summary>
    [Description("(UTC -05:00/06:00) Central Time")]
    CT = 5,
    /// <summary>
    /// (UTC -04:00/05:00) Eastern Time
    /// </summary>
    [Description("(UTC -04:00/05:00) Eastern Time")]
    ET = 6
}