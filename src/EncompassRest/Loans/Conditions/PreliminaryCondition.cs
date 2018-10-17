using System;

namespace EncompassRest.Loans.Conditions
{
    public sealed class PreliminaryCondition : LoanCondition
    {
        private DirtyValue<bool?> _uwAccess;
        private DirtyValue<StringEnumValue<PriorToMilestone>> _priorTo;
        private DirtyValue<StringEnumValue<ConditionCategory>> _category;
        private DirtyValue<bool?> _isFulfilled;
        private DirtyValue<DateTime?> _fulfilledDate;
        private EntityReference _fulfilledBy;

        public bool? UWAccess { get => _uwAccess; set => SetField(ref _uwAccess, value); }

        public StringEnumValue<PriorToMilestone> PriorTo { get => _priorTo; set => SetField(ref _priorTo, value); }

        public StringEnumValue<ConditionCategory> Category { get => _category; set => SetField(ref _category, value); }

        public bool? IsFulfilled { get => _isFulfilled; set => SetField(ref _isFulfilled, value); }

        public DateTime? FulfilledDate { get => _fulfilledDate; set => SetField(ref _fulfilledDate, value); }

        public EntityReference FulfilledBy { get => GetField(ref _fulfilledBy); set => SetField(ref _fulfilledBy, value); }
    }
}