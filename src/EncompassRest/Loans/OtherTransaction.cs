using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// OtherTransaction
    /// </summary>
    public sealed partial class OtherTransaction : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _accountNumber;
        /// <summary>
        /// OtherTransaction AccountNumber
        /// </summary>
        public string AccountNumber { get => _accountNumber; set => SetField(ref _accountNumber, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// OtherTransaction Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<string> _createdById;
        /// <summary>
        /// OtherTransaction CreatedById
        /// </summary>
        public string CreatedById { get => _createdById; set => SetField(ref _createdById, value); }
        private DirtyValue<string> _createdByName;
        /// <summary>
        /// OtherTransaction CreatedByName
        /// </summary>
        public string CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }
        private DirtyValue<DateTime?> _createdDateTimeUtc;
        /// <summary>
        /// OtherTransaction CreatedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CreatedDateTimeUtc { get => _createdDateTimeUtc; set => SetField(ref _createdDateTimeUtc, value); }
        private DirtyValue<string> _guid;
        /// <summary>
        /// OtherTransaction Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// OtherTransaction Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _institutionName;
        /// <summary>
        /// OtherTransaction InstitutionName
        /// </summary>
        public string InstitutionName { get => _institutionName; set => SetField(ref _institutionName, value); }
        private DirtyValue<string> _institutionRouting;
        /// <summary>
        /// OtherTransaction InstitutionRouting
        /// </summary>
        public string InstitutionRouting { get => _institutionRouting; set => SetField(ref _institutionRouting, value); }
        private DirtyValue<string> _modifiedById;
        /// <summary>
        /// OtherTransaction ModifiedById
        /// </summary>
        public string ModifiedById { get => _modifiedById; set => SetField(ref _modifiedById, value); }
        private DirtyValue<string> _modifiedByName;
        /// <summary>
        /// OtherTransaction ModifiedByName
        /// </summary>
        public string ModifiedByName { get => _modifiedByName; set => SetField(ref _modifiedByName, value); }
        private DirtyValue<DateTime?> _modifiedDateTimeUtc;
        /// <summary>
        /// OtherTransaction ModifiedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ModifiedDateTimeUtc { get => _modifiedDateTimeUtc; set => SetField(ref _modifiedDateTimeUtc, value); }
        private DirtyValue<string> _reference;
        /// <summary>
        /// OtherTransaction Reference
        /// </summary>
        public string Reference { get => _reference; set => SetField(ref _reference, value); }
        private DirtyValue<string> _servicingPaymentMethod;
        /// <summary>
        /// OtherTransaction ServicingPaymentMethod
        /// </summary>
        public string ServicingPaymentMethod { get => _servicingPaymentMethod; set => SetField(ref _servicingPaymentMethod, value); }
        private DirtyValue<string> _servicingTransactionType;
        /// <summary>
        /// OtherTransaction ServicingTransactionType
        /// </summary>
        public string ServicingTransactionType { get => _servicingTransactionType; set => SetField(ref _servicingTransactionType, value); }
        private DirtyValue<decimal?> _transactionAmount;
        /// <summary>
        /// OtherTransaction TransactionAmount
        /// </summary>
        public decimal? TransactionAmount { get => _transactionAmount; set => SetField(ref _transactionAmount, value); }
        private DirtyValue<DateTime?> _transactionDate;
        /// <summary>
        /// OtherTransaction TransactionDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? TransactionDate { get => _transactionDate; set => SetField(ref _transactionDate, value); }
    }
}