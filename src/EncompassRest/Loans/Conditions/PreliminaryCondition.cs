using System;

namespace EncompassRest.Loans.Conditions
{
    public sealed class PreliminaryCondition : LoanCondition
    {
        private DirtyValue<bool?> _uwAccess;
        public bool? UWAccess { get => _uwAccess; set => SetField(ref _uwAccess, value); }
        private DirtyValue<StringEnumValue<PriorToMilestone>> _priorTo;
        public StringEnumValue<PriorToMilestone> PriorTo { get => _priorTo; set => SetField(ref _priorTo, value); }
        private DirtyValue<StringEnumValue<ConditionCategory>> _category;
        public StringEnumValue<ConditionCategory> Category { get => _category; set => SetField(ref _category, value); }
        private DirtyValue<bool?> _isFulfilled;
        public bool? IsFulfilled { get => _isFulfilled; set => SetField(ref _isFulfilled, value); }
        private DirtyValue<DateTime?> _fulfilledDate;
        public DateTime? FulfilledDate { get => _fulfilledDate; set => SetField(ref _fulfilledDate, value); }
        private EntityReference _fulfilledBy;
        public EntityReference FulfilledBy { get => GetField(ref _fulfilledBy); set => SetField(ref _fulfilledBy, value); }
    }
}