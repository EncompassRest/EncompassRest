using System;

namespace EncompassRest.Loans.Conditions
{
    public sealed class UnderwritingCondition : LoanCondition
    {
        private DirtyValue<StringEnumValue<PriorToMilestone>> _priorTo;
        public StringEnumValue<PriorToMilestone> PriorTo { get => _priorTo; set => _priorTo = value; }
        private DirtyValue<StringEnumValue<ConditionCategory>> _category;
        public StringEnumValue<ConditionCategory> Category { get => _category; set => _category = value; }
        private DirtyValue<string> _ownerRole;
        public string OwnerRole { get => _ownerRole; set => _ownerRole = value; }
        private DirtyValue<bool?> _allowToClear;
        public bool? AllowToClear { get => _allowToClear; set => _allowToClear = value; }
        private DirtyValue<bool?> _printExternally;
        public bool? PrintExternally { get => _printExternally; set => _printExternally = value; }
        private DirtyValue<bool?> _printInternally;
        public bool? PrintInternally { get => _printInternally; set => _printInternally = value; }
        private DirtyValue<DateTime?> _expirationDate;
        public DateTime? ExpirationDate { get => _expirationDate; set => _expirationDate = value; }
        private DirtyValue<bool?> _isFulfilled;
        public bool? IsFulfilled { get => _isFulfilled; set => _isFulfilled = value; }
        private DirtyValue<DateTime?> _fulfilledDate;
        public DateTime? FulfilledDate { get => _fulfilledDate; set => _fulfilledDate = value; }
        private EntityReference _fulfilledBy;
        public EntityReference FulfilledBy { get => _fulfilledBy ?? (_fulfilledBy = new EntityReference()); set => _fulfilledBy = value; }
        private DirtyValue<bool?> _isReviewed;
        public bool? IsReviewed { get => _isReviewed; set => _isReviewed = value; }
        private DirtyValue<DateTime?> _reviewedDate;
        public DateTime? ReviewedDate { get => _reviewedDate; set => _reviewedDate = value; }
        private EntityReference _reviewedBy;
        public EntityReference ReviewedBy { get => _reviewedBy ?? (_reviewedBy = new EntityReference()); set => _reviewedBy = value; }
        private DirtyValue<bool?> _isRejected;
        public bool? IsRejected { get => _isRejected; set => _isRejected = value; }
        private DirtyValue<DateTime?> _rejectedDate;
        public DateTime? RejectedDate { get => _rejectedDate; set => _rejectedDate = value; }
        private EntityReference _rejectedBy;
        public EntityReference RejectedBy { get => _rejectedBy ?? (_rejectedBy = new EntityReference()); set => _rejectedBy = value; }
        private DirtyValue<bool?> _isCleared;
        private bool? IsCleared { get => _isCleared; set => _isCleared = value; }
        private DirtyValue<DateTime?> _clearedDate;
        public DateTime? ClearedDate { get => _clearedDate; set => _clearedDate = value; }
        private EntityReference _clearedBy;
        public EntityReference ClearedBy { get => _clearedBy ?? (_clearedBy = new EntityReference()); set => _clearedBy = value; }
        private DirtyValue<bool?> _isWaived;
        public bool? IsWaived { get => _isWaived; set => _isWaived = value; }
        private DirtyValue<DateTime?> _waivedDate;
        public DateTime? WaivedDate { get => _waivedDate; set => _waivedDate = value; }
        private EntityReference _waivedBy;
        public EntityReference WaivedBy { get => _waivedBy ?? (_waivedBy = new EntityReference()); set => _waivedBy = value; }

        internal override bool DirtyInternal
        {
            get => base.DirtyInternal
                || _priorTo.Dirty
                || _category.Dirty
                || _ownerRole.Dirty
                || _allowToClear.Dirty
                || _printExternally.Dirty
                || _printInternally.Dirty
                || _expirationDate.Dirty
                || _isFulfilled.Dirty
                || _fulfilledDate.Dirty
                || _isReviewed.Dirty
                || _reviewedDate.Dirty
                || _isRejected.Dirty
                || _rejectedDate.Dirty
                || _isCleared.Dirty
                || _clearedDate.Dirty
                || _isWaived.Dirty
                || _waivedDate.Dirty
                || _fulfilledBy?.Dirty == true
                || _reviewedBy?.Dirty == true
                || _rejectedBy?.Dirty == true
                || _clearedBy?.Dirty == true
                || _waivedBy?.Dirty == true;
            set
            {
                base.DirtyInternal = value;
                _priorTo.Dirty = value;
                _category.Dirty = value;
                _ownerRole.Dirty = value;
                _allowToClear.Dirty = value;
                _printExternally.Dirty = value;
                _printInternally.Dirty = value;
                _expirationDate.Dirty = value;
                _isFulfilled.Dirty = value;
                _fulfilledDate.Dirty = value;
                _isReviewed.Dirty = value;
                _reviewedDate.Dirty = value;
                _isRejected.Dirty = value;
                _rejectedDate.Dirty = value;
                _isCleared.Dirty = value;
                _clearedDate.Dirty = value;
                _isWaived.Dirty = value;
                _waivedDate.Dirty = value;
                if (_fulfilledBy != null) _fulfilledBy.Dirty = value;
                if (_reviewedBy != null) _reviewedBy.Dirty = value;
                if (_rejectedBy != null) _rejectedBy.Dirty = value;
                if (_clearedBy != null) _clearedBy.Dirty = value;
                if (_waivedBy != null) _waivedBy.Dirty = value;
            }
        }
    }
}