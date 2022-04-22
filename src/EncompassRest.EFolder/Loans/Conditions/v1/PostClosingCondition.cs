using System;

namespace EncompassRest.Loans.Conditions.v1
{
    /// <summary>
    /// PostClosingCondition
    /// </summary>
    public sealed class PostClosingCondition : LoanCondition
    {
        /// <summary>
        /// Recipient of the condition.
        /// </summary>
        public string? Recipient { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// A value of <c>true</c> indicates the condition has been sent.
        /// </summary>
        public bool? IsSent { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Date and time the condition was sent.
        /// </summary>
        public DateTime? SentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// User that sent the condition.
        /// </summary>
        public EntityReference? SentBy { get => GetValue<EntityReference?>(); set => SetValue(value); }

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
        /// PostClosingCondition PrintExternally
        /// </summary>
        public bool? PrintExternally { get => GetValue<bool?>(); set => SetValue(value); }
    }
}