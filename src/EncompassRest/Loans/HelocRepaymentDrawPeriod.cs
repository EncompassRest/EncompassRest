using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class HelocRepaymentDrawPeriod
    {
        private Value<decimal?> _apr;
        public decimal? Apr { get { return _apr; } set { _apr = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApr() => !_apr.Clean;
        private Value<bool?> _drawIndicator;
        public bool? DrawIndicator { get { return _drawIndicator; } set { _drawIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDrawIndicator() => !_drawIndicator.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<decimal?> _indexRatePercent;
        public decimal? IndexRatePercent { get { return _indexRatePercent; } set { _indexRatePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIndexRatePercent() => !_indexRatePercent.Clean;
        private Value<decimal?> _marginRatePercent;
        public decimal? MarginRatePercent { get { return _marginRatePercent; } set { _marginRatePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMarginRatePercent() => !_marginRatePercent.Clean;
        private Value<decimal?> _minimumMonthlyPaymentAmount;
        public decimal? MinimumMonthlyPaymentAmount { get { return _minimumMonthlyPaymentAmount; } set { _minimumMonthlyPaymentAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumMonthlyPaymentAmount() => !_minimumMonthlyPaymentAmount.Clean;
        private Value<int?> _year;
        public int? Year { get { return _year; } set { _year = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYear() => !_year.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _apr.Clean
                    && _drawIndicator.Clean
                    && _id.Clean
                    && _indexRatePercent.Clean
                    && _marginRatePercent.Clean
                    && _minimumMonthlyPaymentAmount.Clean
                    && _year.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _apr; v0.Clean = value; _apr = v0;
                var v1 = _drawIndicator; v1.Clean = value; _drawIndicator = v1;
                var v2 = _id; v2.Clean = value; _id = v2;
                var v3 = _indexRatePercent; v3.Clean = value; _indexRatePercent = v3;
                var v4 = _marginRatePercent; v4.Clean = value; _marginRatePercent = v4;
                var v5 = _minimumMonthlyPaymentAmount; v5.Clean = value; _minimumMonthlyPaymentAmount = v5;
                var v6 = _year; v6.Clean = value; _year = v6;
                _settingClean = 0;
            }
        }
    }
}