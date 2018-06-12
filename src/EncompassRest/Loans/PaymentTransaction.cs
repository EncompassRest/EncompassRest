using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PaymentTransaction
    /// </summary>
    public sealed partial class PaymentTransaction : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _accountHolder;
        /// <summary>
        /// PaymentTransaction AccountHolder
        /// </summary>
        public string AccountHolder { get => _accountHolder; set => _accountHolder = value; }
        private DirtyValue<string> _accountNumber;
        /// <summary>
        /// PaymentTransaction AccountNumber
        /// </summary>
        public string AccountNumber { get => _accountNumber; set => _accountNumber = value; }
        private DirtyValue<decimal?> _additionalEscrow;
        /// <summary>
        /// PaymentTransaction AdditionalEscrow
        /// </summary>
        public decimal? AdditionalEscrow { get => _additionalEscrow; set => _additionalEscrow = value; }
        private DirtyValue<decimal?> _additionalPrincipal;
        /// <summary>
        /// PaymentTransaction AdditionalPrincipal
        /// </summary>
        public decimal? AdditionalPrincipal { get => _additionalPrincipal; set => _additionalPrincipal = value; }
        private DirtyValue<decimal?> _buydownSubsidyAmount;
        /// <summary>
        /// PaymentTransaction BuydownSubsidyAmount
        /// </summary>
        public decimal? BuydownSubsidyAmount { get => _buydownSubsidyAmount; set => _buydownSubsidyAmount = value; }
        private DirtyValue<string> _checkNumber;
        /// <summary>
        /// PaymentTransaction CheckNumber
        /// </summary>
        public string CheckNumber { get => _checkNumber; set => _checkNumber = value; }
        private DirtyValue<string> _comments;
        /// <summary>
        /// PaymentTransaction Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<decimal?> _commonAmount;
        /// <summary>
        /// PaymentTransaction CommonAmount
        /// </summary>
        public decimal? CommonAmount { get => _commonAmount; set => _commonAmount = value; }
        private DirtyValue<DateTime?> _commonDate;
        /// <summary>
        /// PaymentTransaction CommonDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CommonDate { get => _commonDate; set => _commonDate = value; }
        private DirtyValue<string> _createdById;
        /// <summary>
        /// PaymentTransaction CreatedById
        /// </summary>
        public string CreatedById { get => _createdById; set => _createdById = value; }
        private DirtyValue<string> _createdByName;
        /// <summary>
        /// PaymentTransaction CreatedByName
        /// </summary>
        public string CreatedByName { get => _createdByName; set => _createdByName = value; }
        private DirtyValue<DateTime?> _createdDateTimeUtc;
        /// <summary>
        /// PaymentTransaction CreatedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CreatedDateTimeUtc { get => _createdDateTimeUtc; set => _createdDateTimeUtc = value; }
        private DirtyValue<decimal?> _escrow;
        /// <summary>
        /// PaymentTransaction Escrow
        /// </summary>
        public decimal? Escrow { get => _escrow; set => _escrow = value; }
        private DirtyValue<decimal?> _escrowCityPropertyTax;
        /// <summary>
        /// PaymentTransaction EscrowCityPropertyTax
        /// </summary>
        public decimal? EscrowCityPropertyTax { get => _escrowCityPropertyTax; set => _escrowCityPropertyTax = value; }
        private DirtyValue<decimal?> _escrowFloodInsurance;
        /// <summary>
        /// PaymentTransaction EscrowFloodInsurance
        /// </summary>
        public decimal? EscrowFloodInsurance { get => _escrowFloodInsurance; set => _escrowFloodInsurance = value; }
        private DirtyValue<decimal?> _escrowHazardInsurance;
        /// <summary>
        /// PaymentTransaction EscrowHazardInsurance
        /// </summary>
        public decimal? EscrowHazardInsurance { get => _escrowHazardInsurance; set => _escrowHazardInsurance = value; }
        private DirtyValue<decimal?> _escrowMortgageInsurance;
        /// <summary>
        /// PaymentTransaction EscrowMortgageInsurance
        /// </summary>
        public decimal? EscrowMortgageInsurance { get => _escrowMortgageInsurance; set => _escrowMortgageInsurance = value; }
        private DirtyValue<decimal?> _escrowOther1;
        /// <summary>
        /// PaymentTransaction EscrowOther1
        /// </summary>
        public decimal? EscrowOther1 { get => _escrowOther1; set => _escrowOther1 = value; }
        private DirtyValue<decimal?> _escrowOther2;
        /// <summary>
        /// PaymentTransaction EscrowOther2
        /// </summary>
        public decimal? EscrowOther2 { get => _escrowOther2; set => _escrowOther2 = value; }
        private DirtyValue<decimal?> _escrowOther3;
        /// <summary>
        /// PaymentTransaction EscrowOther3
        /// </summary>
        public decimal? EscrowOther3 { get => _escrowOther3; set => _escrowOther3 = value; }
        private DirtyValue<decimal?> _escrowTax;
        /// <summary>
        /// PaymentTransaction EscrowTax
        /// </summary>
        public decimal? EscrowTax { get => _escrowTax; set => _escrowTax = value; }
        private DirtyValue<decimal?> _escrowUSDAMonthlyPremium;
        /// <summary>
        /// PaymentTransaction EscrowUSDAMonthlyPremium
        /// </summary>
        public decimal? EscrowUSDAMonthlyPremium { get => _escrowUSDAMonthlyPremium; set => _escrowUSDAMonthlyPremium = value; }
        private DirtyValue<string> _guid;
        /// <summary>
        /// PaymentTransaction Guid
        /// </summary>
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// PaymentTransaction Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _indexRate;
        /// <summary>
        /// PaymentTransaction IndexRate
        /// </summary>
        public decimal? IndexRate { get => _indexRate; set => _indexRate = value; }
        private DirtyValue<string> _institutionName;
        /// <summary>
        /// PaymentTransaction InstitutionName
        /// </summary>
        public string InstitutionName { get => _institutionName; set => _institutionName = value; }
        private DirtyValue<string> _institutionRouting;
        /// <summary>
        /// PaymentTransaction InstitutionRouting
        /// </summary>
        public string InstitutionRouting { get => _institutionRouting; set => _institutionRouting = value; }
        private DirtyValue<decimal?> _interest;
        /// <summary>
        /// PaymentTransaction Interest
        /// </summary>
        public decimal? Interest { get => _interest; set => _interest = value; }
        private DirtyValue<decimal?> _interestRate;
        /// <summary>
        /// PaymentTransaction InterestRate
        /// </summary>
        public decimal? InterestRate { get => _interestRate; set => _interestRate = value; }
        private DirtyValue<decimal?> _lateFee;
        /// <summary>
        /// PaymentTransaction LateFee
        /// </summary>
        public decimal? LateFee { get => _lateFee; set => _lateFee = value; }
        private DirtyValue<decimal?> _lateFeeIfLate;
        /// <summary>
        /// PaymentTransaction LateFeeIfLate
        /// </summary>
        public decimal? LateFeeIfLate { get => _lateFeeIfLate; set => _lateFeeIfLate = value; }
        private DirtyValue<DateTime?> _latePaymentDate;
        /// <summary>
        /// PaymentTransaction LatePaymentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LatePaymentDate { get => _latePaymentDate; set => _latePaymentDate = value; }
        private DirtyValue<decimal?> _miscFee;
        /// <summary>
        /// PaymentTransaction MiscFee
        /// </summary>
        public decimal? MiscFee { get => _miscFee; set => _miscFee = value; }
        private DirtyValue<string> _modifiedById;
        /// <summary>
        /// PaymentTransaction ModifiedById
        /// </summary>
        public string ModifiedById { get => _modifiedById; set => _modifiedById = value; }
        private DirtyValue<string> _modifiedByName;
        /// <summary>
        /// PaymentTransaction ModifiedByName
        /// </summary>
        public string ModifiedByName { get => _modifiedByName; set => _modifiedByName = value; }
        private DirtyValue<DateTime?> _modifiedDateTimeUtc;
        /// <summary>
        /// PaymentTransaction ModifiedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ModifiedDateTimeUtc { get => _modifiedDateTimeUtc; set => _modifiedDateTimeUtc = value; }
        private DirtyValue<DateTime?> _paymentDepositedDate;
        /// <summary>
        /// PaymentTransaction PaymentDepositedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? PaymentDepositedDate { get => _paymentDepositedDate; set => _paymentDepositedDate = value; }
        private DirtyValue<DateTime?> _paymentDueDate;
        /// <summary>
        /// PaymentTransaction PaymentDueDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? PaymentDueDate { get => _paymentDueDate; set => _paymentDueDate = value; }
        private DirtyValue<DateTime?> _paymentIndexDate;
        /// <summary>
        /// PaymentTransaction PaymentIndexDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? PaymentIndexDate { get => _paymentIndexDate; set => _paymentIndexDate = value; }
        private DirtyValue<int?> _paymentNumber;
        /// <summary>
        /// PaymentTransaction PaymentNumber
        /// </summary>
        public int? PaymentNumber { get => _paymentNumber; set => _paymentNumber = value; }
        private DirtyValue<DateTime?> _paymentReceivedDate;
        /// <summary>
        /// PaymentTransaction PaymentReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? PaymentReceivedDate { get => _paymentReceivedDate; set => _paymentReceivedDate = value; }
        private DirtyValue<decimal?> _principal;
        /// <summary>
        /// PaymentTransaction Principal
        /// </summary>
        public decimal? Principal { get => _principal; set => _principal = value; }
        private DirtyValue<string> _reference;
        /// <summary>
        /// PaymentTransaction Reference
        /// </summary>
        public string Reference { get => _reference; set => _reference = value; }
        private DirtyValue<decimal?> _schedulePayLogMiscFee;
        /// <summary>
        /// PaymentTransaction SchedulePayLogMiscFee
        /// </summary>
        public decimal? SchedulePayLogMiscFee { get => _schedulePayLogMiscFee; set => _schedulePayLogMiscFee = value; }
        private DirtyValue<string> _servicingPaymentMethod;
        /// <summary>
        /// PaymentTransaction ServicingPaymentMethod
        /// </summary>
        public string ServicingPaymentMethod { get => _servicingPaymentMethod; set => _servicingPaymentMethod = value; }
        private DirtyValue<string> _servicingTransactionType;
        /// <summary>
        /// PaymentTransaction ServicingTransactionType
        /// </summary>
        public string ServicingTransactionType { get => _servicingTransactionType; set => _servicingTransactionType = value; }
        private DirtyValue<DateTime?> _statementDate;
        /// <summary>
        /// PaymentTransaction StatementDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? StatementDate { get => _statementDate; set => _statementDate = value; }
        private DirtyValue<decimal?> _totalAmountDue;
        /// <summary>
        /// PaymentTransaction TotalAmountDue
        /// </summary>
        public decimal? TotalAmountDue { get => _totalAmountDue; set => _totalAmountDue = value; }
        private DirtyValue<decimal?> _totalAmountReceived;
        /// <summary>
        /// PaymentTransaction TotalAmountReceived
        /// </summary>
        public decimal? TotalAmountReceived { get => _totalAmountReceived; set => _totalAmountReceived = value; }
        private DirtyValue<decimal?> _transactionAmount;
        /// <summary>
        /// PaymentTransaction TransactionAmount
        /// </summary>
        public decimal? TransactionAmount { get => _transactionAmount; set => _transactionAmount = value; }
        private DirtyValue<DateTime?> _transactionDate;
        /// <summary>
        /// PaymentTransaction TransactionDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? TransactionDate { get => _transactionDate; set => _transactionDate = value; }
        internal override bool DirtyInternal
        {
            get => _accountHolder.Dirty
                || _accountNumber.Dirty
                || _additionalEscrow.Dirty
                || _additionalPrincipal.Dirty
                || _buydownSubsidyAmount.Dirty
                || _checkNumber.Dirty
                || _comments.Dirty
                || _commonAmount.Dirty
                || _commonDate.Dirty
                || _createdById.Dirty
                || _createdByName.Dirty
                || _createdDateTimeUtc.Dirty
                || _escrow.Dirty
                || _escrowCityPropertyTax.Dirty
                || _escrowFloodInsurance.Dirty
                || _escrowHazardInsurance.Dirty
                || _escrowMortgageInsurance.Dirty
                || _escrowOther1.Dirty
                || _escrowOther2.Dirty
                || _escrowOther3.Dirty
                || _escrowTax.Dirty
                || _escrowUSDAMonthlyPremium.Dirty
                || _guid.Dirty
                || _id.Dirty
                || _indexRate.Dirty
                || _institutionName.Dirty
                || _institutionRouting.Dirty
                || _interest.Dirty
                || _interestRate.Dirty
                || _lateFee.Dirty
                || _lateFeeIfLate.Dirty
                || _latePaymentDate.Dirty
                || _miscFee.Dirty
                || _modifiedById.Dirty
                || _modifiedByName.Dirty
                || _modifiedDateTimeUtc.Dirty
                || _paymentDepositedDate.Dirty
                || _paymentDueDate.Dirty
                || _paymentIndexDate.Dirty
                || _paymentNumber.Dirty
                || _paymentReceivedDate.Dirty
                || _principal.Dirty
                || _reference.Dirty
                || _schedulePayLogMiscFee.Dirty
                || _servicingPaymentMethod.Dirty
                || _servicingTransactionType.Dirty
                || _statementDate.Dirty
                || _totalAmountDue.Dirty
                || _totalAmountReceived.Dirty
                || _transactionAmount.Dirty
                || _transactionDate.Dirty;
            set
            {
                _accountHolder.Dirty = value;
                _accountNumber.Dirty = value;
                _additionalEscrow.Dirty = value;
                _additionalPrincipal.Dirty = value;
                _buydownSubsidyAmount.Dirty = value;
                _checkNumber.Dirty = value;
                _comments.Dirty = value;
                _commonAmount.Dirty = value;
                _commonDate.Dirty = value;
                _createdById.Dirty = value;
                _createdByName.Dirty = value;
                _createdDateTimeUtc.Dirty = value;
                _escrow.Dirty = value;
                _escrowCityPropertyTax.Dirty = value;
                _escrowFloodInsurance.Dirty = value;
                _escrowHazardInsurance.Dirty = value;
                _escrowMortgageInsurance.Dirty = value;
                _escrowOther1.Dirty = value;
                _escrowOther2.Dirty = value;
                _escrowOther3.Dirty = value;
                _escrowTax.Dirty = value;
                _escrowUSDAMonthlyPremium.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _indexRate.Dirty = value;
                _institutionName.Dirty = value;
                _institutionRouting.Dirty = value;
                _interest.Dirty = value;
                _interestRate.Dirty = value;
                _lateFee.Dirty = value;
                _lateFeeIfLate.Dirty = value;
                _latePaymentDate.Dirty = value;
                _miscFee.Dirty = value;
                _modifiedById.Dirty = value;
                _modifiedByName.Dirty = value;
                _modifiedDateTimeUtc.Dirty = value;
                _paymentDepositedDate.Dirty = value;
                _paymentDueDate.Dirty = value;
                _paymentIndexDate.Dirty = value;
                _paymentNumber.Dirty = value;
                _paymentReceivedDate.Dirty = value;
                _principal.Dirty = value;
                _reference.Dirty = value;
                _schedulePayLogMiscFee.Dirty = value;
                _servicingPaymentMethod.Dirty = value;
                _servicingTransactionType.Dirty = value;
                _statementDate.Dirty = value;
                _totalAmountDue.Dirty = value;
                _totalAmountReceived.Dirty = value;
                _transactionAmount.Dirty = value;
                _transactionDate.Dirty = value;
            }
        }
    }
}