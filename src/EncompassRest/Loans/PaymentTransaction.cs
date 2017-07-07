using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class PaymentTransaction : IClean
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
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _accountHolder.Clean
                    && _accountNumber.Clean
                    && _additionalEscrow.Clean
                    && _additionalPrincipal.Clean
                    && _buydownSubsidyAmount.Clean
                    && _checkNumber.Clean
                    && _comments.Clean
                    && _commonAmount.Clean
                    && _commonDate.Clean
                    && _createdById.Clean
                    && _createdByName.Clean
                    && _createdDateTimeUtc.Clean
                    && _escrow.Clean
                    && _escrowCityPropertyTax.Clean
                    && _escrowFloodInsurance.Clean
                    && _escrowHazardInsurance.Clean
                    && _escrowMortgageInsurance.Clean
                    && _escrowOther1.Clean
                    && _escrowOther2.Clean
                    && _escrowOther3.Clean
                    && _escrowTax.Clean
                    && _escrowUSDAMonthlyPremium.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _indexRate.Clean
                    && _institutionName.Clean
                    && _institutionRouting.Clean
                    && _interest.Clean
                    && _interestRate.Clean
                    && _lateFee.Clean
                    && _lateFeeIfLate.Clean
                    && _latePaymentDate.Clean
                    && _miscFee.Clean
                    && _modifiedById.Clean
                    && _modifiedByName.Clean
                    && _modifiedDateTimeUtc.Clean
                    && _paymentDepositedDate.Clean
                    && _paymentDueDate.Clean
                    && _paymentIndexDate.Clean
                    && _paymentNumber.Clean
                    && _paymentReceivedDate.Clean
                    && _principal.Clean
                    && _reference.Clean
                    && _schedulePayLogMiscFee.Clean
                    && _servicingPaymentMethod.Clean
                    && _servicingTransactionType.Clean
                    && _statementDate.Clean
                    && _totalAmountDue.Clean
                    && _totalAmountReceived.Clean
                    && _transactionAmount.Clean
                    && _transactionDate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var accountHolder = _accountHolder; accountHolder.Clean = value; _accountHolder = accountHolder;
                var accountNumber = _accountNumber; accountNumber.Clean = value; _accountNumber = accountNumber;
                var additionalEscrow = _additionalEscrow; additionalEscrow.Clean = value; _additionalEscrow = additionalEscrow;
                var additionalPrincipal = _additionalPrincipal; additionalPrincipal.Clean = value; _additionalPrincipal = additionalPrincipal;
                var buydownSubsidyAmount = _buydownSubsidyAmount; buydownSubsidyAmount.Clean = value; _buydownSubsidyAmount = buydownSubsidyAmount;
                var checkNumber = _checkNumber; checkNumber.Clean = value; _checkNumber = checkNumber;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var commonAmount = _commonAmount; commonAmount.Clean = value; _commonAmount = commonAmount;
                var commonDate = _commonDate; commonDate.Clean = value; _commonDate = commonDate;
                var createdById = _createdById; createdById.Clean = value; _createdById = createdById;
                var createdByName = _createdByName; createdByName.Clean = value; _createdByName = createdByName;
                var createdDateTimeUtc = _createdDateTimeUtc; createdDateTimeUtc.Clean = value; _createdDateTimeUtc = createdDateTimeUtc;
                var escrow = _escrow; escrow.Clean = value; _escrow = escrow;
                var escrowCityPropertyTax = _escrowCityPropertyTax; escrowCityPropertyTax.Clean = value; _escrowCityPropertyTax = escrowCityPropertyTax;
                var escrowFloodInsurance = _escrowFloodInsurance; escrowFloodInsurance.Clean = value; _escrowFloodInsurance = escrowFloodInsurance;
                var escrowHazardInsurance = _escrowHazardInsurance; escrowHazardInsurance.Clean = value; _escrowHazardInsurance = escrowHazardInsurance;
                var escrowMortgageInsurance = _escrowMortgageInsurance; escrowMortgageInsurance.Clean = value; _escrowMortgageInsurance = escrowMortgageInsurance;
                var escrowOther1 = _escrowOther1; escrowOther1.Clean = value; _escrowOther1 = escrowOther1;
                var escrowOther2 = _escrowOther2; escrowOther2.Clean = value; _escrowOther2 = escrowOther2;
                var escrowOther3 = _escrowOther3; escrowOther3.Clean = value; _escrowOther3 = escrowOther3;
                var escrowTax = _escrowTax; escrowTax.Clean = value; _escrowTax = escrowTax;
                var escrowUSDAMonthlyPremium = _escrowUSDAMonthlyPremium; escrowUSDAMonthlyPremium.Clean = value; _escrowUSDAMonthlyPremium = escrowUSDAMonthlyPremium;
                var guid = _guid; guid.Clean = value; _guid = guid;
                var id = _id; id.Clean = value; _id = id;
                var indexRate = _indexRate; indexRate.Clean = value; _indexRate = indexRate;
                var institutionName = _institutionName; institutionName.Clean = value; _institutionName = institutionName;
                var institutionRouting = _institutionRouting; institutionRouting.Clean = value; _institutionRouting = institutionRouting;
                var interest = _interest; interest.Clean = value; _interest = interest;
                var interestRate = _interestRate; interestRate.Clean = value; _interestRate = interestRate;
                var lateFee = _lateFee; lateFee.Clean = value; _lateFee = lateFee;
                var lateFeeIfLate = _lateFeeIfLate; lateFeeIfLate.Clean = value; _lateFeeIfLate = lateFeeIfLate;
                var latePaymentDate = _latePaymentDate; latePaymentDate.Clean = value; _latePaymentDate = latePaymentDate;
                var miscFee = _miscFee; miscFee.Clean = value; _miscFee = miscFee;
                var modifiedById = _modifiedById; modifiedById.Clean = value; _modifiedById = modifiedById;
                var modifiedByName = _modifiedByName; modifiedByName.Clean = value; _modifiedByName = modifiedByName;
                var modifiedDateTimeUtc = _modifiedDateTimeUtc; modifiedDateTimeUtc.Clean = value; _modifiedDateTimeUtc = modifiedDateTimeUtc;
                var paymentDepositedDate = _paymentDepositedDate; paymentDepositedDate.Clean = value; _paymentDepositedDate = paymentDepositedDate;
                var paymentDueDate = _paymentDueDate; paymentDueDate.Clean = value; _paymentDueDate = paymentDueDate;
                var paymentIndexDate = _paymentIndexDate; paymentIndexDate.Clean = value; _paymentIndexDate = paymentIndexDate;
                var paymentNumber = _paymentNumber; paymentNumber.Clean = value; _paymentNumber = paymentNumber;
                var paymentReceivedDate = _paymentReceivedDate; paymentReceivedDate.Clean = value; _paymentReceivedDate = paymentReceivedDate;
                var principal = _principal; principal.Clean = value; _principal = principal;
                var reference = _reference; reference.Clean = value; _reference = reference;
                var schedulePayLogMiscFee = _schedulePayLogMiscFee; schedulePayLogMiscFee.Clean = value; _schedulePayLogMiscFee = schedulePayLogMiscFee;
                var servicingPaymentMethod = _servicingPaymentMethod; servicingPaymentMethod.Clean = value; _servicingPaymentMethod = servicingPaymentMethod;
                var servicingTransactionType = _servicingTransactionType; servicingTransactionType.Clean = value; _servicingTransactionType = servicingTransactionType;
                var statementDate = _statementDate; statementDate.Clean = value; _statementDate = statementDate;
                var totalAmountDue = _totalAmountDue; totalAmountDue.Clean = value; _totalAmountDue = totalAmountDue;
                var totalAmountReceived = _totalAmountReceived; totalAmountReceived.Clean = value; _totalAmountReceived = totalAmountReceived;
                var transactionAmount = _transactionAmount; transactionAmount.Clean = value; _transactionAmount = transactionAmount;
                var transactionDate = _transactionDate; transactionDate.Clean = value; _transactionDate = transactionDate;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public PaymentTransaction()
        {
            Clean = true;
        }
    }
}