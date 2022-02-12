using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// HelocPeriodicRateIndicator
/// </summary>
public enum HelocPeriodicRateIndicator
{
    /// <summary>
    /// Daily Periodic Rate
    /// </summary>
    [EnumMember(Value = "Daily Periodic Rate")]
    DailyPeriodicRate = 0,
    /// <summary>
    /// Monthly Periodic Rate
    /// </summary>
    [EnumMember(Value = "Monthly Periodic Rate")]
    MonthlyPeriodicRate = 1
}