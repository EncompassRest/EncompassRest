using System;

namespace EncompassRest.Loans.Conditions.v1
{
    /// <summary>
    /// UnderwritingCondition
    /// </summary>
    public sealed class UnderwritingCondition : LoanCondition
    {
        /// <summary>
        /// The milestones to describe when the condition must be satisfied.
        /// </summary>
        public StringEnumValue<PriorToMilestone> PriorTo { get => GetValue<StringEnumValue<PriorToMilestone>>(); set => SetValue(value); }

        /// <summary>
        /// The condition category.
        /// </summary>
        public StringEnumValue<ConditionCategory> Category { get => GetValue<StringEnumValue<ConditionCategory>>(); set => SetValue(value); }

        /// <summary>
        /// The role of the Encompass user that owns the condition.
        /// </summary>
        public EntityReference? OwnerRole { get => GetValue<EntityReference?>(); set => SetValue(value); }

        /// <summary>
        /// Whether to allow the owner to clear the condition.
        /// </summary>
        public bool? AllowToClear { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Whether the document is allowed to be printed externally.
        /// </summary>
        public bool? PrintExternally { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Whether the document is allowed to be printed internally.
        /// </summary>
        public bool? PrintInternally { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Date and time that the condition expires.
        /// </summary>
        public DateTime? ExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

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

        /// <summary>
        /// Whether the condition's status is Reviewed.
        /// </summary>
        public bool? IsReviewed { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Date and time that the condition is reviewed.
        /// </summary>
        public DateTime? ReviewedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Information about the Encompass user who reviewed the condition.
        /// </summary>
        public EntityReference? ReviewedBy { get => GetValue<EntityReference?>(); set => SetValue(value); }

        /// <summary>
        /// Whether the condition's status is Rejected.
        /// </summary>
        public bool? IsRejected { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Date and time that the condition is rejected.
        /// </summary>
        public DateTime? RejectedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Information about the Encompass user who rejected the condition.
        /// </summary>
        public EntityReference? RejectedBy { get => GetValue<EntityReference?>(); set => SetValue(value); }

        /// <summary>
        /// Whether the condition's status is Cleared.
        /// </summary>
        public bool? IsCleared { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Date and time the condition was cleared.
        /// </summary>
        public DateTime? ClearedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Information about the Encompass user who cleared the condition.
        /// </summary>
        public EntityReference? ClearedBy { get => GetValue<EntityReference?>(); set => SetValue(value); }

        /// <summary>
        /// Whether the condition's status is Waived.
        /// </summary>
        public bool? IsWaived { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Date and time the condition was waived.
        /// </summary>
        public DateTime? WaivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Information about the Encompass user who waived the condition.
        /// </summary>
        public EntityReference? WaivedBy { get => GetValue<EntityReference?>(); set => SetValue(value); }
    }
}