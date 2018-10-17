using System;

namespace EncompassRest.Loans.Conditions
{
    public sealed class PostClosingCondition : LoanCondition
    {
        private DirtyValue<string> _recipient;
        private DirtyValue<bool?> _isSent;
        private DirtyValue<DateTime?> _sentDate;
        private EntityReference _sentBy;
        private DirtyValue<bool?> _isCleared;
        private DirtyValue<DateTime?> _clearedDate;
        private EntityReference _clearedBy;

        public string Recipient { get => _recipient; set => SetField(ref _recipient, value); }

        public bool? IsSent { get => _isSent; set => SetField(ref _isSent, value); }

        public DateTime? SentDate { get => _sentDate; set => SetField(ref _sentDate, value); }

        public EntityReference SentBy { get => GetField(ref _sentBy); set => SetField(ref _sentBy, value); }

        private bool? IsCleared { get => _isCleared; set => SetField(ref _isCleared, value); }

        public DateTime? ClearedDate { get => _clearedDate; set => SetField(ref _clearedDate, value); }

        public EntityReference ClearedBy { get => GetField(ref _clearedBy); set => SetField(ref _clearedBy, value); }
    }
}