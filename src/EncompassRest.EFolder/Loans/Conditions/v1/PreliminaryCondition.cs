using System;

namespace EncompassRest.Loans.Conditions.v1
{
    /// <summary>
    /// PreliminaryCondition
    /// </summary>
    public sealed class PreliminaryCondition : LoanCondition
    {
        /// <summary>
        /// A value of <c>true</c> indicates that underwriting has access to this condition.
        /// </summary>
        public bool? UWAccess { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// The milestones to describe when the condition must be satisfied.
        /// </summary>
        public StringEnumValue<PriorToMilestone> PriorTo { get => GetValue<StringEnumValue<PriorToMilestone>>(); set => SetValue(value); }

        /// <summary>
        /// The condition category.
        /// </summary>
        public StringEnumValue<ConditionCategory> Category { get => GetValue<StringEnumValue<ConditionCategory>>(); set => SetValue(value); }

        /// <summary>
        /// Whether the condition's status is fulfilled.
        /// </summary>
        public bool? IsFulfilled { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Date and time that the condition is fulfilled.
        /// </summary>
        public DateTime? FulfilledDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Information about the Encompass user who fulfilled the condition.
        /// </summary>
        public EntityReference? FulfilledBy { get => GetValue<EntityReference?>(); set => SetValue(value); }
    }
}