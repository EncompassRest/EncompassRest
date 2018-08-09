using System;

namespace EncompassRest.Loans.Conditions
{
    public sealed class PreliminaryCondition : LoanCondition
    {
        private DirtyValue<bool?> _uwAccess;
        public bool? UWAccess { get => _uwAccess; set => _uwAccess = value; }
        private DirtyValue<StringEnumValue<PriorToMilestone>> _priorTo;
        public StringEnumValue<PriorToMilestone> PriorTo { get => _priorTo; set => _priorTo = value; }
        private DirtyValue<StringEnumValue<ConditionCategory>> _category;
        public StringEnumValue<ConditionCategory> Category { get => _category; set => _category = value; }
        private DirtyValue<bool?> _isFulfilled;
        public bool? IsFulfilled { get => _isFulfilled; set => _isFulfilled = value; }
        private DirtyValue<DateTime?> _fulfilledDate;
        public DateTime? FulfilledDate { get => _fulfilledDate; set => _fulfilledDate = value; }
        private EntityReference _fulfilledBy;
        public EntityReference FulfilledBy { get => _fulfilledBy ?? (_fulfilledBy = new EntityReference()); set => _fulfilledBy = value; }
    }
}