using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// HelocTAInstallmentIndexRefDateOption
    /// </summary>
    public enum HelocTAInstallmentIndexRefDateOption
    {
        /// <summary>
        /// the day
        /// </summary>
        [EnumMember(Value = "the day")]
        TheDay = 0,
        /// <summary>
        /// the business day
        /// </summary>
        [EnumMember(Value = "the business day")]
        TheBusinessDay = 1,
        /// <summary>
        /// the first day of the calendar month
        /// </summary>
        [EnumMember(Value = "the first day of the calendar month")]
        TheFirstDayOfTheCalendarMonth = 2,
        /// <summary>
        /// the first business day of the calendar month
        /// </summary>
        [EnumMember(Value = "the first business day of the calendar month")]
        TheFirstBusinessDayOfTheCalendarMonth = 3
    }
}