using System;

namespace EncompassRest.Loans
{
    /// <summary>
    /// EscrowInterestTransaction
    /// </summary>
    public sealed partial class EscrowInterestTransaction : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _comments;
        private DirtyValue<string?>? _createdById;
        private DirtyValue<string?>? _createdByName;
        private DirtyValue<DateTime?>? _createdDateTimeUtc;
        private DirtyValue<string?>? _guid;
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _modifiedById;
        private DirtyValue<string?>? _modifiedByName;
        private DirtyValue<DateTime?>? _modifiedDateTimeUtc;
        private DirtyValue<string?>? _servicingPaymentMethod;
        private DirtyValue<string?>? _servicingTransactionType;
        private DirtyValue<decimal?>? _transactionAmount;
        private DirtyValue<DateTime?>? _transactionDate;

        /// <summary>
        /// EscrowInterestTransaction Comments
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// EscrowInterestTransaction CreatedById
        /// </summary>
        public string? CreatedById { get => _createdById; set => SetField(ref _createdById, value); }

        /// <summary>
        /// EscrowInterestTransaction CreatedByName
        /// </summary>
        public string? CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }

        /// <summary>
        /// EscrowInterestTransaction CreatedDateTimeUtc
        /// </summary>
        public DateTime? CreatedDateTimeUtc { get => _createdDateTimeUtc; set => SetField(ref _createdDateTimeUtc, value); }

        /// <summary>
        /// EscrowInterestTransaction Guid
        /// </summary>
        public string? Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// EscrowInterestTransaction Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// EscrowInterestTransaction ModifiedById
        /// </summary>
        public string? ModifiedById { get => _modifiedById; set => SetField(ref _modifiedById, value); }

        /// <summary>
        /// EscrowInterestTransaction ModifiedByName
        /// </summary>
        public string? ModifiedByName { get => _modifiedByName; set => SetField(ref _modifiedByName, value); }

        /// <summary>
        /// EscrowInterestTransaction ModifiedDateTimeUtc
        /// </summary>
        public DateTime? ModifiedDateTimeUtc { get => _modifiedDateTimeUtc; set => SetField(ref _modifiedDateTimeUtc, value); }

        /// <summary>
        /// EscrowInterestTransaction ServicingPaymentMethod
        /// </summary>
        public string? ServicingPaymentMethod { get => _servicingPaymentMethod; set => SetField(ref _servicingPaymentMethod, value); }

        /// <summary>
        /// EscrowInterestTransaction ServicingTransactionType
        /// </summary>
        public string? ServicingTransactionType { get => _servicingTransactionType; set => SetField(ref _servicingTransactionType, value); }

        /// <summary>
        /// EscrowInterestTransaction TransactionAmount
        /// </summary>
        public decimal? TransactionAmount { get => _transactionAmount; set => SetField(ref _transactionAmount, value); }

        /// <summary>
        /// EscrowInterestTransaction TransactionDate
        /// </summary>
        public DateTime? TransactionDate { get => _transactionDate; set => SetField(ref _transactionDate, value); }
    }
}