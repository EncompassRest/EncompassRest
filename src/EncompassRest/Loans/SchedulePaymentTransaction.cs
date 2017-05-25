using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class SchedulePaymentTransaction : IClean
    {
        private Value<decimal?> _additionalEscrow;
        public decimal? AdditionalEscrow { get { return _additionalEscrow; } set { _additionalEscrow = value; } }
        private Value<decimal?> _additionalPrincipal;
        public decimal? AdditionalPrincipal { get { return _additionalPrincipal; } set { _additionalPrincipal = value; } }
        private Value<decimal?> _buydownSubsidyAmount;
        public decimal? BuydownSubsidyAmount { get { return _buydownSubsidyAmount; } set { _buydownSubsidyAmount = value; } }
        private Value<decimal?> _buydownSubsidyAmountDue;
        public decimal? BuydownSubsidyAmountDue { get { return _buydownSubsidyAmountDue; } set { _buydownSubsidyAmountDue = value; } }
        private Value<decimal?> _cityPropertyTax;
        public decimal? CityPropertyTax { get { return _cityPropertyTax; } set { _cityPropertyTax = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<string> _createdById;
        public string CreatedById { get { return _createdById; } set { _createdById = value; } }
        private Value<string> _createdByName;
        public string CreatedByName { get { return _createdByName; } set { _createdByName = value; } }
        private Value<DateTime?> _createdDateTimeUtc;
        public DateTime? CreatedDateTimeUtc { get { return _createdDateTimeUtc; } set { _createdDateTimeUtc = value; } }
        private Value<decimal?> _escrow;
        public decimal? Escrow { get { return _escrow; } set { _escrow = value; } }
        private Value<decimal?> _escrowCityPropertyTaxDue;
        public decimal? EscrowCityPropertyTaxDue { get { return _escrowCityPropertyTaxDue; } set { _escrowCityPropertyTaxDue = value; } }
        private Value<decimal?> _escrowDue;
        public decimal? EscrowDue { get { return _escrowDue; } set { _escrowDue = value; } }
        private Value<decimal?> _escrowFloodInsuranceDue;
        public decimal? EscrowFloodInsuranceDue { get { return _escrowFloodInsuranceDue; } set { _escrowFloodInsuranceDue = value; } }
        private Value<decimal?> _escrowHazardInsuranceDue;
        public decimal? EscrowHazardInsuranceDue { get { return _escrowHazardInsuranceDue; } set { _escrowHazardInsuranceDue = value; } }
        private Value<decimal?> _escrowMortgageInsuranceDue;
        public decimal? EscrowMortgageInsuranceDue { get { return _escrowMortgageInsuranceDue; } set { _escrowMortgageInsuranceDue = value; } }
        private Value<decimal?> _escrowOther1Due;
        public decimal? EscrowOther1Due { get { return _escrowOther1Due; } set { _escrowOther1Due = value; } }
        private Value<decimal?> _escrowOther2Due;
        public decimal? EscrowOther2Due { get { return _escrowOther2Due; } set { _escrowOther2Due = value; } }
        private Value<decimal?> _escrowOther3Due;
        public decimal? EscrowOther3Due { get { return _escrowOther3Due; } set { _escrowOther3Due = value; } }
        private Value<decimal?> _escrowTaxDue;
        public decimal? EscrowTaxDue { get { return _escrowTaxDue; } set { _escrowTaxDue = value; } }
        private Value<decimal?> _escrowUSDAMonthlyPremiumDue;
        public decimal? EscrowUSDAMonthlyPremiumDue { get { return _escrowUSDAMonthlyPremiumDue; } set { _escrowUSDAMonthlyPremiumDue = value; } }
        private Value<decimal?> _floodInsurance;
        public decimal? FloodInsurance { get { return _floodInsurance; } set { _floodInsurance = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<decimal?> _hazardInsurance;
        public decimal? HazardInsurance { get { return _hazardInsurance; } set { _hazardInsurance = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _indexRate;
        public decimal? IndexRate { get { return _indexRate; } set { _indexRate = value; } }
        private Value<decimal?> _interest;
        public decimal? Interest { get { return _interest; } set { _interest = value; } }
        private Value<decimal?> _interestDue;
        public decimal? InterestDue { get { return _interestDue; } set { _interestDue = value; } }
        private Value<decimal?> _interestRate;
        public decimal? InterestRate { get { return _interestRate; } set { _interestRate = value; } }
        private Value<decimal?> _lateFee;
        public decimal? LateFee { get { return _lateFee; } set { _lateFee = value; } }
        private Value<DateTime?> _latePaymentDate;
        public DateTime? LatePaymentDate { get { return _latePaymentDate; } set { _latePaymentDate = value; } }
        private Value<decimal?> _miscFee;
        public decimal? MiscFee { get { return _miscFee; } set { _miscFee = value; } }
        private Value<decimal?> _miscFeeDue;
        public decimal? MiscFeeDue { get { return _miscFeeDue; } set { _miscFeeDue = value; } }
        private Value<string> _modifiedById;
        public string ModifiedById { get { return _modifiedById; } set { _modifiedById = value; } }
        private Value<string> _modifiedByName;
        public string ModifiedByName { get { return _modifiedByName; } set { _modifiedByName = value; } }
        private Value<DateTime?> _modifiedDateTimeUtc;
        public DateTime? ModifiedDateTimeUtc { get { return _modifiedDateTimeUtc; } set { _modifiedDateTimeUtc = value; } }
        private Value<decimal?> _mortgageInsurance;
        public decimal? MortgageInsurance { get { return _mortgageInsurance; } set { _mortgageInsurance = value; } }
        private Value<decimal?> _other1Escrow;
        public decimal? Other1Escrow { get { return _other1Escrow; } set { _other1Escrow = value; } }
        private Value<decimal?> _other2Escrow;
        public decimal? Other2Escrow { get { return _other2Escrow; } set { _other2Escrow = value; } }
        private Value<decimal?> _other3Escrow;
        public decimal? Other3Escrow { get { return _other3Escrow; } set { _other3Escrow = value; } }
        private Value<int?> _paymentNumber;
        public int? PaymentNumber { get { return _paymentNumber; } set { _paymentNumber = value; } }
        private Value<DateTime?> _paymentReceiveDate;
        public DateTime? PaymentReceiveDate { get { return _paymentReceiveDate; } set { _paymentReceiveDate = value; } }
        private Value<decimal?> _principal;
        public decimal? Principal { get { return _principal; } set { _principal = value; } }
        private Value<decimal?> _principalDue;
        public decimal? PrincipalDue { get { return _principalDue; } set { _principalDue = value; } }
        private Value<string> _servicingPaymentMethod;
        public string ServicingPaymentMethod { get { return _servicingPaymentMethod; } set { _servicingPaymentMethod = value; } }
        private Value<string> _servicingTransactionType;
        public string ServicingTransactionType { get { return _servicingTransactionType; } set { _servicingTransactionType = value; } }
        private Value<decimal?> _taxes;
        public decimal? Taxes { get { return _taxes; } set { _taxes = value; } }
        private Value<decimal?> _totalPastDue;
        public decimal? TotalPastDue { get { return _totalPastDue; } set { _totalPastDue = value; } }
        private Value<decimal?> _transactionAmount;
        public decimal? TransactionAmount { get { return _transactionAmount; } set { _transactionAmount = value; } }
        private Value<DateTime?> _transactionDate;
        public DateTime? TransactionDate { get { return _transactionDate; } set { _transactionDate = value; } }
        private Value<decimal?> _unpaidLateFeeDue;
        public decimal? UnpaidLateFeeDue { get { return _unpaidLateFeeDue; } set { _unpaidLateFeeDue = value; } }
        private Value<decimal?> _uSDAMonthlyPremium;
        public decimal? USDAMonthlyPremium { get { return _uSDAMonthlyPremium; } set { _uSDAMonthlyPremium = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _additionalEscrow.Clean
                    && _additionalPrincipal.Clean
                    && _buydownSubsidyAmount.Clean
                    && _buydownSubsidyAmountDue.Clean
                    && _cityPropertyTax.Clean
                    && _comments.Clean
                    && _createdById.Clean
                    && _createdByName.Clean
                    && _createdDateTimeUtc.Clean
                    && _escrow.Clean
                    && _escrowCityPropertyTaxDue.Clean
                    && _escrowDue.Clean
                    && _escrowFloodInsuranceDue.Clean
                    && _escrowHazardInsuranceDue.Clean
                    && _escrowMortgageInsuranceDue.Clean
                    && _escrowOther1Due.Clean
                    && _escrowOther2Due.Clean
                    && _escrowOther3Due.Clean
                    && _escrowTaxDue.Clean
                    && _escrowUSDAMonthlyPremiumDue.Clean
                    && _floodInsurance.Clean
                    && _guid.Clean
                    && _hazardInsurance.Clean
                    && _id.Clean
                    && _indexRate.Clean
                    && _interest.Clean
                    && _interestDue.Clean
                    && _interestRate.Clean
                    && _lateFee.Clean
                    && _latePaymentDate.Clean
                    && _miscFee.Clean
                    && _miscFeeDue.Clean
                    && _modifiedById.Clean
                    && _modifiedByName.Clean
                    && _modifiedDateTimeUtc.Clean
                    && _mortgageInsurance.Clean
                    && _other1Escrow.Clean
                    && _other2Escrow.Clean
                    && _other3Escrow.Clean
                    && _paymentNumber.Clean
                    && _paymentReceiveDate.Clean
                    && _principal.Clean
                    && _principalDue.Clean
                    && _servicingPaymentMethod.Clean
                    && _servicingTransactionType.Clean
                    && _taxes.Clean
                    && _totalPastDue.Clean
                    && _transactionAmount.Clean
                    && _transactionDate.Clean
                    && _unpaidLateFeeDue.Clean
                    && _uSDAMonthlyPremium.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _additionalEscrow; v0.Clean = value; _additionalEscrow = v0;
                var v1 = _additionalPrincipal; v1.Clean = value; _additionalPrincipal = v1;
                var v2 = _buydownSubsidyAmount; v2.Clean = value; _buydownSubsidyAmount = v2;
                var v3 = _buydownSubsidyAmountDue; v3.Clean = value; _buydownSubsidyAmountDue = v3;
                var v4 = _cityPropertyTax; v4.Clean = value; _cityPropertyTax = v4;
                var v5 = _comments; v5.Clean = value; _comments = v5;
                var v6 = _createdById; v6.Clean = value; _createdById = v6;
                var v7 = _createdByName; v7.Clean = value; _createdByName = v7;
                var v8 = _createdDateTimeUtc; v8.Clean = value; _createdDateTimeUtc = v8;
                var v9 = _escrow; v9.Clean = value; _escrow = v9;
                var v10 = _escrowCityPropertyTaxDue; v10.Clean = value; _escrowCityPropertyTaxDue = v10;
                var v11 = _escrowDue; v11.Clean = value; _escrowDue = v11;
                var v12 = _escrowFloodInsuranceDue; v12.Clean = value; _escrowFloodInsuranceDue = v12;
                var v13 = _escrowHazardInsuranceDue; v13.Clean = value; _escrowHazardInsuranceDue = v13;
                var v14 = _escrowMortgageInsuranceDue; v14.Clean = value; _escrowMortgageInsuranceDue = v14;
                var v15 = _escrowOther1Due; v15.Clean = value; _escrowOther1Due = v15;
                var v16 = _escrowOther2Due; v16.Clean = value; _escrowOther2Due = v16;
                var v17 = _escrowOther3Due; v17.Clean = value; _escrowOther3Due = v17;
                var v18 = _escrowTaxDue; v18.Clean = value; _escrowTaxDue = v18;
                var v19 = _escrowUSDAMonthlyPremiumDue; v19.Clean = value; _escrowUSDAMonthlyPremiumDue = v19;
                var v20 = _floodInsurance; v20.Clean = value; _floodInsurance = v20;
                var v21 = _guid; v21.Clean = value; _guid = v21;
                var v22 = _hazardInsurance; v22.Clean = value; _hazardInsurance = v22;
                var v23 = _id; v23.Clean = value; _id = v23;
                var v24 = _indexRate; v24.Clean = value; _indexRate = v24;
                var v25 = _interest; v25.Clean = value; _interest = v25;
                var v26 = _interestDue; v26.Clean = value; _interestDue = v26;
                var v27 = _interestRate; v27.Clean = value; _interestRate = v27;
                var v28 = _lateFee; v28.Clean = value; _lateFee = v28;
                var v29 = _latePaymentDate; v29.Clean = value; _latePaymentDate = v29;
                var v30 = _miscFee; v30.Clean = value; _miscFee = v30;
                var v31 = _miscFeeDue; v31.Clean = value; _miscFeeDue = v31;
                var v32 = _modifiedById; v32.Clean = value; _modifiedById = v32;
                var v33 = _modifiedByName; v33.Clean = value; _modifiedByName = v33;
                var v34 = _modifiedDateTimeUtc; v34.Clean = value; _modifiedDateTimeUtc = v34;
                var v35 = _mortgageInsurance; v35.Clean = value; _mortgageInsurance = v35;
                var v36 = _other1Escrow; v36.Clean = value; _other1Escrow = v36;
                var v37 = _other2Escrow; v37.Clean = value; _other2Escrow = v37;
                var v38 = _other3Escrow; v38.Clean = value; _other3Escrow = v38;
                var v39 = _paymentNumber; v39.Clean = value; _paymentNumber = v39;
                var v40 = _paymentReceiveDate; v40.Clean = value; _paymentReceiveDate = v40;
                var v41 = _principal; v41.Clean = value; _principal = v41;
                var v42 = _principalDue; v42.Clean = value; _principalDue = v42;
                var v43 = _servicingPaymentMethod; v43.Clean = value; _servicingPaymentMethod = v43;
                var v44 = _servicingTransactionType; v44.Clean = value; _servicingTransactionType = v44;
                var v45 = _taxes; v45.Clean = value; _taxes = v45;
                var v46 = _totalPastDue; v46.Clean = value; _totalPastDue = v46;
                var v47 = _transactionAmount; v47.Clean = value; _transactionAmount = v47;
                var v48 = _transactionDate; v48.Clean = value; _transactionDate = v48;
                var v49 = _unpaidLateFeeDue; v49.Clean = value; _unpaidLateFeeDue = v49;
                var v50 = _uSDAMonthlyPremium; v50.Clean = value; _uSDAMonthlyPremium = v50;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}