using System;

namespace EncompassRest.Loans.Conditions.v1
{
    /// <summary>
    /// PostClosingCondition
    /// </summary>
    public sealed class PostClosingCondition : LoanCondition
    {
        private DirtyValue<string?>? _recipient;
        private DirtyValue<bool?>? _isSent;
        private DirtyValue<DateTime?>? _sentDate;
        private DirtyValue<EntityReference?>? _sentBy;
        private DirtyValue<bool?>? _isCleared;
        private DirtyValue<DateTime?>? _clearedDate;
        private DirtyValue<EntityReference?>? _clearedBy;
        private DirtyValue<bool?>? _printExternally;

        /// <summary>
        /// Recipient of the condition.
        /// </summary>
        public string? Recipient { get => _recipient; set => SetField(ref _recipient, value); }

        /// <summary>
        /// A value of <c>true</c> indicates the condition has been sent.
        /// </summary>
        public bool? IsSent { get => _isSent; set => SetField(ref _isSent, value); }

        /// <summary>
        /// Date and time the condition was sent.
        /// </summary>
        public DateTime? SentDate { get => _sentDate; set => SetField(ref _sentDate, value); }

        /// <summary>
        /// User that sent the condition.
        /// </summary>
        public EntityReference? SentBy { get => _sentBy; set => SetField(ref _sentBy, value); }

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
        public EntityReference? ClearedBy { get => _clearedBy; set => SetField(ref _clearedBy, value); }

        /// <summary>
        /// PostClosingCondition PrintExternally
        /// </summary>
        public bool? PrintExternally { get => _printExternally; set => SetField(ref _printExternally, value); }
    }
}