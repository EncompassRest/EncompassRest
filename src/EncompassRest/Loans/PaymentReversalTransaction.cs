using System;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PaymentReversalTransaction
    /// </summary>
    public sealed partial class PaymentReversalTransaction : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _comments;
        private DirtyValue<string> _createdById;
        private DirtyValue<string> _createdByName;
        private DirtyValue<DateTime?> _createdDateTimeUtc;
        private DirtyValue<string> _guid;
        private DirtyValue<string> _id;
        private DirtyValue<string> _modifiedById;
        private DirtyValue<string> _modifiedByName;
        private DirtyValue<DateTime?> _modifiedDateTimeUtc;
        private DirtyValue<string> _paymentId;
        private DirtyValue<string> _reversalType;
        private DirtyValue<string> _servicingPaymentMethod;
        private DirtyValue<string> _servicingTransactionType;
        private DirtyValue<decimal?> _transactionAmount;
        private DirtyValue<DateTime?> _transactionDate;

        /// <summary>
        /// PaymentReversalTransaction Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// PaymentReversalTransaction CreatedById
        /// </summary>
        public string CreatedById { get => _createdById; set => SetField(ref _createdById, value); }

        /// <summary>
        /// PaymentReversalTransaction CreatedByName
        /// </summary>
        public string CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }

        /// <summary>
        /// PaymentReversalTransaction CreatedDateTimeUtc
        /// </summary>
        public DateTime? CreatedDateTimeUtc { get => _createdDateTimeUtc; set => SetField(ref _createdDateTimeUtc, value); }

        /// <summary>
        /// PaymentReversalTransaction Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// PaymentReversalTransaction Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// PaymentReversalTransaction ModifiedById
        /// </summary>
        public string ModifiedById { get => _modifiedById; set => SetField(ref _modifiedById, value); }

        /// <summary>
        /// PaymentReversalTransaction ModifiedByName
        /// </summary>
        public string ModifiedByName { get => _modifiedByName; set => SetField(ref _modifiedByName, value); }

        /// <summary>
        /// PaymentReversalTransaction ModifiedDateTimeUtc
        /// </summary>
        public DateTime? ModifiedDateTimeUtc { get => _modifiedDateTimeUtc; set => SetField(ref _modifiedDateTimeUtc, value); }

        /// <summary>
        /// PaymentReversalTransaction PaymentId
        /// </summary>
        public string PaymentId { get => _paymentId; set => SetField(ref _paymentId, value); }

        /// <summary>
        /// PaymentReversalTransaction ReversalType
        /// </summary>
        public string ReversalType { get => _reversalType; set => SetField(ref _reversalType, value); }

        /// <summary>
        /// PaymentReversalTransaction ServicingPaymentMethod
        /// </summary>
        public string ServicingPaymentMethod { get => _servicingPaymentMethod; set => SetField(ref _servicingPaymentMethod, value); }

        /// <summary>
        /// PaymentReversalTransaction ServicingTransactionType
        /// </summary>
        public string ServicingTransactionType { get => _servicingTransactionType; set => SetField(ref _servicingTransactionType, value); }

        /// <summary>
        /// PaymentReversalTransaction TransactionAmount
        /// </summary>
        public decimal? TransactionAmount { get => _transactionAmount; set => SetField(ref _transactionAmount, value); }

        /// <summary>
        /// PaymentReversalTransaction TransactionDate
        /// </summary>
        public DateTime? TransactionDate { get => _transactionDate; set => SetField(ref _transactionDate, value); }
    }
}