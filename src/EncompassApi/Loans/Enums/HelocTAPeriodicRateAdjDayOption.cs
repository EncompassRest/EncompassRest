using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// HelocTAPeriodicRateAdjDayOption
    /// </summary>
    public enum HelocTAPeriodicRateAdjDayOption
    {
        /// <summary>
        /// the day the Index changes
        /// </summary>
        [EnumMember(Value = "the day the Index changes")]
        TheDayTheIndexChanges = 0,
        /// <summary>
        /// the first day of the Monthly Statement Period after the Index changes
        /// </summary>
        [EnumMember(Value = "the first day of the Monthly Statement Period after the Index changes")]
        TheFirstDayOfTheMonthlyStatementPeriodAfterTheIndexChanges = 1,
        /// <summary>
        /// the first business day of the Monthly Statement Period after the Index changes
        /// </summary>
        [EnumMember(Value = "the first business day of the Monthly Statement Period after the Index changes")]
        TheFirstBusinessDayOfTheMonthlyStatementPeriodAfterTheIndexChanges = 2
    }
}