using System;

namespace EncompassRest.Loans.Conditions
{
    public sealed class UnderwritingCondition : LoanCondition
    {
        private DirtyValue<StringEnumValue<PriorToMilestone>> _priorTo;
        public StringEnumValue<PriorToMilestone> PriorTo { get => _priorTo; set => SetField(ref _priorTo, value); }
        private DirtyValue<StringEnumValue<ConditionCategory>> _category;
        public StringEnumValue<ConditionCategory> Category { get => _category; set => SetField(ref _category, value); }
        private DirtyValue<string> _ownerRole;
        public string OwnerRole { get => _ownerRole; set => SetField(ref _ownerRole, value); }
        private DirtyValue<bool?> _allowToClear;
        public bool? AllowToClear { get => _allowToClear; set => SetField(ref _allowToClear, value); }
        private DirtyValue<bool?> _printExternally;
        public bool? PrintExternally { get => _printExternally; set => SetField(ref _printExternally, value); }
        private DirtyValue<bool?> _printInternally;
        public bool? PrintInternally { get => _printInternally; set => SetField(ref _printInternally, value); }
        private DirtyValue<DateTime?> _expirationDate;
        public DateTime? ExpirationDate { get => _expirationDate; set => SetField(ref _expirationDate, value); }
        private DirtyValue<bool?> _isFulfilled;
        public bool? IsFulfilled { get => _isFulfilled; set => SetField(ref _isFulfilled, value); }
        private DirtyValue<DateTime?> _fulfilledDate;
        public DateTime? FulfilledDate { get => _fulfilledDate; set => SetField(ref _fulfilledDate, value); }
        private EntityReference _fulfilledBy;
        public EntityReference FulfilledBy { get => GetField(ref _fulfilledBy); set => SetField(ref _fulfilledBy, value); }
        private DirtyValue<bool?> _isReviewed;
        public bool? IsReviewed { get => _isReviewed; set => SetField(ref _isReviewed, value); }
        private DirtyValue<DateTime?> _reviewedDate;
        public DateTime? ReviewedDate { get => _reviewedDate; set => SetField(ref _reviewedDate, value); }
        private EntityReference _reviewedBy;
        public EntityReference ReviewedBy { get => GetField(ref _reviewedBy); set => SetField(ref _reviewedBy, value); }
        private DirtyValue<bool?> _isRejected;
        public bool? IsRejected { get => _isRejected; set => SetField(ref _isRejected, value); }
        private DirtyValue<DateTime?> _rejectedDate;
        public DateTime? RejectedDate { get => _rejectedDate; set => SetField(ref _rejectedDate, value); }
        private EntityReference _rejectedBy;
        public EntityReference RejectedBy { get => GetField(ref _rejectedBy); set => SetField(ref _rejectedBy, value); }
        private DirtyValue<bool?> _isCleared;
        private bool? IsCleared { get => _isCleared; set => SetField(ref _isCleared, value); }
        private DirtyValue<DateTime?> _clearedDate;
        public DateTime? ClearedDate { get => _clearedDate; set => SetField(ref _clearedDate, value); }
        private EntityReference _clearedBy;
        public EntityReference ClearedBy { get => GetField(ref _clearedBy); set => SetField(ref _clearedBy, value); }
        private DirtyValue<bool?> _isWaived;
        public bool? IsWaived { get => _isWaived; set => SetField(ref _isWaived, value); }
        private DirtyValue<DateTime?> _waivedDate;
        public DateTime? WaivedDate { get => _waivedDate; set => SetField(ref _waivedDate, value); }
        private EntityReference _waivedBy;
        public EntityReference WaivedBy { get => GetField(ref _waivedBy); set => SetField(ref _waivedBy, value); }
    }
}