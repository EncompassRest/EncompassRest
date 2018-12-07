using System;
using EncompassRest.Company;

namespace EncompassRest.Organizations
{
    /// <summary>
    /// Object containing information about the Overnight Rate Protection (ONRP) settings.
    /// </summary>
    public sealed class OnrpSettings : ParentInformation
    {
        private DirtyValue<bool?> _enableOnrp;
        private DirtyValue<bool?> _useChannelDefault;
        private DirtyValue<bool?> _continuousCoverage;
        private DirtyValue<TimeSpan?> _weekdayStartTime;
        private DirtyValue<TimeSpan?> _weekdayEndTime;
        private DirtyValue<bool?> _weekendHolidayCoverage;
        private DirtyValue<bool?> _enableSunday;
        private DirtyValue<TimeSpan?> _sundayStartTime;
        private DirtyValue<TimeSpan?> _sundayEndTime;
        private DirtyValue<bool?> _enableSaturday;
        private DirtyValue<TimeSpan?> _saturdayStartTime;
        private DirtyValue<TimeSpan?> _saturdayEndTime;
        private DirtyValue<bool?> _noMaximumLimit;
        private DirtyValue<decimal?> _dollarLimit;
        private DirtyValue<int?> _tolerance;

        /// <summary>
        /// Indicates whether ONRP is enabled for the organization.
        /// </summary>
        public bool? EnableOnrp { get => _enableOnrp; set => SetField(ref _enableOnrp, value); }

        /// <summary>
        /// Indicates whether Channel Defaults or Custom Settings are used by the organization.
        /// </summary>
        public bool? UseChannelDefault { get => _useChannelDefault; set => SetField(ref _useChannelDefault, value); }

        /// <summary>
        /// Indicates whether ONRP coverage is continuous or set for a specific time period.
        /// </summary>
        /// <remarks>
        /// Note: If <c>true</c>, then OnrpSettings.EndTime settings are set to the Lock Desk Start Time and cannot be edited. In addition,
        /// the OnrpSettings for Saturday, Sunday, and Weekend/HolidayCoverage are disabled.
        /// </remarks>
        public bool? ContinuousCoverage { get => _continuousCoverage; set => SetField(ref _continuousCoverage, value); }

        /// <summary>
        /// The start time for weekday coverage.
        /// </summary>
        public TimeSpan? WeekdayStartTime { get => _weekdayStartTime; set => SetField(ref _weekdayStartTime, value); }

        /// <summary>
        /// The end time for weekday coverage.
        /// </summary>
        public TimeSpan? WeekdayEndTime { get => _weekdayEndTime; set => SetField(ref _weekdayEndTime, value); }

        /// <summary>
        /// Indicates whether weekend and holiday coverage is available.
        /// </summary>
        public bool? WeekendHolidayCoverage { get => _weekendHolidayCoverage; set => SetField(ref _weekendHolidayCoverage, value); }

        /// <summary>
        /// Indicates whether Sundays are covered.
        /// </summary>
        public bool? EnableSunday { get => _enableSunday; set => SetField(ref _enableSunday, value); }

        /// <summary>
        /// The start time for Sunday coverage.
        /// </summary>
        public TimeSpan? SundayStartTime { get => _sundayStartTime; set => SetField(ref _sundayStartTime, value); }

        /// <summary>
        /// The end time for Sundays coverage.
        /// </summary>
        public TimeSpan? SundayEndTime { get => _sundayEndTime; set => SetField(ref _sundayEndTime, value); }

        /// <summary>
        /// Indicates whether Saturdays are covered.
        /// </summary>
        public bool? EnableSaturday { get => _enableSaturday; set => SetField(ref _enableSaturday, value); }

        /// <summary>
        /// The start time for Saturday coverage.
        /// </summary>
        public TimeSpan? SaturdayStartTime { get => _saturdayStartTime; set => SetField(ref _saturdayStartTime, value); }

        /// <summary>
        /// The end time for Saturday coverage.
        /// </summary>
        public TimeSpan? SaturdayEndTime { get => _saturdayEndTime; set => SetField(ref _saturdayEndTime, value); }

        /// <summary>
        /// Indicates whether there is no maximum limit on ONRP dollar amount or ONRP tolerance percentage.
        /// </summary>
        public bool? NoMaximumLimit { get => _noMaximumLimit; set => SetField(ref _noMaximumLimit, value); }

        /// <summary>
        /// The ONRP dollar amount limit.
        /// </summary>
        /// <remarks>
        /// This attribute is required if OnrpSettings.NoMaximumLimit is set to <c>false</c>.
        /// </remarks>
        public decimal? DollarLimit { get => _dollarLimit; set => SetField(ref _dollarLimit, value); }

        /// <summary>
        /// The ONRP tolerance percentage.
        /// </summary>
        public int? Tolerance { get => _tolerance; set => SetField(ref _tolerance, value); }
    }
}