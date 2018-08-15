using System;

namespace EncompassRest.Loans.Conditions
{
    public sealed class PostClosingCondition : LoanCondition
    {
        private DirtyValue<string> _recipient;
        public string Recipient { get => _recipient; set => SetField(ref _recipient, value); }
        private DirtyValue<bool?> _isSent;
        public bool? IsSent { get => _isSent; set => SetField(ref _isSent, value); }
        private DirtyValue<DateTime?> _sentDate;
        public DateTime? SentDate { get => _sentDate; set => SetField(ref _sentDate, value); }
        private EntityReference _sentBy;
        public EntityReference SentBy { get => GetField(ref _sentBy); set => SetField(ref _sentBy, value); }
        private DirtyValue<bool?> _isCleared;
        private bool? IsCleared { get => _isCleared; set => SetField(ref _isCleared, value); }
        private DirtyValue<DateTime?> _clearedDate;
        public DateTime? ClearedDate { get => _clearedDate; set => SetField(ref _clearedDate, value); }
        private EntityReference _clearedBy;
        public EntityReference ClearedBy { get => GetField(ref _clearedBy); set => SetField(ref _clearedBy, value); }
    }
}