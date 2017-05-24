using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class HelocRepaymentDrawPeriod
    {
        public Value<decimal?> Apr { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApr() => !Apr.Clean;
        public Value<bool?> DrawIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDrawIndicator() => !DrawIndicator.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> IndexRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIndexRatePercent() => !IndexRatePercent.Clean;
        public Value<decimal?> MarginRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMarginRatePercent() => !MarginRatePercent.Clean;
        public Value<decimal?> MinimumMonthlyPaymentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumMonthlyPaymentAmount() => !MinimumMonthlyPaymentAmount.Clean;
        public Value<int?> Year { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYear() => !Year.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Apr.Clean
                    && DrawIndicator.Clean
                    && Id.Clean
                    && IndexRatePercent.Clean
                    && MarginRatePercent.Clean
                    && MinimumMonthlyPaymentAmount.Clean
                    && Year.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Apr; v0.Clean = value; Apr = v0;
                var v1 = DrawIndicator; v1.Clean = value; DrawIndicator = v1;
                var v2 = Id; v2.Clean = value; Id = v2;
                var v3 = IndexRatePercent; v3.Clean = value; IndexRatePercent = v3;
                var v4 = MarginRatePercent; v4.Clean = value; MarginRatePercent = v4;
                var v5 = MinimumMonthlyPaymentAmount; v5.Clean = value; MinimumMonthlyPaymentAmount = v5;
                var v6 = Year; v6.Clean = value; Year = v6;
                _settingClean = 0;
            }
        }
    }
}