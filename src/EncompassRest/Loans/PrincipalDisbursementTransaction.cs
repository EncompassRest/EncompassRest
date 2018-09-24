using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PrincipalDisbursementTransaction
    /// </summary>
    public sealed partial class PrincipalDisbursementTransaction : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _comments;
        private DirtyValue<string> _createdById;
        private DirtyValue<string> _createdByName;
        private DirtyValue<DateTime?> _createdDateTimeUtc;
        private DirtyValue<DateTime?> _disbursementDate;
        private DirtyValue<string> _guid;
        private DirtyValue<string> _id;
        private DirtyValue<string> _institutionName;
        private DirtyValue<string> _modifiedById;
        private DirtyValue<string> _modifiedByName;
        private DirtyValue<DateTime?> _modifiedDateTimeUtc;
        private DirtyValue<string> _servicingPaymentMethod;
        private DirtyValue<string> _servicingTransactionType;
        private DirtyValue<decimal?> _transactionAmount;
        private DirtyValue<DateTime?> _transactionDate;

        /// <summary>
        /// PrincipalDisbursementTransaction Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// PrincipalDisbursementTransaction CreatedById
        /// </summary>
        public string CreatedById { get => _createdById; set => SetField(ref _createdById, value); }

        /// <summary>
        /// PrincipalDisbursementTransaction CreatedByName
        /// </summary>
        public string CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }

        /// <summary>
        /// PrincipalDisbursementTransaction CreatedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CreatedDateTimeUtc { get => _createdDateTimeUtc; set => SetField(ref _createdDateTimeUtc, value); }

        /// <summary>
        /// PrincipalDisbursementTransaction DisbursementDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DisbursementDate { get => _disbursementDate; set => SetField(ref _disbursementDate, value); }

        /// <summary>
        /// PrincipalDisbursementTransaction Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// PrincipalDisbursementTransaction Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// PrincipalDisbursementTransaction InstitutionName
        /// </summary>
        public string InstitutionName { get => _institutionName; set => SetField(ref _institutionName, value); }

        /// <summary>
        /// PrincipalDisbursementTransaction ModifiedById
        /// </summary>
        public string ModifiedById { get => _modifiedById; set => SetField(ref _modifiedById, value); }

        /// <summary>
        /// PrincipalDisbursementTransaction ModifiedByName
        /// </summary>
        public string ModifiedByName { get => _modifiedByName; set => SetField(ref _modifiedByName, value); }

        /// <summary>
        /// PrincipalDisbursementTransaction ModifiedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ModifiedDateTimeUtc { get => _modifiedDateTimeUtc; set => SetField(ref _modifiedDateTimeUtc, value); }

        /// <summary>
        /// PrincipalDisbursementTransaction ServicingPaymentMethod
        /// </summary>
        public string ServicingPaymentMethod { get => _servicingPaymentMethod; set => SetField(ref _servicingPaymentMethod, value); }

        /// <summary>
        /// PrincipalDisbursementTransaction ServicingTransactionType
        /// </summary>
        public string ServicingTransactionType { get => _servicingTransactionType; set => SetField(ref _servicingTransactionType, value); }

        /// <summary>
        /// PrincipalDisbursementTransaction TransactionAmount
        /// </summary>
        public decimal? TransactionAmount { get => _transactionAmount; set => SetField(ref _transactionAmount, value); }

        /// <summary>
        /// PrincipalDisbursementTransaction TransactionDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? TransactionDate { get => _transactionDate; set => SetField(ref _transactionDate, value); }
    }
}