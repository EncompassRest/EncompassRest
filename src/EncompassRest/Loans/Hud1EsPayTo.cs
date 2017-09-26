using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsPayTo : IDirty
    {
        private Value<string> _address;
        public string Address { get { return _address; } set { _address = value; } }
        private Value<decimal?> _amountLastPay;
        public decimal? AmountLastPay { get { return _amountLastPay; } set { _amountLastPay = value; } }
        private Value<decimal?> _amountNextDue;
        public decimal? AmountNextDue { get { return _amountNextDue; } set { _amountNextDue = value; } }
        private Value<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        private Value<string> _contactName;
        public string ContactName { get { return _contactName; } set { _contactName = value; } }
        private Value<decimal?> _coverageAmount;
        public decimal? CoverageAmount { get { return _coverageAmount; } set { _coverageAmount = value; } }
        private Value<DateTime?> _datePaid;
        public DateTime? DatePaid { get { return _datePaid; } set { _datePaid = value; } }
        private Value<DateTime?> _delinquentDate;
        public DateTime? DelinquentDate { get { return _delinquentDate; } set { _delinquentDate = value; } }
        private Value<string> _email;
        public string Email { get { return _email; } set { _email = value; } }
        private Value<string> _fax;
        public string Fax { get { return _fax; } set { _fax = value; } }
        private Value<string> _feeType;
        public string FeeType { get { return _feeType; } set { _feeType = value; } }
        private Value<int?> _hud1EsPayToIndex;
        public int? Hud1EsPayToIndex { get { return _hud1EsPayToIndex; } set { _hud1EsPayToIndex = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _maxDeductibleAmount;
        public decimal? MaxDeductibleAmount { get { return _maxDeductibleAmount; } set { _maxDeductibleAmount = value; } }
        private Value<decimal?> _maxDeductiblePercentage;
        public decimal? MaxDeductiblePercentage { get { return _maxDeductiblePercentage; } set { _maxDeductiblePercentage = value; } }
        private Value<string> _name;
        public string Name { get { return _name; } set { _name = value; } }
        private Value<DateTime?> _nextDueDate;
        public DateTime? NextDueDate { get { return _nextDueDate; } set { _nextDueDate = value; } }
        private Value<string> _paymentSchedule;
        public string PaymentSchedule { get { return _paymentSchedule; } set { _paymentSchedule = value; } }
        private Value<string> _phone;
        public string Phone { get { return _phone; } set { _phone = value; } }
        private Value<string> _policyNumber;
        public string PolicyNumber { get { return _policyNumber; } set { _policyNumber = value; } }
        private Value<string> _postalCode;
        public string PostalCode { get { return _postalCode; } set { _postalCode = value; } }
        private Value<decimal?> _premium;
        public decimal? Premium { get { return _premium; } set { _premium = value; } }
        private Value<DateTime?> _renewalDate;
        public DateTime? RenewalDate { get { return _renewalDate; } set { _renewalDate = value; } }
        private Value<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
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
                    || _state.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}