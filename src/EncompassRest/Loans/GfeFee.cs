using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class GfeFee
    {
        public Value<string> AmountDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountDescription() => !AmountDescription.Clean;
        public Value<decimal?> BrokerAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerAmount() => !BrokerAmount.Clean;
        public Value<string> Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !Description.Clean;
        public Value<int?> GfeFeeIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeFeeIndex() => !GfeFeeIndex.Clean;
        public Value<string> GfeFeeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeFeeType() => !GfeFeeType.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> OtherAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherAmount() => !OtherAmount.Clean;
        public Value<string> Rate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRate() => !Rate.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AmountDescription.Clean
                    && BrokerAmount.Clean
                    && Description.Clean
                    && GfeFeeIndex.Clean
                    && GfeFeeType.Clean
                    && Id.Clean
                    && OtherAmount.Clean
                    && Rate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AmountDescription; v0.Clean = value; AmountDescription = v0;
                var v1 = BrokerAmount; v1.Clean = value; BrokerAmount = v1;
                var v2 = Description; v2.Clean = value; Description = v2;
                var v3 = GfeFeeIndex; v3.Clean = value; GfeFeeIndex = v3;
                var v4 = GfeFeeType; v4.Clean = value; GfeFeeType = v4;
                var v5 = Id; v5.Clean = value; Id = v5;
                var v6 = OtherAmount; v6.Clean = value; OtherAmount = v6;
                var v7 = Rate; v7.Clean = value; Rate = v7;
                _settingClean = 0;
            }
        }
    }
}