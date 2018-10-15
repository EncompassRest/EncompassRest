using System;

namespace EncompassRest.Loans.Conditions
{
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
        private EntityReference _fulfilledBy;
        private DirtyValue<bool?> _isReviewed;
        private DirtyValue<DateTime?> _reviewedDate;
        private EntityReference _reviewedBy;
        private DirtyValue<bool?> _isRejected;
        private DirtyValue<DateTime?> _rejectedDate;
        private EntityReference _rejectedBy;
        private DirtyValue<bool?> _isCleared;
        private DirtyValue<DateTime?> _clearedDate;
        private EntityReference _clearedBy;
        private DirtyValue<bool?> _isWaived;
        private DirtyValue<DateTime?> _waivedDate;
        private EntityReference _waivedBy;

        public StringEnumValue<PriorToMilestone> PriorTo { get => _priorTo; set => SetField(ref _priorTo, value); }

        public StringEnumValue<ConditionCategory> Category { get => _category; set => SetField(ref _category, value); }

        public string OwnerRole { get => _ownerRole; set => SetField(ref _ownerRole, value); }

        public bool? AllowToClear { get => _allowToClear; set => SetField(ref _allowToClear, value); }

        public bool? PrintExternally { get => _printExternally; set => SetField(ref _printExternally, value); }

        public bool? PrintInternally { get => _printInternally; set => SetField(ref _printInternally, value); }

        public DateTime? ExpirationDate { get => _expirationDate; set => SetField(ref _expirationDate, value); }

        public bool? IsFulfilled { get => _isFulfilled; set => SetField(ref _isFulfilled, value); }

        public DateTime? FulfilledDate { get => _fulfilledDate; set => SetField(ref _fulfilledDate, value); }

        public EntityReference FulfilledBy { get => GetField(ref _fulfilledBy); set => SetField(ref _fulfilledBy, value); }

        public bool? IsReviewed { get => _isReviewed; set => SetField(ref _isReviewed, value); }

        public DateTime? ReviewedDate { get => _reviewedDate; set => SetField(ref _reviewedDate, value); }

        public EntityReference ReviewedBy { get => GetField(ref _reviewedBy); set => SetField(ref _reviewedBy, value); }

        public bool? IsRejected { get => _isRejected; set => SetField(ref _isRejected, value); }

        public DateTime? RejectedDate { get => _rejectedDate; set => SetField(ref _rejectedDate, value); }

        public EntityReference RejectedBy { get => GetField(ref _rejectedBy); set => SetField(ref _rejectedBy, value); }

        private bool? IsCleared { get => _isCleared; set => SetField(ref _isCleared, value); }

        public DateTime? ClearedDate { get => _clearedDate; set => SetField(ref _clearedDate, value); }

        public EntityReference ClearedBy { get => GetField(ref _clearedBy); set => SetField(ref _clearedBy, value); }

        public bool? IsWaived { get => _isWaived; set => SetField(ref _isWaived, value); }

        public DateTime? WaivedDate { get => _waivedDate; set => SetField(ref _waivedDate, value); }

        public EntityReference WaivedBy { get => GetField(ref _waivedBy); set => SetField(ref _waivedBy, value); }
    }
}