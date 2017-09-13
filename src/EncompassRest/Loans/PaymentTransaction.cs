using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class PaymentTransaction : IDirty
    {
        private Value<string> _accountHolder;
        public string AccountHolder { get { return _accountHolder; } set { _accountHolder = value; } }
        private Value<string> _accountNumber;
        public string AccountNumber { get { return _accountNumber; } set { _accountNumber = value; } }
        private Value<decimal?> _additionalEscrow;
        public decimal? AdditionalEscrow { get { return _additionalEscrow; } set { _additionalEscrow = value; } }
        private Value<decimal?> _additionalPrincipal;
        public decimal? AdditionalPrincipal { get { return _additionalPrincipal; } set { _additionalPrincipal = value; } }
        private Value<decimal?> _buydownSubsidyAmount;
        public decimal? BuydownSubsidyAmount { get { return _buydownSubsidyAmount; } set { _buydownSubsidyAmount = value; } }
        private Value<string> _checkNumber;
        public string CheckNumber { get { return _checkNumber; } set { _checkNumber = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<decimal?> _commonAmount;
        public decimal? CommonAmount { get { return _commonAmount; } set { _commonAmount = value; } }
        private Value<DateTime?> _commonDate;
        public DateTime? CommonDate { get { return _commonDate; } set { _commonDate = value; } }
        private Value<string> _createdById;
        public string CreatedById { get { return _createdById; } set { _createdById = value; } }
        private Value<string> _createdByName;
        public string CreatedByName { get { return _createdByName; } set { _createdByName = value; } }
        private Value<DateTime?> _createdDateTimeUtc;
        public DateTime? CreatedDateTimeUtc { get { return _createdDateTimeUtc; } set { _createdDateTimeUtc = value; } }
        private Value<decimal?> _escrow;
        public decimal? Escrow { get { return _escrow; } set { _escrow = value; } }
        private Value<decimal?> _escrowCityPropertyTax;
        public decimal? EscrowCityPropertyTax { get { return _escrowCityPropertyTax; } set { _escrowCityPropertyTax = value; } }
        private Value<decimal?> _escrowFloodInsurance;
        public decimal? EscrowFloodInsurance { get { return _escrowFloodInsurance; } set { _escrowFloodInsurance = value; } }
        private Value<decimal?> _escrowHazardInsurance;
        public decimal? EscrowHazardInsurance { get { return _escrowHazardInsurance; } set { _escrowHazardInsurance = value; } }
        private Value<decimal?> _escrowMortgageInsurance;
        public decimal? EscrowMortgageInsurance { get { return _escrowMortgageInsurance; } set { _escrowMortgageInsurance = value; } }
        private Value<decimal?> _escrowOther1;
        public decimal? EscrowOther1 { get { return _escrowOther1; } set { _escrowOther1 = value; } }
        private Value<decimal?> _escrowOther2;
        public decimal? EscrowOther2 { get { return _escrowOther2; } set { _escrowOther2 = value; } }
        private Value<decimal?> _escrowOther3;
        public decimal? EscrowOther3 { get { return _escrowOther3; } set { _escrowOther3 = value; } }
        private Value<decimal?> _escrowTax;
        public decimal? EscrowTax { get { return _escrowTax; } set { _escrowTax = value; } }
        private Value<decimal?> _escrowUSDAMonthlyPremium;
        public decimal? EscrowUSDAMonthlyPremium { get { return _escrowUSDAMonthlyPremium; } set { _escrowUSDAMonthlyPremium = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _indexRate;
        public decimal? IndexRate { get { return _indexRate; } set { _indexRate = value; } }
        private Value<string> _institutionName;
        public string InstitutionName { get { return _institutionName; } set { _institutionName = value; } }
        private Value<string> _institutionRouting;
        public string InstitutionRouting { get { return _institutionRouting; } set { _institutionRouting = value; } }
        private Value<decimal?> _interest;
        public decimal? Interest { get { return _interest; } set { _interest = value; } }
        private Value<decimal?> _interestRate;
        public decimal? InterestRate { get { return _interestRate; } set { _interestRate = value; } }
        private Value<decimal?> _lateFee;
        public decimal? LateFee { get { return _lateFee; } set { _lateFee = value; } }
        private Value<decimal?> _lateFeeIfLate;
        public decimal? LateFeeIfLate { get { return _lateFeeIfLate; } set { _lateFeeIfLate = value; } }
        private Value<DateTime?> _latePaymentDate;
        public DateTime? LatePaymentDate { get { return _latePaymentDate; } set { _latePaymentDate = value; } }
        private Value<decimal?> _miscFee;
        public decimal? MiscFee { get { return _miscFee; } set { _miscFee = value; } }
        private Value<string> _modifiedById;
        public string ModifiedById { get { return _modifiedById; } set { _modifiedById = value; } }
        private Value<string> _modifiedByName;
        public string ModifiedByName { get { return _modifiedByName; } set { _modifiedByName = value; } }
        private Value<DateTime?> _modifiedDateTimeUtc;
        public DateTime? ModifiedDateTimeUtc { get { return _modifiedDateTimeUtc; } set { _modifiedDateTimeUtc = value; } }
        private Value<DateTime?> _paymentDepositedDate;
        public DateTime? PaymentDepositedDate { get { return _paymentDepositedDate; } set { _paymentDepositedDate = value; } }
        private Value<DateTime?> _paymentDueDate;
        public DateTime? PaymentDueDate { get { return _paymentDueDate; } set { _paymentDueDate = value; } }
        private Value<DateTime?> _paymentIndexDate;
        public DateTime? PaymentIndexDate { get { return _paymentIndexDate; } set { _paymentIndexDate = value; } }
        private Value<int?> _paymentNumber;
        public int? PaymentNumber { get { return _paymentNumber; } set { _paymentNumber = value; } }
        private Value<DateTime?> _paymentReceivedDate;
        public DateTime? PaymentReceivedDate { get { return _paymentReceivedDate; } set { _paymentReceivedDate = value; } }
        private Value<decimal?> _principal;
        public decimal? Principal { get { return _principal; } set { _principal = value; } }
        private Value<string> _reference;
        public string Reference { get { return _reference; } set { _reference = value; } }
        private Value<decimal?> _schedulePayLogMiscFee;
        public decimal? SchedulePayLogMiscFee { get { return _schedulePayLogMiscFee; } set { _schedulePayLogMiscFee = value; } }
        private Value<string> _servicingPaymentMethod;
        public string ServicingPaymentMethod { get { return _servicingPaymentMethod; } set { _servicingPaymentMethod = value; } }
        private Value<string> _servicingTransactionType;
        public string ServicingTransactionType { get { return _servicingTransactionType; } set { _servicingTransactionType = value; } }
        private Value<DateTime?> _statementDate;
        public DateTime? StatementDate { get { return _statementDate; } set { _statementDate = value; } }
        private Value<decimal?> _totalAmountDue;
        public decimal? TotalAmountDue { get { return _totalAmountDue; } set { _totalAmountDue = value; } }
        private Value<decimal?> _totalAmountReceived;
        public decimal? TotalAmountReceived { get { return _totalAmountReceived; } set { _totalAmountReceived = value; } }
        private Value<decimal?> _transactionAmount;
        public decimal? TransactionAmount { get { return _transactionAmount; } set { _transactionAmount = value; } }
        private Value<DateTime?> _transactionDate;
        public DateTime? TransactionDate { get { return _transactionDate; } set { _transactionDate = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _accountHolder.Dirty
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
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}