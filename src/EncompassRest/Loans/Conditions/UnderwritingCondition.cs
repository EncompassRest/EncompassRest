using System;

namespace EncompassRest.Loans.Conditions
{
    /// <summary>
    /// UnderwritingCondition
    /// </summary>
    public sealed class UnderwritingCondition : LoanCondition
    {
        private DirtyValue<StringEnumValue<PriorToMilestone>> _priorTo;
        private DirtyValue<StringEnumValue<ConditionCategory>> _category;
        private DirtyValue<string> _ownerRole;
        private DirtyValue<bool?> _allowToClear;
        private DirtyValue<bool?> _printExternally;
        private DirtyValue<bool?> _printInternally;
        private DirtyValue<DateTime?> _expirationDate;
        private DirtyValue<bool?> _isFulfilled;
        private DirtyValue<DateTime?> _fulfilledDate;
        private DirtyValue<EntityReference> _fulfilledBy;
        private DirtyValue<bool?> _isReviewed;
        private DirtyValue<DateTime?> _reviewedDate;
        private DirtyValue<EntityReference> _reviewedBy;
        private DirtyValue<bool?> _isRejected;
        private DirtyValue<DateTime?> _rejectedDate;
        private DirtyValue<EntityReference> _rejectedBy;
        private DirtyValue<bool?> _isCleared;
        private DirtyValue<DateTime?> _clearedDate;
        private DirtyValue<EntityReference> _clearedBy;
        private DirtyValue<bool?> _isWaived;
        private DirtyValue<DateTime?> _waivedDate;
        private DirtyValue<EntityReference> _waivedBy;

        /// <summary>
        /// The milestones to describe when the condition must be satisfied.
        /// </summary>
        public StringEnumValue<PriorToMilestone> PriorTo { get => _priorTo; set => SetField(ref _priorTo, value); }

        /// <summary>
        /// The condition category.
        /// </summary>
        public StringEnumValue<ConditionCategory> Category { get => _category; set => SetField(ref _category, value); }

        /// <summary>
        /// The role of the Encompass user that owns the condition.
        /// </summary>
        public string OwnerRole { get => _ownerRole; set => SetField(ref _ownerRole, value); }

        /// <summary>
        /// Whether to allow the owner to clear the condition.
        /// </summary>
        public bool? AllowToClear { get => _allowToClear; set => SetField(ref _allowToClear, value); }

        /// <summary>
        /// Whether the document is allowed to be printed externally.
        /// </summary>
        public bool? PrintExternally { get => _printExternally; set => SetField(ref _printExternally, value); }

        /// <summary>
        /// Whether the document is allowed to be printed internally.
        /// </summary>
        public bool? PrintInternally { get => _printInternally; set => SetField(ref _printInternally, value); }

        /// <summary>
        /// Date and time that the condition expires.
        /// </summary>
        public DateTime? ExpirationDate { get => _expirationDate; set => SetField(ref _expirationDate, value); }

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

        /// <summary>
        /// Whether the condition's status is Reviewed.
        /// </summary>
        public bool? IsReviewed { get => _isReviewed; set => SetField(ref _isReviewed, value); }

        /// <summary>
        /// Date and time that the condition is reviewed.
        /// </summary>
        public DateTime? ReviewedDate { get => _reviewedDate; set => SetField(ref _reviewedDate, value); }

        /// <summary>
        /// Information about the Encompass user who reviewed the condition.
        /// </summary>
        public EntityReference ReviewedBy { get => _reviewedBy; set => SetField(ref _reviewedBy, value); }

        /// <summary>
        /// Whether the condition's status is Rejected.
        /// </summary>
        public bool? IsRejected { get => _isRejected; set => SetField(ref _isRejected, value); }

        /// <summary>
        /// Date and time that the condition is rejected.
        /// </summary>
        public DateTime? RejectedDate { get => _rejectedDate; set => SetField(ref _rejectedDate, value); }

        /// <summary>
        /// Information about the Encompass user who rejected the condition.
        /// </summary>
        public EntityReference RejectedBy { get => _rejectedBy; set => SetField(ref _rejectedBy, value); }

        /// <summary>
        /// Whether the condition's status is Cleared.
        /// </summary>
        public bool? IsCleared { get => _isCleared; set => SetField(ref _isCleared, value); }

        /// <summary>
        /// Date and time the condition was cleared.
        /// </summary>
        public DateTime? ClearedDate { get => _clearedDate; set => SetField(ref _clearedDate, value); }

        /// <summary>
        /// Information about the Encompass user who cleared the condition.
        /// </summary>
        public EntityReference ClearedBy { get => _clearedBy; set => SetField(ref _clearedBy, value); }

        /// <summary>
        /// Whether the condition's status is Waived.
        /// </summary>
        public bool? IsWaived { get => _isWaived; set => SetField(ref _isWaived, value); }

        /// <summary>
        /// Date and time the condition was waived.
        /// </summary>
        public DateTime? WaivedDate { get => _waivedDate; set => SetField(ref _waivedDate, value); }

        /// <summary>
        /// Information about the Encompass user who waived the condition.
        /// </summary>
        public EntityReference WaivedBy { get => _waivedBy; set => SetField(ref _waivedBy, value); }
    }
}