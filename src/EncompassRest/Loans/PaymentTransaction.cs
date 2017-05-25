using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

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
                var v0 = _accountHolder; v0.Clean = value; _accountHolder = v0;
                var v1 = _accountNumber; v1.Clean = value; _accountNumber = v1;
                var v2 = _additionalEscrow; v2.Clean = value; _additionalEscrow = v2;
                var v3 = _additionalPrincipal; v3.Clean = value; _additionalPrincipal = v3;
                var v4 = _buydownSubsidyAmount; v4.Clean = value; _buydownSubsidyAmount = v4;
                var v5 = _checkNumber; v5.Clean = value; _checkNumber = v5;
                var v6 = _comments; v6.Clean = value; _comments = v6;
                var v7 = _commonAmount; v7.Clean = value; _commonAmount = v7;
                var v8 = _commonDate; v8.Clean = value; _commonDate = v8;
                var v9 = _createdById; v9.Clean = value; _createdById = v9;
                var v10 = _createdByName; v10.Clean = value; _createdByName = v10;
                var v11 = _createdDateTimeUtc; v11.Clean = value; _createdDateTimeUtc = v11;
                var v12 = _escrow; v12.Clean = value; _escrow = v12;
                var v13 = _escrowCityPropertyTax; v13.Clean = value; _escrowCityPropertyTax = v13;
                var v14 = _escrowFloodInsurance; v14.Clean = value; _escrowFloodInsurance = v14;
                var v15 = _escrowHazardInsurance; v15.Clean = value; _escrowHazardInsurance = v15;
                var v16 = _escrowMortgageInsurance; v16.Clean = value; _escrowMortgageInsurance = v16;
                var v17 = _escrowOther1; v17.Clean = value; _escrowOther1 = v17;
                var v18 = _escrowOther2; v18.Clean = value; _escrowOther2 = v18;
                var v19 = _escrowOther3; v19.Clean = value; _escrowOther3 = v19;
                var v20 = _escrowTax; v20.Clean = value; _escrowTax = v20;
                var v21 = _escrowUSDAMonthlyPremium; v21.Clean = value; _escrowUSDAMonthlyPremium = v21;
                var v22 = _guid; v22.Clean = value; _guid = v22;
                var v23 = _id; v23.Clean = value; _id = v23;
                var v24 = _indexRate; v24.Clean = value; _indexRate = v24;
                var v25 = _institutionName; v25.Clean = value; _institutionName = v25;
                var v26 = _institutionRouting; v26.Clean = value; _institutionRouting = v26;
                var v27 = _interest; v27.Clean = value; _interest = v27;
                var v28 = _interestRate; v28.Clean = value; _interestRate = v28;
                var v29 = _lateFee; v29.Clean = value; _lateFee = v29;
                var v30 = _lateFeeIfLate; v30.Clean = value; _lateFeeIfLate = v30;
                var v31 = _latePaymentDate; v31.Clean = value; _latePaymentDate = v31;
                var v32 = _miscFee; v32.Clean = value; _miscFee = v32;
                var v33 = _modifiedById; v33.Clean = value; _modifiedById = v33;
                var v34 = _modifiedByName; v34.Clean = value; _modifiedByName = v34;
                var v35 = _modifiedDateTimeUtc; v35.Clean = value; _modifiedDateTimeUtc = v35;
                var v36 = _paymentDepositedDate; v36.Clean = value; _paymentDepositedDate = v36;
                var v37 = _paymentDueDate; v37.Clean = value; _paymentDueDate = v37;
                var v38 = _paymentIndexDate; v38.Clean = value; _paymentIndexDate = v38;
                var v39 = _paymentNumber; v39.Clean = value; _paymentNumber = v39;
                var v40 = _paymentReceivedDate; v40.Clean = value; _paymentReceivedDate = v40;
                var v41 = _principal; v41.Clean = value; _principal = v41;
                var v42 = _reference; v42.Clean = value; _reference = v42;
                var v43 = _schedulePayLogMiscFee; v43.Clean = value; _schedulePayLogMiscFee = v43;
                var v44 = _servicingPaymentMethod; v44.Clean = value; _servicingPaymentMethod = v44;
                var v45 = _servicingTransactionType; v45.Clean = value; _servicingTransactionType = v45;
                var v46 = _statementDate; v46.Clean = value; _statementDate = v46;
                var v47 = _totalAmountDue; v47.Clean = value; _totalAmountDue = v47;
                var v48 = _totalAmountReceived; v48.Clean = value; _totalAmountReceived = v48;
                var v49 = _transactionAmount; v49.Clean = value; _transactionAmount = v49;
                var v50 = _transactionDate; v50.Clean = value; _transactionDate = v50;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}