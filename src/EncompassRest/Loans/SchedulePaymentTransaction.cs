using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class SchedulePaymentTransaction : IDirty
    {
        private DirtyValue<decimal?> _additionalEscrow;
        public decimal? AdditionalEscrow { get { return _additionalEscrow; } set { _additionalEscrow = value; } }
        private DirtyValue<decimal?> _additionalPrincipal;
        public decimal? AdditionalPrincipal { get { return _additionalPrincipal; } set { _additionalPrincipal = value; } }
        private DirtyValue<decimal?> _buydownSubsidyAmount;
        public decimal? BuydownSubsidyAmount { get { return _buydownSubsidyAmount; } set { _buydownSubsidyAmount = value; } }
        private DirtyValue<decimal?> _buydownSubsidyAmountDue;
        public decimal? BuydownSubsidyAmountDue { get { return _buydownSubsidyAmountDue; } set { _buydownSubsidyAmountDue = value; } }
        private DirtyValue<decimal?> _cityPropertyTax;
        public decimal? CityPropertyTax { get { return _cityPropertyTax; } set { _cityPropertyTax = value; } }
        private DirtyValue<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private DirtyValue<string> _createdById;
        public string CreatedById { get { return _createdById; } set { _createdById = value; } }
        private DirtyValue<string> _createdByName;
        public string CreatedByName { get { return _createdByName; } set { _createdByName = value; } }
        private DirtyValue<DateTime?> _createdDateTimeUtc;
        public DateTime? CreatedDateTimeUtc { get { return _createdDateTimeUtc; } set { _createdDateTimeUtc = value; } }
        private DirtyValue<decimal?> _escrow;
        public decimal? Escrow { get { return _escrow; } set { _escrow = value; } }
        private DirtyValue<decimal?> _escrowCityPropertyTaxDue;
        public decimal? EscrowCityPropertyTaxDue { get { return _escrowCityPropertyTaxDue; } set { _escrowCityPropertyTaxDue = value; } }
        private DirtyValue<decimal?> _escrowDue;
        public decimal? EscrowDue { get { return _escrowDue; } set { _escrowDue = value; } }
        private DirtyValue<decimal?> _escrowFloodInsuranceDue;
        public decimal? EscrowFloodInsuranceDue { get { return _escrowFloodInsuranceDue; } set { _escrowFloodInsuranceDue = value; } }
        private DirtyValue<decimal?> _escrowHazardInsuranceDue;
        public decimal? EscrowHazardInsuranceDue { get { return _escrowHazardInsuranceDue; } set { _escrowHazardInsuranceDue = value; } }
        private DirtyValue<decimal?> _escrowMortgageInsuranceDue;
        public decimal? EscrowMortgageInsuranceDue { get { return _escrowMortgageInsuranceDue; } set { _escrowMortgageInsuranceDue = value; } }
        private DirtyValue<decimal?> _escrowOther1Due;
        public decimal? EscrowOther1Due { get { return _escrowOther1Due; } set { _escrowOther1Due = value; } }
        private DirtyValue<decimal?> _escrowOther2Due;
        public decimal? EscrowOther2Due { get { return _escrowOther2Due; } set { _escrowOther2Due = value; } }
        private DirtyValue<decimal?> _escrowOther3Due;
        public decimal? EscrowOther3Due { get { return _escrowOther3Due; } set { _escrowOther3Due = value; } }
        private DirtyValue<decimal?> _escrowTaxDue;
        public decimal? EscrowTaxDue { get { return _escrowTaxDue; } set { _escrowTaxDue = value; } }
        private DirtyValue<decimal?> _escrowUSDAMonthlyPremiumDue;
        public decimal? EscrowUSDAMonthlyPremiumDue { get { return _escrowUSDAMonthlyPremiumDue; } set { _escrowUSDAMonthlyPremiumDue = value; } }
        private DirtyValue<decimal?> _floodInsurance;
        public decimal? FloodInsurance { get { return _floodInsurance; } set { _floodInsurance = value; } }
        private DirtyValue<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private DirtyValue<decimal?> _hazardInsurance;
        public decimal? HazardInsurance { get { return _hazardInsurance; } set { _hazardInsurance = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _indexRate;
        public decimal? IndexRate { get { return _indexRate; } set { _indexRate = value; } }
        private DirtyValue<decimal?> _interest;
        public decimal? Interest { get { return _interest; } set { _interest = value; } }
        private DirtyValue<decimal?> _interestDue;
        public decimal? InterestDue { get { return _interestDue; } set { _interestDue = value; } }
        private DirtyValue<decimal?> _interestRate;
        public decimal? InterestRate { get { return _interestRate; } set { _interestRate = value; } }
        private DirtyValue<decimal?> _lateFee;
        public decimal? LateFee { get { return _lateFee; } set { _lateFee = value; } }
        private DirtyValue<DateTime?> _latePaymentDate;
        public DateTime? LatePaymentDate { get { return _latePaymentDate; } set { _latePaymentDate = value; } }
        private DirtyValue<decimal?> _miscFee;
        public decimal? MiscFee { get { return _miscFee; } set { _miscFee = value; } }
        private DirtyValue<decimal?> _miscFeeDue;
        public decimal? MiscFeeDue { get { return _miscFeeDue; } set { _miscFeeDue = value; } }
        private DirtyValue<string> _modifiedById;
        public string ModifiedById { get { return _modifiedById; } set { _modifiedById = value; } }
        private DirtyValue<string> _modifiedByName;
        public string ModifiedByName { get { return _modifiedByName; } set { _modifiedByName = value; } }
        private DirtyValue<DateTime?> _modifiedDateTimeUtc;
        public DateTime? ModifiedDateTimeUtc { get { return _modifiedDateTimeUtc; } set { _modifiedDateTimeUtc = value; } }
        private DirtyValue<decimal?> _mortgageInsurance;
        public decimal? MortgageInsurance { get { return _mortgageInsurance; } set { _mortgageInsurance = value; } }
        private DirtyValue<decimal?> _other1Escrow;
        public decimal? Other1Escrow { get { return _other1Escrow; } set { _other1Escrow = value; } }
        private DirtyValue<decimal?> _other2Escrow;
        public decimal? Other2Escrow { get { return _other2Escrow; } set { _other2Escrow = value; } }
        private DirtyValue<decimal?> _other3Escrow;
        public decimal? Other3Escrow { get { return _other3Escrow; } set { _other3Escrow = value; } }
        private DirtyValue<int?> _paymentNumber;
        public int? PaymentNumber { get { return _paymentNumber; } set { _paymentNumber = value; } }
        private DirtyValue<DateTime?> _paymentReceiveDate;
        public DateTime? PaymentReceiveDate { get { return _paymentReceiveDate; } set { _paymentReceiveDate = value; } }
        private DirtyValue<decimal?> _principal;
        public decimal? Principal { get { return _principal; } set { _principal = value; } }
        private DirtyValue<decimal?> _principalDue;
        public decimal? PrincipalDue { get { return _principalDue; } set { _principalDue = value; } }
        private DirtyValue<string> _servicingPaymentMethod;
        public string ServicingPaymentMethod { get { return _servicingPaymentMethod; } set { _servicingPaymentMethod = value; } }
        private DirtyValue<string> _servicingTransactionType;
        public string ServicingTransactionType { get { return _servicingTransactionType; } set { _servicingTransactionType = value; } }
        private DirtyValue<decimal?> _taxes;
        public decimal? Taxes { get { return _taxes; } set { _taxes = value; } }
        private DirtyValue<decimal?> _totalPastDue;
        public decimal? TotalPastDue { get { return _totalPastDue; } set { _totalPastDue = value; } }
        private DirtyValue<decimal?> _transactionAmount;
        public decimal? TransactionAmount { get { return _transactionAmount; } set { _transactionAmount = value; } }
        private DirtyValue<DateTime?> _transactionDate;
        public DateTime? TransactionDate { get { return _transactionDate; } set { _transactionDate = value; } }
        private DirtyValue<decimal?> _unpaidLateFeeDue;
        public decimal? UnpaidLateFeeDue { get { return _unpaidLateFeeDue; } set { _unpaidLateFeeDue = value; } }
        private DirtyValue<decimal?> _uSDAMonthlyPremium;
        public decimal? USDAMonthlyPremium { get { return _uSDAMonthlyPremium; } set { _uSDAMonthlyPremium = value; } }
        private ExtensionDataObject _extensionDataInternal;
        [JsonExtensionData]
        private ExtensionDataObject ExtensionDataInternal { get { return _extensionDataInternal ?? (_extensionDataInternal = new ExtensionDataObject()); } set { _extensionDataInternal = value; } }
        [JsonIgnore]
        public IDictionary<string, object> ExtensionData { get { return ExtensionDataInternal.InternalDictionary; } set { _extensionDataInternal = new ExtensionDataObject(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _additionalEscrow.Dirty
                    || _additionalPrincipal.Dirty
                    || _buydownSubsidyAmount.Dirty
                    || _buydownSubsidyAmountDue.Dirty
                    || _cityPropertyTax.Dirty
                    || _comments.Dirty
                    || _createdById.Dirty
                    || _createdByName.Dirty
                    || _createdDateTimeUtc.Dirty
                    || _escrow.Dirty
                    || _escrowCityPropertyTaxDue.Dirty
                    || _escrowDue.Dirty
                    || _escrowFloodInsuranceDue.Dirty
                    || _escrowHazardInsuranceDue.Dirty
                    || _escrowMortgageInsuranceDue.Dirty
                    || _escrowOther1Due.Dirty
                    || _escrowOther2Due.Dirty
                    || _escrowOther3Due.Dirty
                    || _escrowTaxDue.Dirty
                    || _escrowUSDAMonthlyPremiumDue.Dirty
                    || _floodInsurance.Dirty
                    || _guid.Dirty
                    || _hazardInsurance.Dirty
                    || _id.Dirty
                    || _indexRate.Dirty
                    || _interest.Dirty
                    || _interestDue.Dirty
                    || _interestRate.Dirty
                    || _lateFee.Dirty
                    || _latePaymentDate.Dirty
                    || _miscFee.Dirty
                    || _miscFeeDue.Dirty
                    || _modifiedById.Dirty
                    || _modifiedByName.Dirty
                    || _modifiedDateTimeUtc.Dirty
                    || _mortgageInsurance.Dirty
                    || _other1Escrow.Dirty
                    || _other2Escrow.Dirty
                    || _other3Escrow.Dirty
                    || _paymentNumber.Dirty
                    || _paymentReceiveDate.Dirty
                    || _principal.Dirty
                    || _principalDue.Dirty
                    || _servicingPaymentMethod.Dirty
                    || _servicingTransactionType.Dirty
                    || _taxes.Dirty
                    || _totalPastDue.Dirty
                    || _transactionAmount.Dirty
                    || _transactionDate.Dirty
                    || _unpaidLateFeeDue.Dirty
                    || _uSDAMonthlyPremium.Dirty
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _additionalEscrow.Dirty = value;
                _additionalPrincipal.Dirty = value;
                _buydownSubsidyAmount.Dirty = value;
                _buydownSubsidyAmountDue.Dirty = value;
                _cityPropertyTax.Dirty = value;
                _comments.Dirty = value;
                _createdById.Dirty = value;
                _createdByName.Dirty = value;
                _createdDateTimeUtc.Dirty = value;
                _escrow.Dirty = value;
                _escrowCityPropertyTaxDue.Dirty = value;
                _escrowDue.Dirty = value;
                _escrowFloodInsuranceDue.Dirty = value;
                _escrowHazardInsuranceDue.Dirty = value;
                _escrowMortgageInsuranceDue.Dirty = value;
                _escrowOther1Due.Dirty = value;
                _escrowOther2Due.Dirty = value;
                _escrowOther3Due.Dirty = value;
                _escrowTaxDue.Dirty = value;
                _escrowUSDAMonthlyPremiumDue.Dirty = value;
                _floodInsurance.Dirty = value;
                _guid.Dirty = value;
                _hazardInsurance.Dirty = value;
                _id.Dirty = value;
                _indexRate.Dirty = value;
                _interest.Dirty = value;
                _interestDue.Dirty = value;
                _interestRate.Dirty = value;
                _lateFee.Dirty = value;
                _latePaymentDate.Dirty = value;
                _miscFee.Dirty = value;
                _miscFeeDue.Dirty = value;
                _modifiedById.Dirty = value;
                _modifiedByName.Dirty = value;
                _modifiedDateTimeUtc.Dirty = value;
                _mortgageInsurance.Dirty = value;
                _other1Escrow.Dirty = value;
                _other2Escrow.Dirty = value;
                _other3Escrow.Dirty = value;
                _paymentNumber.Dirty = value;
                _paymentReceiveDate.Dirty = value;
                _principal.Dirty = value;
                _principalDue.Dirty = value;
                _servicingPaymentMethod.Dirty = value;
                _servicingTransactionType.Dirty = value;
                _taxes.Dirty = value;
                _totalPastDue.Dirty = value;
                _transactionAmount.Dirty = value;
                _transactionDate.Dirty = value;
                _unpaidLateFeeDue.Dirty = value;
                _uSDAMonthlyPremium.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}