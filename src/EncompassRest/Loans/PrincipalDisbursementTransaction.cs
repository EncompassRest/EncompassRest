using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PrincipalDisbursementTransaction
    /// </summary>
    public sealed partial class PrincipalDisbursementTransaction : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _comments;
        /// <summary>
        /// PrincipalDisbursementTransaction Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _createdById;
        /// <summary>
        /// PrincipalDisbursementTransaction CreatedById
        /// </summary>
        public string CreatedById { get => _createdById; set => _createdById = value; }
        private DirtyValue<string> _createdByName;
        /// <summary>
        /// PrincipalDisbursementTransaction CreatedByName
        /// </summary>
        public string CreatedByName { get => _createdByName; set => _createdByName = value; }
        private DirtyValue<DateTime?> _createdDateTimeUtc;
        /// <summary>
        /// PrincipalDisbursementTransaction CreatedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CreatedDateTimeUtc { get => _createdDateTimeUtc; set => _createdDateTimeUtc = value; }
        private DirtyValue<DateTime?> _disbursementDate;
        /// <summary>
        /// PrincipalDisbursementTransaction DisbursementDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DisbursementDate { get => _disbursementDate; set => _disbursementDate = value; }
        private DirtyValue<string> _guid;
        /// <summary>
        /// PrincipalDisbursementTransaction Guid
        /// </summary>
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// PrincipalDisbursementTransaction Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _institutionName;
        /// <summary>
        /// PrincipalDisbursementTransaction InstitutionName
        /// </summary>
        public string InstitutionName { get => _institutionName; set => _institutionName = value; }
        private DirtyValue<string> _modifiedById;
        /// <summary>
        /// PrincipalDisbursementTransaction ModifiedById
        /// </summary>
        public string ModifiedById { get => _modifiedById; set => _modifiedById = value; }
        private DirtyValue<string> _modifiedByName;
        /// <summary>
        /// PrincipalDisbursementTransaction ModifiedByName
        /// </summary>
        public string ModifiedByName { get => _modifiedByName; set => _modifiedByName = value; }
        private DirtyValue<DateTime?> _modifiedDateTimeUtc;
        /// <summary>
        /// PrincipalDisbursementTransaction ModifiedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ModifiedDateTimeUtc { get => _modifiedDateTimeUtc; set => _modifiedDateTimeUtc = value; }
        private DirtyValue<string> _servicingPaymentMethod;
        /// <summary>
        /// PrincipalDisbursementTransaction ServicingPaymentMethod
        /// </summary>
        public string ServicingPaymentMethod { get => _servicingPaymentMethod; set => _servicingPaymentMethod = value; }
        private DirtyValue<string> _servicingTransactionType;
        /// <summary>
        /// PrincipalDisbursementTransaction ServicingTransactionType
        /// </summary>
        public string ServicingTransactionType { get => _servicingTransactionType; set => _servicingTransactionType = value; }
        private DirtyValue<decimal?> _transactionAmount;
        /// <summary>
        /// PrincipalDisbursementTransaction TransactionAmount
        /// </summary>
        public decimal? TransactionAmount { get => _transactionAmount; set => _transactionAmount = value; }
        private DirtyValue<DateTime?> _transactionDate;
        /// <summary>
        /// PrincipalDisbursementTransaction TransactionDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? TransactionDate { get => _transactionDate; set => _transactionDate = value; }
    }
}