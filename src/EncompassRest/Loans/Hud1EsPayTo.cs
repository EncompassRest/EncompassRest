using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsPayTo : IClean
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
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _address.Clean
                    && _amountLastPay.Clean
                    && _amountNextDue.Clean
                    && _city.Clean
                    && _contactName.Clean
                    && _coverageAmount.Clean
                    && _datePaid.Clean
                    && _delinquentDate.Clean
                    && _email.Clean
                    && _fax.Clean
                    && _feeType.Clean
                    && _hud1EsPayToIndex.Clean
                    && _id.Clean
                    && _maxDeductibleAmount.Clean
                    && _maxDeductiblePercentage.Clean
                    && _name.Clean
                    && _nextDueDate.Clean
                    && _paymentSchedule.Clean
                    && _phone.Clean
                    && _policyNumber.Clean
                    && _postalCode.Clean
                    && _premium.Clean
                    && _renewalDate.Clean
                    && _state.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _address; v0.Clean = value; _address = v0;
                var v1 = _amountLastPay; v1.Clean = value; _amountLastPay = v1;
                var v2 = _amountNextDue; v2.Clean = value; _amountNextDue = v2;
                var v3 = _city; v3.Clean = value; _city = v3;
                var v4 = _contactName; v4.Clean = value; _contactName = v4;
                var v5 = _coverageAmount; v5.Clean = value; _coverageAmount = v5;
                var v6 = _datePaid; v6.Clean = value; _datePaid = v6;
                var v7 = _delinquentDate; v7.Clean = value; _delinquentDate = v7;
                var v8 = _email; v8.Clean = value; _email = v8;
                var v9 = _fax; v9.Clean = value; _fax = v9;
                var v10 = _feeType; v10.Clean = value; _feeType = v10;
                var v11 = _hud1EsPayToIndex; v11.Clean = value; _hud1EsPayToIndex = v11;
                var v12 = _id; v12.Clean = value; _id = v12;
                var v13 = _maxDeductibleAmount; v13.Clean = value; _maxDeductibleAmount = v13;
                var v14 = _maxDeductiblePercentage; v14.Clean = value; _maxDeductiblePercentage = v14;
                var v15 = _name; v15.Clean = value; _name = v15;
                var v16 = _nextDueDate; v16.Clean = value; _nextDueDate = v16;
                var v17 = _paymentSchedule; v17.Clean = value; _paymentSchedule = v17;
                var v18 = _phone; v18.Clean = value; _phone = v18;
                var v19 = _policyNumber; v19.Clean = value; _policyNumber = v19;
                var v20 = _postalCode; v20.Clean = value; _postalCode = v20;
                var v21 = _premium; v21.Clean = value; _premium = v21;
                var v22 = _renewalDate; v22.Clean = value; _renewalDate = v22;
                var v23 = _state; v23.Clean = value; _state = v23;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}