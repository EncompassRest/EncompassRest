using System;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// EscrowDisbursementTransaction
    /// </summary>
    public sealed partial class EscrowDisbursementTransaction : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _comments;
        private DirtyValue<string?>? _createdById;
        private DirtyValue<string?>? _createdByName;
        private DirtyValue<DateTime?>? _createdDateTimeUtc;
        private DirtyValue<DateTime?>? _disbursementDueDate;
        private DirtyValue<int?>? _disbursementNumber;
        private DirtyValue<string?>? _disbursementType;
        private DirtyValue<string?>? _guid;
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _institutionName;
        private DirtyValue<string?>? _modifiedById;
        private DirtyValue<string?>? _modifiedByName;
        private DirtyValue<DateTime?>? _modifiedDateTimeUtc;
        private DirtyValue<string?>? _servicingPaymentMethod;
        private DirtyValue<string?>? _servicingTransactionType;
        private DirtyValue<decimal?>? _transactionAmount;
        private DirtyValue<DateTime?>? _transactionDate;

        /// <summary>
        /// EscrowDisbursementTransaction Comments
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// EscrowDisbursementTransaction CreatedById
        /// </summary>
        public string? CreatedById { get => _createdById; set => SetField(ref _createdById, value); }

        /// <summary>
        /// EscrowDisbursementTransaction CreatedByName
        /// </summary>
        public string? CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }

        /// <summary>
        /// EscrowDisbursementTransaction CreatedDateTimeUtc
        /// </summary>
        public DateTime? CreatedDateTimeUtc { get => _createdDateTimeUtc; set => SetField(ref _createdDateTimeUtc, value); }

        /// <summary>
        /// EscrowDisbursementTransaction DisbursementDueDate
        /// </summary>
        public DateTime? DisbursementDueDate { get => _disbursementDueDate; set => SetField(ref _disbursementDueDate, value); }

        /// <summary>
        /// EscrowDisbursementTransaction DisbursementNumber
        /// </summary>
        public int? DisbursementNumber { get => _disbursementNumber; set => SetField(ref _disbursementNumber, value); }

        /// <summary>
        /// EscrowDisbursementTransaction DisbursementType
        /// </summary>
        public string? DisbursementType { get => _disbursementType; set => SetField(ref _disbursementType, value); }

        /// <summary>
        /// EscrowDisbursementTransaction Guid
        /// </summary>
        public string? Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// EscrowDisbursementTransaction Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// EscrowDisbursementTransaction InstitutionName
        /// </summary>
        public string? InstitutionName { get => _institutionName; set => SetField(ref _institutionName, value); }

        /// <summary>
        /// EscrowDisbursementTransaction ModifiedById
        /// </summary>
        public string? ModifiedById { get => _modifiedById; set => SetField(ref _modifiedById, value); }

        /// <summary>
        /// EscrowDisbursementTransaction ModifiedByName
        /// </summary>
        public string? ModifiedByName { get => _modifiedByName; set => SetField(ref _modifiedByName, value); }

        /// <summary>
        /// EscrowDisbursementTransaction ModifiedDateTimeUtc
        /// </summary>
        public DateTime? ModifiedDateTimeUtc { get => _modifiedDateTimeUtc; set => SetField(ref _modifiedDateTimeUtc, value); }

        /// <summary>
        /// EscrowDisbursementTransaction ServicingPaymentMethod
        /// </summary>
        public string? ServicingPaymentMethod { get => _servicingPaymentMethod; set => SetField(ref _servicingPaymentMethod, value); }

        /// <summary>
        /// EscrowDisbursementTransaction ServicingTransactionType
        /// </summary>
        public string? ServicingTransactionType { get => _servicingTransactionType; set => SetField(ref _servicingTransactionType, value); }

        /// <summary>
        /// EscrowDisbursementTransaction TransactionAmount
        /// </summary>
        public decimal? TransactionAmount { get => _transactionAmount; set => SetField(ref _transactionAmount, value); }

        /// <summary>
        /// EscrowDisbursementTransaction TransactionDate
        /// </summary>
        public DateTime? TransactionDate { get => _transactionDate; set => SetField(ref _transactionDate, value); }
    }
}