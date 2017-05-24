using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class RegulationZPayment
    {
        private Value<decimal?> _balance;
        public decimal? Balance { get { return _balance; } set { _balance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBalance() => !_balance.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<decimal?> _interestRatePercent;
        public decimal? InterestRatePercent { get { return _interestRatePercent; } set { _interestRatePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRatePercent() => !_interestRatePercent.Clean;
        private Value<decimal?> _monthlyPayment;
        public decimal? MonthlyPayment { get { return _monthlyPayment; } set { _monthlyPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPayment() => !_monthlyPayment.Clean;
        private Value<int?> _numberOfPayments;
        public int? NumberOfPayments { get { return _numberOfPayments; } set { _numberOfPayments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfPayments() => !_numberOfPayments.Clean;
        private Value<DateTime?> _paymentDate;
        public DateTime? PaymentDate { get { return _paymentDate; } set { _paymentDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentDate() => !_paymentDate.Clean;
        private Value<int?> _regulationZPaymentIndex;
        public int? RegulationZPaymentIndex { get { return _regulationZPaymentIndex; } set { _regulationZPaymentIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegulationZPaymentIndex() => !_regulationZPaymentIndex.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _balance.Clean
                    && _id.Clean
                    && _interestRatePercent.Clean
                    && _monthlyPayment.Clean
                    && _numberOfPayments.Clean
                    && _paymentDate.Clean
                    && _regulationZPaymentIndex.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _balance; v0.Clean = value; _balance = v0;
                var v1 = _id; v1.Clean = value; _id = v1;
                var v2 = _interestRatePercent; v2.Clean = value; _interestRatePercent = v2;
                var v3 = _monthlyPayment; v3.Clean = value; _monthlyPayment = v3;
                var v4 = _numberOfPayments; v4.Clean = value; _numberOfPayments = v4;
                var v5 = _paymentDate; v5.Clean = value; _paymentDate = v5;
                var v6 = _regulationZPaymentIndex; v6.Clean = value; _regulationZPaymentIndex = v6;
                _settingClean = 0;
            }
        }
    }
}