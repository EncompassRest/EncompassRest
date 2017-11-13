using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class Hud1EsPayTo : IDirty
    {
        private DirtyValue<string> _address;
        public string Address { get => _address; set => _address = value; }
        private DirtyValue<decimal?> _amountLastPay;
        public decimal? AmountLastPay { get => _amountLastPay; set => _amountLastPay = value; }
        private DirtyValue<decimal?> _amountNextDue;
        public decimal? AmountNextDue { get => _amountNextDue; set => _amountNextDue = value; }
        private DirtyValue<string> _city;
        public string City { get => _city; set => _city = value; }
        private DirtyValue<string> _contactName;
        public string ContactName { get => _contactName; set => _contactName = value; }
        private DirtyValue<decimal?> _coverageAmount;
        public decimal? CoverageAmount { get => _coverageAmount; set => _coverageAmount = value; }
        private DirtyValue<DateTime?> _datePaid;
        public DateTime? DatePaid { get => _datePaid; set => _datePaid = value; }
        private DirtyValue<DateTime?> _delinquentDate;
        public DateTime? DelinquentDate { get => _delinquentDate; set => _delinquentDate = value; }
        private DirtyValue<string> _email;
        public string Email { get => _email; set => _email = value; }
        private DirtyValue<string> _fax;
        public string Fax { get => _fax; set => _fax = value; }
        private StringEnumValue<Hud1EsPayToFeeType> _feeType;
        public StringEnumValue<Hud1EsPayToFeeType> FeeType { get => _feeType; set => _feeType = value; }
        private DirtyValue<int?> _hud1EsPayToIndex;
        public int? Hud1EsPayToIndex { get => _hud1EsPayToIndex; set => _hud1EsPayToIndex = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _maxDeductibleAmount;
        public decimal? MaxDeductibleAmount { get => _maxDeductibleAmount; set => _maxDeductibleAmount = value; }
        private DirtyValue<decimal?> _maxDeductiblePercentage;
        public decimal? MaxDeductiblePercentage { get => _maxDeductiblePercentage; set => _maxDeductiblePercentage = value; }
        private DirtyValue<string> _name;
        public string Name { get => _name; set => _name = value; }
        private DirtyValue<DateTime?> _nextDueDate;
        public DateTime? NextDueDate { get => _nextDueDate; set => _nextDueDate = value; }
        private DirtyValue<string> _paymentSchedule;
        public string PaymentSchedule { get => _paymentSchedule; set => _paymentSchedule = value; }
        private DirtyValue<string> _phone;
        public string Phone { get => _phone; set => _phone = value; }
        private DirtyValue<string> _policyNumber;
        public string PolicyNumber { get => _policyNumber; set => _policyNumber = value; }
        private DirtyValue<string> _postalCode;
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        private DirtyValue<decimal?> _premium;
        public decimal? Premium { get => _premium; set => _premium = value; }
        private DirtyValue<DateTime?> _renewalDate;
        public DateTime? RenewalDate { get => _renewalDate; set => _renewalDate = value; }
        private DirtyValue<string> _state;
        public string State { get => _state; set => _state = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _address.Dirty
                    || _amountLastPay.Dirty
                    || _amountNextDue.Dirty
                    || _city.Dirty
                    || _contactName.Dirty
                    || _coverageAmount.Dirty
                    || _datePaid.Dirty
                    || _delinquentDate.Dirty
                    || _email.Dirty
                    || _fax.Dirty
                    || _feeType.Dirty
                    || _hud1EsPayToIndex.Dirty
                    || _id.Dirty
                    || _maxDeductibleAmount.Dirty
                    || _maxDeductiblePercentage.Dirty
                    || _name.Dirty
                    || _nextDueDate.Dirty
                    || _paymentSchedule.Dirty
                    || _phone.Dirty
                    || _policyNumber.Dirty
                    || _postalCode.Dirty
                    || _premium.Dirty
                    || _renewalDate.Dirty
                    || _state.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _address.Dirty = value;
                _amountLastPay.Dirty = value;
                _amountNextDue.Dirty = value;
                _city.Dirty = value;
                _contactName.Dirty = value;
                _coverageAmount.Dirty = value;
                _datePaid.Dirty = value;
                _delinquentDate.Dirty = value;
                _email.Dirty = value;
                _fax.Dirty = value;
                _feeType.Dirty = value;
                _hud1EsPayToIndex.Dirty = value;
                _id.Dirty = value;
                _maxDeductibleAmount.Dirty = value;
                _maxDeductiblePercentage.Dirty = value;
                _name.Dirty = value;
                _nextDueDate.Dirty = value;
                _paymentSchedule.Dirty = value;
                _phone.Dirty = value;
                _policyNumber.Dirty = value;
                _postalCode.Dirty = value;
                _premium.Dirty = value;
                _renewalDate.Dirty = value;
                _state.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}