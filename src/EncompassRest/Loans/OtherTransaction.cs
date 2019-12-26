using System;

namespace EncompassRest.Loans
{
    /// <summary>
    /// OtherTransaction
    /// </summary>
    public sealed partial class OtherTransaction : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _accountNumber;
        private DirtyValue<string?>? _comments;
        private DirtyValue<string?>? _createdById;
        private DirtyValue<string?>? _createdByName;
        private DirtyValue<DateTime?>? _createdDateTimeUtc;
        private DirtyValue<string?>? _guid;
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _institutionName;
        private DirtyValue<string?>? _institutionRouting;
        private DirtyValue<string?>? _modifiedById;
        private DirtyValue<string?>? _modifiedByName;
        private DirtyValue<DateTime?>? _modifiedDateTimeUtc;
        private DirtyValue<string?>? _reference;
        private DirtyValue<string?>? _servicingPaymentMethod;
        private DirtyValue<string?>? _servicingTransactionType;
        private DirtyValue<decimal?>? _transactionAmount;
        private DirtyValue<DateTime?>? _transactionDate;

        /// <summary>
        /// OtherTransaction AccountNumber
        /// </summary>
        public string? AccountNumber { get => _accountNumber; set => SetField(ref _accountNumber, value); }

        /// <summary>
        /// OtherTransaction Comments
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// OtherTransaction CreatedById
        /// </summary>
        public string? CreatedById { get => _createdById; set => SetField(ref _createdById, value); }

        /// <summary>
        /// OtherTransaction CreatedByName
        /// </summary>
        public string? CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }

        /// <summary>
        /// OtherTransaction CreatedDateTimeUtc
        /// </summary>
        public DateTime? CreatedDateTimeUtc { get => _createdDateTimeUtc; set => SetField(ref _createdDateTimeUtc, value); }

        /// <summary>
        /// OtherTransaction Guid
        /// </summary>
        public string? Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// OtherTransaction Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// OtherTransaction InstitutionName
        /// </summary>
        public string? InstitutionName { get => _institutionName; set => SetField(ref _institutionName, value); }

        /// <summary>
        /// OtherTransaction InstitutionRouting
        /// </summary>
        public string? InstitutionRouting { get => _institutionRouting; set => SetField(ref _institutionRouting, value); }

        /// <summary>
        /// OtherTransaction ModifiedById
        /// </summary>
        public string? ModifiedById { get => _modifiedById; set => SetField(ref _modifiedById, value); }

        /// <summary>
        /// OtherTransaction ModifiedByName
        /// </summary>
        public string? ModifiedByName { get => _modifiedByName; set => SetField(ref _modifiedByName, value); }

        /// <summary>
        /// OtherTransaction ModifiedDateTimeUtc
        /// </summary>
        public DateTime? ModifiedDateTimeUtc { get => _modifiedDateTimeUtc; set => SetField(ref _modifiedDateTimeUtc, value); }

        /// <summary>
        /// OtherTransaction Reference
        /// </summary>
        public string? Reference { get => _reference; set => SetField(ref _reference, value); }

        /// <summary>
        /// OtherTransaction ServicingPaymentMethod
        /// </summary>
        public string? ServicingPaymentMethod { get => _servicingPaymentMethod; set => SetField(ref _servicingPaymentMethod, value); }

        /// <summary>
        /// OtherTransaction ServicingTransactionType
        /// </summary>
        public string? ServicingTransactionType { get => _servicingTransactionType; set => SetField(ref _servicingTransactionType, value); }

        /// <summary>
        /// OtherTransaction TransactionAmount
        /// </summary>
        public decimal? TransactionAmount { get => _transactionAmount; set => SetField(ref _transactionAmount, value); }

        /// <summary>
        /// OtherTransaction TransactionDate
        /// </summary>
        public DateTime? TransactionDate { get => _transactionDate; set => SetField(ref _transactionDate, value); }
    }
}