using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// EscrowDisbursementTransaction
    /// </summary>
    public sealed partial class EscrowDisbursementTransaction : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _comments;
        /// <summary>
        /// EscrowDisbursementTransaction Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<string> _createdById;
        /// <summary>
        /// EscrowDisbursementTransaction CreatedById
        /// </summary>
        public string CreatedById { get => _createdById; set => SetField(ref _createdById, value); }
        private DirtyValue<string> _createdByName;
        /// <summary>
        /// EscrowDisbursementTransaction CreatedByName
        /// </summary>
        public string CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }
        private DirtyValue<DateTime?> _createdDateTimeUtc;
        /// <summary>
        /// EscrowDisbursementTransaction CreatedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CreatedDateTimeUtc { get => _createdDateTimeUtc; set => SetField(ref _createdDateTimeUtc, value); }
        private DirtyValue<DateTime?> _disbursementDueDate;
        /// <summary>
        /// EscrowDisbursementTransaction DisbursementDueDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DisbursementDueDate { get => _disbursementDueDate; set => SetField(ref _disbursementDueDate, value); }
        private DirtyValue<int?> _disbursementNumber;
        /// <summary>
        /// EscrowDisbursementTransaction DisbursementNumber
        /// </summary>
        public int? DisbursementNumber { get => _disbursementNumber; set => SetField(ref _disbursementNumber, value); }
        private DirtyValue<string> _disbursementType;
        /// <summary>
        /// EscrowDisbursementTransaction DisbursementType
        /// </summary>
        public string DisbursementType { get => _disbursementType; set => SetField(ref _disbursementType, value); }
        private DirtyValue<string> _guid;
        /// <summary>
        /// EscrowDisbursementTransaction Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// EscrowDisbursementTransaction Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _institutionName;
        /// <summary>
        /// EscrowDisbursementTransaction InstitutionName
        /// </summary>
        public string InstitutionName { get => _institutionName; set => SetField(ref _institutionName, value); }
        private DirtyValue<string> _modifiedById;
        /// <summary>
        /// EscrowDisbursementTransaction ModifiedById
        /// </summary>
        public string ModifiedById { get => _modifiedById; set => SetField(ref _modifiedById, value); }
        private DirtyValue<string> _modifiedByName;
        /// <summary>
        /// EscrowDisbursementTransaction ModifiedByName
        /// </summary>
        public string ModifiedByName { get => _modifiedByName; set => SetField(ref _modifiedByName, value); }
        private DirtyValue<DateTime?> _modifiedDateTimeUtc;
        /// <summary>
        /// EscrowDisbursementTransaction ModifiedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ModifiedDateTimeUtc { get => _modifiedDateTimeUtc; set => SetField(ref _modifiedDateTimeUtc, value); }
        private DirtyValue<string> _servicingPaymentMethod;
        /// <summary>
        /// EscrowDisbursementTransaction ServicingPaymentMethod
        /// </summary>
        public string ServicingPaymentMethod { get => _servicingPaymentMethod; set => SetField(ref _servicingPaymentMethod, value); }
        private DirtyValue<string> _servicingTransactionType;
        /// <summary>
        /// EscrowDisbursementTransaction ServicingTransactionType
        /// </summary>
        public string ServicingTransactionType { get => _servicingTransactionType; set => SetField(ref _servicingTransactionType, value); }
        private DirtyValue<decimal?> _transactionAmount;
        /// <summary>
        /// EscrowDisbursementTransaction TransactionAmount
        /// </summary>
        public decimal? TransactionAmount { get => _transactionAmount; set => SetField(ref _transactionAmount, value); }
        private DirtyValue<DateTime?> _transactionDate;
        /// <summary>
        /// EscrowDisbursementTransaction TransactionDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? TransactionDate { get => _transactionDate; set => SetField(ref _transactionDate, value); }
    }
}