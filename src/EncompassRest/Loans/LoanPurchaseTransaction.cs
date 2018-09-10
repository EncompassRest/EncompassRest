using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LoanPurchaseTransaction
    /// </summary>
    public sealed partial class LoanPurchaseTransaction : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _comments;
        /// <summary>
        /// LoanPurchaseTransaction Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<string> _createdById;
        /// <summary>
        /// LoanPurchaseTransaction CreatedById
        /// </summary>
        public string CreatedById { get => _createdById; set => SetField(ref _createdById, value); }
        private DirtyValue<string> _createdByName;
        /// <summary>
        /// LoanPurchaseTransaction CreatedByName
        /// </summary>
        public string CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }
        private DirtyValue<DateTime?> _createdDateTimeUtc;
        /// <summary>
        /// LoanPurchaseTransaction CreatedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CreatedDateTimeUtc { get => _createdDateTimeUtc; set => SetField(ref _createdDateTimeUtc, value); }
        private DirtyValue<DateTime?> _createdTime;
        /// <summary>
        /// LoanPurchaseTransaction CreatedTime
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CreatedTime { get => _createdTime; set => SetField(ref _createdTime, value); }
        private DirtyValue<DateTime?> _firstPaymenttoInvestor;
        /// <summary>
        /// LoanPurchaseTransaction FirstPaymenttoInvestor
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? FirstPaymenttoInvestor { get => _firstPaymenttoInvestor; set => SetField(ref _firstPaymenttoInvestor, value); }
        private DirtyValue<string> _guid;
        /// <summary>
        /// LoanPurchaseTransaction Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// LoanPurchaseTransaction Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _investor;
        /// <summary>
        /// LoanPurchaseTransaction Investor
        /// </summary>
        public string Investor { get => _investor; set => SetField(ref _investor, value); }
        private DirtyValue<string> _investorLoanNumber;
        /// <summary>
        /// LoanPurchaseTransaction InvestorLoanNumber
        /// </summary>
        public string InvestorLoanNumber { get => _investorLoanNumber; set => SetField(ref _investorLoanNumber, value); }
        private DirtyValue<string> _modifiedById;
        /// <summary>
        /// LoanPurchaseTransaction ModifiedById
        /// </summary>
        public string ModifiedById { get => _modifiedById; set => SetField(ref _modifiedById, value); }
        private DirtyValue<string> _modifiedByName;
        /// <summary>
        /// LoanPurchaseTransaction ModifiedByName
        /// </summary>
        public string ModifiedByName { get => _modifiedByName; set => SetField(ref _modifiedByName, value); }
        private DirtyValue<DateTime?> _modifiedDateTimeUtc;
        /// <summary>
        /// LoanPurchaseTransaction ModifiedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ModifiedDateTimeUtc { get => _modifiedDateTimeUtc; set => SetField(ref _modifiedDateTimeUtc, value); }
        private DirtyValue<DateTime?> _purchaseAdivceDate;
        /// <summary>
        /// LoanPurchaseTransaction PurchaseAdivceDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? PurchaseAdivceDate { get => _purchaseAdivceDate; set => SetField(ref _purchaseAdivceDate, value); }
        private DirtyValue<decimal?> _purchaseAmount;
        /// <summary>
        /// LoanPurchaseTransaction PurchaseAmount
        /// </summary>
        public decimal? PurchaseAmount { get => _purchaseAmount; set => SetField(ref _purchaseAmount, value); }
        private DirtyValue<string> _servicingPaymentMethod;
        /// <summary>
        /// LoanPurchaseTransaction ServicingPaymentMethod
        /// </summary>
        public string ServicingPaymentMethod { get => _servicingPaymentMethod; set => SetField(ref _servicingPaymentMethod, value); }
        private DirtyValue<string> _servicingTransactionType;
        /// <summary>
        /// LoanPurchaseTransaction ServicingTransactionType
        /// </summary>
        public string ServicingTransactionType { get => _servicingTransactionType; set => SetField(ref _servicingTransactionType, value); }
        private DirtyValue<decimal?> _transactionAmount;
        /// <summary>
        /// LoanPurchaseTransaction TransactionAmount
        /// </summary>
        public decimal? TransactionAmount { get => _transactionAmount; set => SetField(ref _transactionAmount, value); }
        private DirtyValue<DateTime?> _transactionDate;
        /// <summary>
        /// LoanPurchaseTransaction TransactionDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? TransactionDate { get => _transactionDate; set => SetField(ref _transactionDate, value); }
    }
}