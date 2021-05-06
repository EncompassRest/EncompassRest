using System;

namespace EncompassRest.Loans.Conditions.v1
{
    /// <summary>
    /// PreliminaryCondition
    /// </summary>
    public sealed class PreliminaryCondition : LoanCondition
    {
        private DirtyValue<bool?>? _uwAccess;
        private DirtyValue<StringEnumValue<PriorToMilestone>>? _priorTo;
        private DirtyValue<StringEnumValue<ConditionCategory>>? _category;
        private DirtyValue<bool?>? _isFulfilled;
        private DirtyValue<DateTime?>? _fulfilledDate;
        private DirtyValue<EntityReference>? _fulfilledBy;

        /// <summary>
        /// A value of <c>true</c> indicates that underwriting has access to this condition.
        /// </summary>
        public bool? UWAccess { get => _uwAccess; set => SetField(ref _uwAccess, value); }

        /// <summary>
        /// The milestones to describe when the condition must be satisfied.
        /// </summary>
        public StringEnumValue<PriorToMilestone> PriorTo { get => _priorTo; set => SetField(ref _priorTo, value); }

        /// <summary>
        /// The condition category.
        /// </summary>
        public StringEnumValue<ConditionCategory> Category { get => _category; set => SetField(ref _category, value); }

        /// <summary>
        /// Whether the condition's status is fulfilled.
        /// </summary>
        public bool? IsFulfilled { get => _isFulfilled; set => SetField(ref _isFulfilled, value); }

        /// <summary>
        /// Date and time that the condition is fulfilled.
        /// </summary>
        public DateTime? FulfilledDate { get => _fulfilledDate; set => SetField(ref _fulfilledDate, value); }

        /// <summary>
        /// Information about the Encompass user who fulfilled the condition.
        /// </summary>
        public EntityReference FulfilledBy { get => _fulfilledBy; set => SetField(ref _fulfilledBy, value); }
    }
}