using System;
using EncompassRest.Company.v1;

namespace EncompassRest.Organizations.v1
{
    /// <summary>
    /// Object containing information about the Overnight Rate Protection (ONRP) settings.
    /// </summary>
    public sealed class OnrpSettings : ParentInformation
    {
        /// <summary>
        /// Indicates whether ONRP is enabled for the organization.
        /// </summary>
        public bool? EnableOnrp { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether Channel Defaults or Custom Settings are used by the organization.
        /// </summary>
        public bool? UseChannelDefault { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether ONRP coverage is continuous or set for a specific time period.
        /// </summary>
        /// <remarks>
        /// Note: If <c>true</c>, then OnrpSettings.EndTime settings are set to the Lock Desk Start Time and cannot be edited. In addition,
        /// the OnrpSettings for Saturday, Sunday, and Weekend/HolidayCoverage are disabled.
        /// </remarks>
        public bool? ContinuousCoverage { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// The start time for weekday coverage.
        /// </summary>
        public TimeSpan? WeekdayStartTime { get => GetValue<TimeSpan?>(); set => SetValue(value); }

        /// <summary>
        /// The end time for weekday coverage.
        /// </summary>
        public TimeSpan? WeekdayEndTime { get => GetValue<TimeSpan?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether weekend and holiday coverage is available.
        /// </summary>
        public bool? WeekendHolidayCoverage { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether Sundays are covered.
        /// </summary>
        public bool? EnableSunday { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// The start time for Sunday coverage.
        /// </summary>
        public TimeSpan? SundayStartTime { get => GetValue<TimeSpan?>(); set => SetValue(value); }

        /// <summary>
        /// The end time for Sundays coverage.
        /// </summary>
        public TimeSpan? SundayEndTime { get => GetValue<TimeSpan?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether Saturdays are covered.
        /// </summary>
        public bool? EnableSaturday { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// The start time for Saturday coverage.
        /// </summary>
        public TimeSpan? SaturdayStartTime { get => GetValue<TimeSpan?>(); set => SetValue(value); }

        /// <summary>
        /// The end time for Saturday coverage.
        /// </summary>
        public TimeSpan? SaturdayEndTime { get => GetValue<TimeSpan?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether there is no maximum limit on ONRP dollar amount or ONRP tolerance percentage.
        /// </summary>
        public bool? NoMaximumLimit { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// The ONRP dollar amount limit.
        /// </summary>
        /// <remarks>
        /// This attribute is required if OnrpSettings.NoMaximumLimit is set to <c>false</c>.
        /// </remarks>
        public decimal? DollarLimit { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The ONRP tolerance percentage.
        /// </summary>
        public int? Tolerance { get => GetValue<int?>(); set => SetValue(value); }
    }
}