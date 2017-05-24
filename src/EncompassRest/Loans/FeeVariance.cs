using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class FeeVariance
    {
        public Value<decimal?> CD { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCD() => !CD.Clean;
        public Value<string> Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !Description.Clean;
        public Value<int?> FeeVarianceChargeIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeVarianceChargeIndex() => !FeeVarianceChargeIndex.Clean;
        public Value<string> FeeVarianceFeeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeVarianceFeeType() => !FeeVarianceFeeType.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> InitialLE { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialLE() => !InitialLE.Clean;
        public Value<decimal?> Itemization { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeItemization() => !Itemization.Clean;
        public Value<decimal?> LE { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLE() => !LE.Clean;
        public Value<string> Line { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine() => !Line.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = CD.Clean
                    && Description.Clean
                    && FeeVarianceChargeIndex.Clean
                    && FeeVarianceFeeType.Clean
                    && Id.Clean
                    && InitialLE.Clean
                    && Itemization.Clean
                    && LE.Clean
                    && Line.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = CD; v0.Clean = value; CD = v0;
                var v1 = Description; v1.Clean = value; Description = v1;
                var v2 = FeeVarianceChargeIndex; v2.Clean = value; FeeVarianceChargeIndex = v2;
                var v3 = FeeVarianceFeeType; v3.Clean = value; FeeVarianceFeeType = v3;
                var v4 = Id; v4.Clean = value; Id = v4;
                var v5 = InitialLE; v5.Clean = value; InitialLE = v5;
                var v6 = Itemization; v6.Clean = value; Itemization = v6;
                var v7 = LE; v7.Clean = value; LE = v7;
                var v8 = Line; v8.Clean = value; Line = v8;
                _settingClean = 0;
            }
        }
    }
}