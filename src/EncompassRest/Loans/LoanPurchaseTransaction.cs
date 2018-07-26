using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LoanPurchaseTransaction
    /// </summary>
    public sealed partial class LoanPurchaseTransaction : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _comments;
        /// <summary>
        /// LoanPurchaseTransaction Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _createdById;
        /// <summary>
        /// LoanPurchaseTransaction CreatedById
        /// </summary>
        public string CreatedById { get => _createdById; set => _createdById = value; }
        private DirtyValue<string> _createdByName;
        /// <summary>
        /// LoanPurchaseTransaction CreatedByName
        /// </summary>
        public string CreatedByName { get => _createdByName; set => _createdByName = value; }
        private DirtyValue<DateTime?> _createdDateTimeUtc;
        /// <summary>
        /// LoanPurchaseTransaction CreatedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CreatedDateTimeUtc { get => _createdDateTimeUtc; set => _createdDateTimeUtc = value; }
        private DirtyValue<DateTime?> _createdTime;
        /// <summary>
        /// LoanPurchaseTransaction CreatedTime
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CreatedTime { get => _createdTime; set => _createdTime = value; }
        private DirtyValue<DateTime?> _firstPaymenttoInvestor;
        /// <summary>
        /// LoanPurchaseTransaction FirstPaymenttoInvestor
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? FirstPaymenttoInvestor { get => _firstPaymenttoInvestor; set => _firstPaymenttoInvestor = value; }
        private DirtyValue<string> _guid;
        /// <summary>
        /// LoanPurchaseTransaction Guid
        /// </summary>
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// LoanPurchaseTransaction Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _investor;
        /// <summary>
        /// LoanPurchaseTransaction Investor
        /// </summary>
        public string Investor { get => _investor; set => _investor = value; }
        private DirtyValue<string> _investorLoanNumber;
        /// <summary>
        /// LoanPurchaseTransaction InvestorLoanNumber
        /// </summary>
        public string InvestorLoanNumber { get => _investorLoanNumber; set => _investorLoanNumber = value; }
        private DirtyValue<string> _modifiedById;
        /// <summary>
        /// LoanPurchaseTransaction ModifiedById
        /// </summary>
        public string ModifiedById { get => _modifiedById; set => _modifiedById = value; }
        private DirtyValue<string> _modifiedByName;
        /// <summary>
        /// LoanPurchaseTransaction ModifiedByName
        /// </summary>
        public string ModifiedByName { get => _modifiedByName; set => _modifiedByName = value; }
        private DirtyValue<DateTime?> _modifiedDateTimeUtc;
        /// <summary>
        /// LoanPurchaseTransaction ModifiedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ModifiedDateTimeUtc { get => _modifiedDateTimeUtc; set => _modifiedDateTimeUtc = value; }
        private DirtyValue<DateTime?> _purchaseAdivceDate;
        /// <summary>
        /// LoanPurchaseTransaction PurchaseAdivceDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? PurchaseAdivceDate { get => _purchaseAdivceDate; set => _purchaseAdivceDate = value; }
        private DirtyValue<decimal?> _purchaseAmount;
        /// <summary>
        /// LoanPurchaseTransaction PurchaseAmount
        /// </summary>
        public decimal? PurchaseAmount { get => _purchaseAmount; set => _purchaseAmount = value; }
        private DirtyValue<string> _servicingPaymentMethod;
        /// <summary>
        /// LoanPurchaseTransaction ServicingPaymentMethod
        /// </summary>
        public string ServicingPaymentMethod { get => _servicingPaymentMethod; set => _servicingPaymentMethod = value; }
        private DirtyValue<string> _servicingTransactionType;
        /// <summary>
        /// LoanPurchaseTransaction ServicingTransactionType
        /// </summary>
        public string ServicingTransactionType { get => _servicingTransactionType; set => _servicingTransactionType = value; }
        private DirtyValue<decimal?> _transactionAmount;
        /// <summary>
        /// LoanPurchaseTransaction TransactionAmount
        /// </summary>
        public decimal? TransactionAmount { get => _transactionAmount; set => _transactionAmount = value; }
        private DirtyValue<DateTime?> _transactionDate;
        /// <summary>
        /// LoanPurchaseTransaction TransactionDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? TransactionDate { get => _transactionDate; set => _transactionDate = value; }
        internal override bool DirtyInternal
        {
            get => _comments.Dirty
                || _createdById.Dirty
                || _createdByName.Dirty
                || _createdDateTimeUtc.Dirty
                || _createdTime.Dirty
                || _firstPaymenttoInvestor.Dirty
                || _guid.Dirty
                || _id.Dirty
                || _investor.Dirty
                || _investorLoanNumber.Dirty
                || _modifiedById.Dirty
                || _modifiedByName.Dirty
                || _modifiedDateTimeUtc.Dirty
                || _purchaseAdivceDate.Dirty
                || _purchaseAmount.Dirty
                || _servicingPaymentMethod.Dirty
                || _servicingTransactionType.Dirty
                || _transactionAmount.Dirty
                || _transactionDate.Dirty;
            set
            {
                _comments.Dirty = value;
                _createdById.Dirty = value;
                _createdByName.Dirty = value;
                _createdDateTimeUtc.Dirty = value;
                _createdTime.Dirty = value;
                _firstPaymenttoInvestor.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _investor.Dirty = value;
                _investorLoanNumber.Dirty = value;
                _modifiedById.Dirty = value;
                _modifiedByName.Dirty = value;
                _modifiedDateTimeUtc.Dirty = value;
                _purchaseAdivceDate.Dirty = value;
                _purchaseAmount.Dirty = value;
                _servicingPaymentMethod.Dirty = value;
                _servicingTransactionType.Dirty = value;
                _transactionAmount.Dirty = value;
                _transactionDate.Dirty = value;
            }
        }
    }
}