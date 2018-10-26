using System;

namespace EncompassRest.Organizations
{
    public sealed class OnrpSettings : ParentInformation
    {
        private DirtyValue<bool?> _continuousCoverage;
        private DirtyValue<decimal?> _dollarLimit;
        private DirtyValue<bool?> _enableOnrp;
        private DirtyValue<bool?> _enableSaturday;
        private DirtyValue<bool?> _enableSunday;
        private DirtyValue<bool?> _noMaximumLimit;
        private DirtyValue<TimeSpan?> _saturdayEndTime;
        private DirtyValue<TimeSpan?> _saturdayStartTime;
        private DirtyValue<TimeSpan?> _sundayEndTime;
        private DirtyValue<TimeSpan?> _sundayStartTime;
        private DirtyValue<int?> _tolerance;
        private DirtyValue<bool?> _useChannelDefault;
        private DirtyValue<TimeSpan?> _weekdayEndTime;
        private DirtyValue<TimeSpan?> _weekdayStartTime;
        private DirtyValue<bool?> _weekendHolidayCoverage;

        public bool? ContinuousCoverage { get => _continuousCoverage; set => SetField(ref _continuousCoverage, value); }

        public decimal? DollarLimit { get => _dollarLimit; set => SetField(ref _dollarLimit, value); }

        public bool? EnableOnrp { get => _enableOnrp; set => SetField(ref _enableOnrp, value); }

        public bool? EnableSaturday { get => _enableSaturday; set => SetField(ref _enableSaturday, value); }

        public bool? EnableSunday { get => _enableSunday; set => SetField(ref _enableSunday, value); }

        public bool? NoMaximumLimit { get => _noMaximumLimit; set => SetField(ref _noMaximumLimit, value); }

        public TimeSpan? SaturdayEndTime { get => _saturdayEndTime; set => SetField(ref _saturdayEndTime, value); }

        public TimeSpan? SaturdayStartTime { get => _saturdayStartTime; set => SetField(ref _saturdayStartTime, value); }

        public TimeSpan? SundayEndTime { get => _sundayEndTime; set => SetField(ref _sundayEndTime, value); }

        public TimeSpan? SundayStartTime { get => _sundayStartTime; set => SetField(ref _sundayStartTime, value); }

        public int? Tolerance { get => _tolerance; set => SetField(ref _tolerance, value); }

        public bool? UseChannelDefault { get => _useChannelDefault; set => SetField(ref _useChannelDefault, value); }

        public TimeSpan? WeekdayEndTime { get => _weekdayEndTime; set => SetField(ref _weekdayEndTime, value); }

        public TimeSpan? WeekdayStartTime { get => _weekdayStartTime; set => SetField(ref _weekdayStartTime, value); }

        public bool? WeekendHolidayCoverage { get => _weekendHolidayCoverage; set => SetField(ref _weekendHolidayCoverage, value); }
    }
}