using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PaymentTransaction
    /// </summary>
    public sealed partial class PaymentTransaction : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _accountHolder;
        /// <summary>
        /// PaymentTransaction AccountHolder
        /// </summary>
        public string AccountHolder { get => _accountHolder; set => SetField(ref _accountHolder, value); }
        private DirtyValue<string> _accountNumber;
        /// <summary>
        /// PaymentTransaction AccountNumber
        /// </summary>
        public string AccountNumber { get => _accountNumber; set => SetField(ref _accountNumber, value); }
        private DirtyValue<decimal?> _additionalEscrow;
        /// <summary>
        /// PaymentTransaction AdditionalEscrow
        /// </summary>
        public decimal? AdditionalEscrow { get => _additionalEscrow; set => SetField(ref _additionalEscrow, value); }
        private DirtyValue<decimal?> _additionalPrincipal;
        /// <summary>
        /// PaymentTransaction AdditionalPrincipal
        /// </summary>
        public decimal? AdditionalPrincipal { get => _additionalPrincipal; set => SetField(ref _additionalPrincipal, value); }
        private DirtyValue<decimal?> _buydownSubsidyAmount;
        /// <summary>
        /// PaymentTransaction BuydownSubsidyAmount
        /// </summary>
        public decimal? BuydownSubsidyAmount { get => _buydownSubsidyAmount; set => SetField(ref _buydownSubsidyAmount, value); }
        private DirtyValue<string> _checkNumber;
        /// <summary>
        /// PaymentTransaction CheckNumber
        /// </summary>
        public string CheckNumber { get => _checkNumber; set => SetField(ref _checkNumber, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// PaymentTransaction Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<decimal?> _commonAmount;
        /// <summary>
        /// PaymentTransaction CommonAmount
        /// </summary>
        public decimal? CommonAmount { get => _commonAmount; set => SetField(ref _commonAmount, value); }
        private DirtyValue<DateTime?> _commonDate;
        /// <summary>
        /// PaymentTransaction CommonDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CommonDate { get => _commonDate; set => SetField(ref _commonDate, value); }
        private DirtyValue<string> _createdById;
        /// <summary>
        /// PaymentTransaction CreatedById
        /// </summary>
        public string CreatedById { get => _createdById; set => SetField(ref _createdById, value); }
        private DirtyValue<string> _createdByName;
        /// <summary>
        /// PaymentTransaction CreatedByName
        /// </summary>
        public string CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }
        private DirtyValue<DateTime?> _createdDateTimeUtc;
        /// <summary>
        /// PaymentTransaction CreatedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CreatedDateTimeUtc { get => _createdDateTimeUtc; set => SetField(ref _createdDateTimeUtc, value); }
        private DirtyValue<decimal?> _escrow;
        /// <summary>
        /// PaymentTransaction Escrow
        /// </summary>
        public decimal? Escrow { get => _escrow; set => SetField(ref _escrow, value); }
        private DirtyValue<decimal?> _escrowCityPropertyTax;
        /// <summary>
        /// PaymentTransaction EscrowCityPropertyTax
        /// </summary>
        public decimal? EscrowCityPropertyTax { get => _escrowCityPropertyTax; set => SetField(ref _escrowCityPropertyTax, value); }
        private DirtyValue<decimal?> _escrowFloodInsurance;
        /// <summary>
        /// PaymentTransaction EscrowFloodInsurance
        /// </summary>
        public decimal? EscrowFloodInsurance { get => _escrowFloodInsurance; set => SetField(ref _escrowFloodInsurance, value); }
        private DirtyValue<decimal?> _escrowHazardInsurance;
        /// <summary>
        /// PaymentTransaction EscrowHazardInsurance
        /// </summary>
        public decimal? EscrowHazardInsurance { get => _escrowHazardInsurance; set => SetField(ref _escrowHazardInsurance, value); }
        private DirtyValue<decimal?> _escrowMortgageInsurance;
        /// <summary>
        /// PaymentTransaction EscrowMortgageInsurance
        /// </summary>
        public decimal? EscrowMortgageInsurance { get => _escrowMortgageInsurance; set => SetField(ref _escrowMortgageInsurance, value); }
        private DirtyValue<decimal?> _escrowOther1;
        /// <summary>
        /// PaymentTransaction EscrowOther1
        /// </summary>
        public decimal? EscrowOther1 { get => _escrowOther1; set => SetField(ref _escrowOther1, value); }
        private DirtyValue<decimal?> _escrowOther2;
        /// <summary>
        /// PaymentTransaction EscrowOther2
        /// </summary>
        public decimal? EscrowOther2 { get => _escrowOther2; set => SetField(ref _escrowOther2, value); }
        private DirtyValue<decimal?> _escrowOther3;
        /// <summary>
        /// PaymentTransaction EscrowOther3
        /// </summary>
        public decimal? EscrowOther3 { get => _escrowOther3; set => SetField(ref _escrowOther3, value); }
        private DirtyValue<decimal?> _escrowTax;
        /// <summary>
        /// PaymentTransaction EscrowTax
        /// </summary>
        public decimal? EscrowTax { get => _escrowTax; set => SetField(ref _escrowTax, value); }
        private DirtyValue<decimal?> _escrowUSDAMonthlyPremium;
        /// <summary>
        /// PaymentTransaction EscrowUSDAMonthlyPremium
        /// </summary>
        public decimal? EscrowUSDAMonthlyPremium { get => _escrowUSDAMonthlyPremium; set => SetField(ref _escrowUSDAMonthlyPremium, value); }
        private DirtyValue<string> _guid;
        /// <summary>
        /// PaymentTransaction Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// PaymentTransaction Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<decimal?> _indexRate;
        /// <summary>
        /// PaymentTransaction IndexRate
        /// </summary>
        public decimal? IndexRate { get => _indexRate; set => SetField(ref _indexRate, value); }
        private DirtyValue<string> _institutionName;
        /// <summary>
        /// PaymentTransaction InstitutionName
        /// </summary>
        public string InstitutionName { get => _institutionName; set => SetField(ref _institutionName, value); }
        private DirtyValue<string> _institutionRouting;
        /// <summary>
        /// PaymentTransaction InstitutionRouting
        /// </summary>
        public string InstitutionRouting { get => _institutionRouting; set => SetField(ref _institutionRouting, value); }
        private DirtyValue<decimal?> _interest;
        /// <summary>
        /// PaymentTransaction Interest
        /// </summary>
        public decimal? Interest { get => _interest; set => SetField(ref _interest, value); }
        private DirtyValue<decimal?> _interestRate;
        /// <summary>
        /// PaymentTransaction InterestRate
        /// </summary>
        public decimal? InterestRate { get => _interestRate; set => SetField(ref _interestRate, value); }
        private DirtyValue<decimal?> _lateFee;
        /// <summary>
        /// PaymentTransaction LateFee
        /// </summary>
        public decimal? LateFee { get => _lateFee; set => SetField(ref _lateFee, value); }
        private DirtyValue<decimal?> _lateFeeIfLate;
        /// <summary>
        /// PaymentTransaction LateFeeIfLate
        /// </summary>
        public decimal? LateFeeIfLate { get => _lateFeeIfLate; set => SetField(ref _lateFeeIfLate, value); }
        private DirtyValue<DateTime?> _latePaymentDate;
        /// <summary>
        /// PaymentTransaction LatePaymentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LatePaymentDate { get => _latePaymentDate; set => SetField(ref _latePaymentDate, value); }
        private DirtyValue<decimal?> _miscFee;
        /// <summary>
        /// PaymentTransaction MiscFee
        /// </summary>
        public decimal? MiscFee { get => _miscFee; set => SetField(ref _miscFee, value); }
        private DirtyValue<string> _modifiedById;
        /// <summary>
        /// PaymentTransaction ModifiedById
        /// </summary>
        public string ModifiedById { get => _modifiedById; set => SetField(ref _modifiedById, value); }
        private DirtyValue<string> _modifiedByName;
        /// <summary>
        /// PaymentTransaction ModifiedByName
        /// </summary>
        public string ModifiedByName { get => _modifiedByName; set => SetField(ref _modifiedByName, value); }
        private DirtyValue<DateTime?> _modifiedDateTimeUtc;
        /// <summary>
        /// PaymentTransaction ModifiedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ModifiedDateTimeUtc { get => _modifiedDateTimeUtc; set => SetField(ref _modifiedDateTimeUtc, value); }
        private DirtyValue<DateTime?> _paymentDepositedDate;
        /// <summary>
        /// PaymentTransaction PaymentDepositedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? PaymentDepositedDate { get => _paymentDepositedDate; set => SetField(ref _paymentDepositedDate, value); }
        private DirtyValue<DateTime?> _paymentDueDate;
        /// <summary>
        /// PaymentTransaction PaymentDueDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? PaymentDueDate { get => _paymentDueDate; set => SetField(ref _paymentDueDate, value); }
        private DirtyValue<DateTime?> _paymentIndexDate;
        /// <summary>
        /// PaymentTransaction PaymentIndexDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? PaymentIndexDate { get => _paymentIndexDate; set => SetField(ref _paymentIndexDate, value); }
        private DirtyValue<int?> _paymentNumber;
        /// <summary>
        /// PaymentTransaction PaymentNumber
        /// </summary>
        public int? PaymentNumber { get => _paymentNumber; set => SetField(ref _paymentNumber, value); }
        private DirtyValue<DateTime?> _paymentReceivedDate;
        /// <summary>
        /// PaymentTransaction PaymentReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? PaymentReceivedDate { get => _paymentReceivedDate; set => SetField(ref _paymentReceivedDate, value); }
        private DirtyValue<decimal?> _principal;
        /// <summary>
        /// PaymentTransaction Principal
        /// </summary>
        public decimal? Principal { get => _principal; set => SetField(ref _principal, value); }
        private DirtyValue<string> _reference;
        /// <summary>
        /// PaymentTransaction Reference
        /// </summary>
        public string Reference { get => _reference; set => SetField(ref _reference, value); }
        private DirtyValue<decimal?> _schedulePayLogMiscFee;
        /// <summary>
        /// PaymentTransaction SchedulePayLogMiscFee
        /// </summary>
        public decimal? SchedulePayLogMiscFee { get => _schedulePayLogMiscFee; set => SetField(ref _schedulePayLogMiscFee, value); }
        private DirtyValue<string> _servicingPaymentMethod;
        /// <summary>
        /// PaymentTransaction ServicingPaymentMethod
        /// </summary>
        public string ServicingPaymentMethod { get => _servicingPaymentMethod; set => SetField(ref _servicingPaymentMethod, value); }
        private DirtyValue<string> _servicingTransactionType;
        /// <summary>
        /// PaymentTransaction ServicingTransactionType
        /// </summary>
        public string ServicingTransactionType { get => _servicingTransactionType; set => SetField(ref _servicingTransactionType, value); }
        private DirtyValue<DateTime?> _statementDate;
        /// <summary>
        /// PaymentTransaction StatementDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? StatementDate { get => _statementDate; set => SetField(ref _statementDate, value); }
        private DirtyValue<decimal?> _totalAmountDue;
        /// <summary>
        /// PaymentTransaction TotalAmountDue
        /// </summary>
        public decimal? TotalAmountDue { get => _totalAmountDue; set => SetField(ref _totalAmountDue, value); }
        private DirtyValue<decimal?> _totalAmountReceived;
        /// <summary>
        /// PaymentTransaction TotalAmountReceived
        /// </summary>
        public decimal? TotalAmountReceived { get => _totalAmountReceived; set => SetField(ref _totalAmountReceived, value); }
        private DirtyValue<decimal?> _transactionAmount;
        /// <summary>
        /// PaymentTransaction TransactionAmount
        /// </summary>
        public decimal? TransactionAmount { get => _transactionAmount; set => SetField(ref _transactionAmount, value); }
        private DirtyValue<DateTime?> _transactionDate;
        /// <summary>
        /// PaymentTransaction TransactionDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? TransactionDate { get => _transactionDate; set => SetField(ref _transactionDate, value); }
    }
}