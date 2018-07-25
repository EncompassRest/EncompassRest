using System;

namespace EncompassRest.Loans.Conditions
{
    public sealed class PostClosingCondition : LoanCondition
    {
        private DirtyValue<string> _recipient;
        public string Recipient { get => _recipient; set => _recipient = value; }
        private DirtyValue<bool?> _isSent;
        public bool? IsSent { get => _isSent; set => _isSent = value; }
        private DirtyValue<DateTime?> _sentDate;
        public DateTime? SentDate { get => _sentDate; set => _sentDate = value; }
        private EntityReference _sentBy;
        public EntityReference SentBy { get => _sentBy ?? (_sentBy = new EntityReference()); set => _sentBy = value; }
        private DirtyValue<bool?> _isCleared;
        private bool? IsCleared { get => _isCleared; set => _isCleared = value; }
        private DirtyValue<DateTime?> _clearedDate;
        public DateTime? ClearedDate { get => _clearedDate; set => _clearedDate = value; }
        private EntityReference _clearedBy;
        public EntityReference ClearedBy { get => _clearedBy ?? (_clearedBy = new EntityReference()); set => _clearedBy = value; }

        internal override bool DirtyInternal
        {
            get => base.DirtyInternal
                || _recipient.Dirty
                || _isSent.Dirty
                || _sentDate.Dirty
                || _isCleared.Dirty
                || _clearedDate.Dirty
                || _sentBy?.Dirty == true
                || _clearedBy?.Dirty == true;
            set => base.DirtyInternal = value;
        }
    }
}