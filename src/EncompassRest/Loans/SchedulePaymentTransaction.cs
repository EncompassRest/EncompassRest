using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
                var additionalEscrow = _additionalEscrow; additionalEscrow.Clean = value; _additionalEscrow = additionalEscrow;
                var additionalPrincipal = _additionalPrincipal; additionalPrincipal.Clean = value; _additionalPrincipal = additionalPrincipal;
                var buydownSubsidyAmount = _buydownSubsidyAmount; buydownSubsidyAmount.Clean = value; _buydownSubsidyAmount = buydownSubsidyAmount;
                var buydownSubsidyAmountDue = _buydownSubsidyAmountDue; buydownSubsidyAmountDue.Clean = value; _buydownSubsidyAmountDue = buydownSubsidyAmountDue;
                var cityPropertyTax = _cityPropertyTax; cityPropertyTax.Clean = value; _cityPropertyTax = cityPropertyTax;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var createdById = _createdById; createdById.Clean = value; _createdById = createdById;
                var createdByName = _createdByName; createdByName.Clean = value; _createdByName = createdByName;
                var createdDateTimeUtc = _createdDateTimeUtc; createdDateTimeUtc.Clean = value; _createdDateTimeUtc = createdDateTimeUtc;
                var escrow = _escrow; escrow.Clean = value; _escrow = escrow;
                var escrowCityPropertyTaxDue = _escrowCityPropertyTaxDue; escrowCityPropertyTaxDue.Clean = value; _escrowCityPropertyTaxDue = escrowCityPropertyTaxDue;
                var escrowDue = _escrowDue; escrowDue.Clean = value; _escrowDue = escrowDue;
                var escrowFloodInsuranceDue = _escrowFloodInsuranceDue; escrowFloodInsuranceDue.Clean = value; _escrowFloodInsuranceDue = escrowFloodInsuranceDue;
                var escrowHazardInsuranceDue = _escrowHazardInsuranceDue; escrowHazardInsuranceDue.Clean = value; _escrowHazardInsuranceDue = escrowHazardInsuranceDue;
                var escrowMortgageInsuranceDue = _escrowMortgageInsuranceDue; escrowMortgageInsuranceDue.Clean = value; _escrowMortgageInsuranceDue = escrowMortgageInsuranceDue;
                var escrowOther1Due = _escrowOther1Due; escrowOther1Due.Clean = value; _escrowOther1Due = escrowOther1Due;
                var escrowOther2Due = _escrowOther2Due; escrowOther2Due.Clean = value; _escrowOther2Due = escrowOther2Due;
                var escrowOther3Due = _escrowOther3Due; escrowOther3Due.Clean = value; _escrowOther3Due = escrowOther3Due;
                var escrowTaxDue = _escrowTaxDue; escrowTaxDue.Clean = value; _escrowTaxDue = escrowTaxDue;
                var escrowUSDAMonthlyPremiumDue = _escrowUSDAMonthlyPremiumDue; escrowUSDAMonthlyPremiumDue.Clean = value; _escrowUSDAMonthlyPremiumDue = escrowUSDAMonthlyPremiumDue;
                var floodInsurance = _floodInsurance; floodInsurance.Clean = value; _floodInsurance = floodInsurance;
                var guid = _guid; guid.Clean = value; _guid = guid;
                var hazardInsurance = _hazardInsurance; hazardInsurance.Clean = value; _hazardInsurance = hazardInsurance;
                var id = _id; id.Clean = value; _id = id;
                var indexRate = _indexRate; indexRate.Clean = value; _indexRate = indexRate;
                var interest = _interest; interest.Clean = value; _interest = interest;
                var interestDue = _interestDue; interestDue.Clean = value; _interestDue = interestDue;
                var interestRate = _interestRate; interestRate.Clean = value; _interestRate = interestRate;
                var lateFee = _lateFee; lateFee.Clean = value; _lateFee = lateFee;
                var latePaymentDate = _latePaymentDate; latePaymentDate.Clean = value; _latePaymentDate = latePaymentDate;
                var miscFee = _miscFee; miscFee.Clean = value; _miscFee = miscFee;
                var miscFeeDue = _miscFeeDue; miscFeeDue.Clean = value; _miscFeeDue = miscFeeDue;
                var modifiedById = _modifiedById; modifiedById.Clean = value; _modifiedById = modifiedById;
                var modifiedByName = _modifiedByName; modifiedByName.Clean = value; _modifiedByName = modifiedByName;
                var modifiedDateTimeUtc = _modifiedDateTimeUtc; modifiedDateTimeUtc.Clean = value; _modifiedDateTimeUtc = modifiedDateTimeUtc;
                var mortgageInsurance = _mortgageInsurance; mortgageInsurance.Clean = value; _mortgageInsurance = mortgageInsurance;
                var other1Escrow = _other1Escrow; other1Escrow.Clean = value; _other1Escrow = other1Escrow;
                var other2Escrow = _other2Escrow; other2Escrow.Clean = value; _other2Escrow = other2Escrow;
                var other3Escrow = _other3Escrow; other3Escrow.Clean = value; _other3Escrow = other3Escrow;
                var paymentNumber = _paymentNumber; paymentNumber.Clean = value; _paymentNumber = paymentNumber;
                var paymentReceiveDate = _paymentReceiveDate; paymentReceiveDate.Clean = value; _paymentReceiveDate = paymentReceiveDate;
                var principal = _principal; principal.Clean = value; _principal = principal;
                var principalDue = _principalDue; principalDue.Clean = value; _principalDue = principalDue;
                var servicingPaymentMethod = _servicingPaymentMethod; servicingPaymentMethod.Clean = value; _servicingPaymentMethod = servicingPaymentMethod;
                var servicingTransactionType = _servicingTransactionType; servicingTransactionType.Clean = value; _servicingTransactionType = servicingTransactionType;
                var taxes = _taxes; taxes.Clean = value; _taxes = taxes;
                var totalPastDue = _totalPastDue; totalPastDue.Clean = value; _totalPastDue = totalPastDue;
                var transactionAmount = _transactionAmount; transactionAmount.Clean = value; _transactionAmount = transactionAmount;
                var transactionDate = _transactionDate; transactionDate.Clean = value; _transactionDate = transactionDate;
                var unpaidLateFeeDue = _unpaidLateFeeDue; unpaidLateFeeDue.Clean = value; _unpaidLateFeeDue = unpaidLateFeeDue;
                var uSDAMonthlyPremium = _uSDAMonthlyPremium; uSDAMonthlyPremium.Clean = value; _uSDAMonthlyPremium = uSDAMonthlyPremium;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public SchedulePaymentTransaction()
        {
            Clean = true;
        }
    }
}