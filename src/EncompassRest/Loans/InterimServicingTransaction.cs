using System;

namespace EncompassRest.Loans
{
    /// <summary>
    /// InterimServicingTransaction
    /// </summary>
    public sealed partial class InterimServicingTransaction : DirtyExtensibleObject, IIdentifiable
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
        /// InterimServicingTransaction Comments
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// InterimServicingTransaction CreatedById
        /// </summary>
        public string? CreatedById { get => _createdById; set => SetField(ref _createdById, value); }

        /// <summary>
        /// InterimServicingTransaction CreatedByName
        /// </summary>
        public string? CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }

        /// <summary>
        /// InterimServicingTransaction CreatedDateTimeUtc
        /// </summary>
        public DateTime? CreatedDateTimeUtc { get => _createdDateTimeUtc; set => SetField(ref _createdDateTimeUtc, value); }

        /// <summary>
        /// InterimServicingTransaction Guid
        /// </summary>
        public string? Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// InterimServicingTransaction Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// InterimServicingTransaction ModifiedById
        /// </summary>
        public string? ModifiedById { get => _modifiedById; set => SetField(ref _modifiedById, value); }

        /// <summary>
        /// InterimServicingTransaction ModifiedByName
        /// </summary>
        public string? ModifiedByName { get => _modifiedByName; set => SetField(ref _modifiedByName, value); }

        /// <summary>
        /// InterimServicingTransaction ModifiedDateTimeUtc
        /// </summary>
        public DateTime? ModifiedDateTimeUtc { get => _modifiedDateTimeUtc; set => SetField(ref _modifiedDateTimeUtc, value); }

        /// <summary>
        /// InterimServicingTransaction ServicingPaymentMethod
        /// </summary>
        public string? ServicingPaymentMethod { get => _servicingPaymentMethod; set => SetField(ref _servicingPaymentMethod, value); }

        /// <summary>
        /// InterimServicingTransaction ServicingTransactionType
        /// </summary>
        public string? ServicingTransactionType { get => _servicingTransactionType; set => SetField(ref _servicingTransactionType, value); }

        /// <summary>
        /// InterimServicingTransaction TransactionAmount
        /// </summary>
        public decimal? TransactionAmount { get => _transactionAmount; set => SetField(ref _transactionAmount, value); }

        /// <summary>
        /// InterimServicingTransaction TransactionDate
        /// </summary>
        public DateTime? TransactionDate { get => _transactionDate; set => SetField(ref _transactionDate, value); }
    }
}