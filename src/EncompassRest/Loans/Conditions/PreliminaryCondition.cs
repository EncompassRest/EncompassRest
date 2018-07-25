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

        internal override bool DirtyInternal
        {
            get => base.DirtyInternal
                || _uwAccess.Dirty
                || _priorTo.Dirty
                || _category.Dirty
                || _isFulfilled.Dirty
                || _fulfilledDate.Dirty
                || _fulfilledBy?.Dirty == true;
            set
            {
                base.DirtyInternal = value;
                _uwAccess.Dirty = value;
                _priorTo.Dirty = value;
                _category.Dirty = value;
                _isFulfilled.Dirty = value;
                _fulfilledDate.Dirty = value;
                if (_fulfilledBy != null) _fulfilledBy.Dirty = value;
            }
        }
    }
}