using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// HelocTAIndexRefDateOption
    /// </summary>
    public enum HelocTAIndexRefDateOption
    {
        /// <summary>
        /// each day
        /// </summary>
        [EnumMember(Value = "each day")]
        EachDay = 0,
        /// <summary>
        /// on the first day of each calendar month
        /// </summary>
        [EnumMember(Value = "on the first day of each calendar month")]
        OnTheFirstDayOfEachCalendarMonth = 1,
        /// <summary>
        /// on the first business day of each calendar month
        /// </summary>
        [EnumMember(Value = "on the first business day of each calendar month")]
        OnTheFirstBusinessDayOfEachCalendarMonth = 2
    }
}