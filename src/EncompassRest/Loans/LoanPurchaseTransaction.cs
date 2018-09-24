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
        private DirtyValue<string> _createdById;
        private DirtyValue<string> _createdByName;
        private DirtyValue<DateTime?> _createdDateTimeUtc;
        private DirtyValue<DateTime?> _createdTime;
        private DirtyValue<DateTime?> _firstPaymenttoInvestor;
        private DirtyValue<string> _guid;
        private DirtyValue<string> _id;
        private DirtyValue<string> _investor;
        private DirtyValue<string> _investorLoanNumber;
        private DirtyValue<string> _modifiedById;
        private DirtyValue<string> _modifiedByName;
        private DirtyValue<DateTime?> _modifiedDateTimeUtc;
        private DirtyValue<DateTime?> _purchaseAdivceDate;
        private DirtyValue<decimal?> _purchaseAmount;
        private DirtyValue<string> _servicingPaymentMethod;
        private DirtyValue<string> _servicingTransactionType;
        private DirtyValue<decimal?> _transactionAmount;
        private DirtyValue<DateTime?> _transactionDate;

        /// <summary>
        /// LoanPurchaseTransaction Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// LoanPurchaseTransaction CreatedById
        /// </summary>
        public string CreatedById { get => _createdById; set => SetField(ref _createdById, value); }

        /// <summary>
        /// LoanPurchaseTransaction CreatedByName
        /// </summary>
        public string CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }

        /// <summary>
        /// LoanPurchaseTransaction CreatedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CreatedDateTimeUtc { get => _createdDateTimeUtc; set => SetField(ref _createdDateTimeUtc, value); }

        /// <summary>
        /// LoanPurchaseTransaction CreatedTime
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CreatedTime { get => _createdTime; set => SetField(ref _createdTime, value); }

        /// <summary>
        /// LoanPurchaseTransaction FirstPaymenttoInvestor
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? FirstPaymenttoInvestor { get => _firstPaymenttoInvestor; set => SetField(ref _firstPaymenttoInvestor, value); }

        /// <summary>
        /// LoanPurchaseTransaction Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// LoanPurchaseTransaction Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// LoanPurchaseTransaction Investor
        /// </summary>
        public string Investor { get => _investor; set => SetField(ref _investor, value); }

        /// <summary>
        /// LoanPurchaseTransaction InvestorLoanNumber
        /// </summary>
        public string InvestorLoanNumber { get => _investorLoanNumber; set => SetField(ref _investorLoanNumber, value); }

        /// <summary>
        /// LoanPurchaseTransaction ModifiedById
        /// </summary>
        public string ModifiedById { get => _modifiedById; set => SetField(ref _modifiedById, value); }

        /// <summary>
        /// LoanPurchaseTransaction ModifiedByName
        /// </summary>
        public string ModifiedByName { get => _modifiedByName; set => SetField(ref _modifiedByName, value); }

        /// <summary>
        /// LoanPurchaseTransaction ModifiedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ModifiedDateTimeUtc { get => _modifiedDateTimeUtc; set => SetField(ref _modifiedDateTimeUtc, value); }

        /// <summary>
        /// LoanPurchaseTransaction PurchaseAdivceDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? PurchaseAdivceDate { get => _purchaseAdivceDate; set => SetField(ref _purchaseAdivceDate, value); }

        /// <summary>
        /// LoanPurchaseTransaction PurchaseAmount
        /// </summary>
        public decimal? PurchaseAmount { get => _purchaseAmount; set => SetField(ref _purchaseAmount, value); }

        /// <summary>
        /// LoanPurchaseTransaction ServicingPaymentMethod
        /// </summary>
        public string ServicingPaymentMethod { get => _servicingPaymentMethod; set => SetField(ref _servicingPaymentMethod, value); }

        /// <summary>
        /// LoanPurchaseTransaction ServicingTransactionType
        /// </summary>
        public string ServicingTransactionType { get => _servicingTransactionType; set => SetField(ref _servicingTransactionType, value); }

        /// <summary>
        /// LoanPurchaseTransaction TransactionAmount
        /// </summary>
        public decimal? TransactionAmount { get => _transactionAmount; set => SetField(ref _transactionAmount, value); }

        /// <summary>
        /// LoanPurchaseTransaction TransactionDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? TransactionDate { get => _transactionDate; set => SetField(ref _transactionDate, value); }
    }
}