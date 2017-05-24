using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class FeeVariance
    {
        private Value<decimal?> _cD;
        public decimal? CD { get { return _cD; } set { _cD = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCD() => !_cD.Clean;
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !_description.Clean;
        private Value<int?> _feeVarianceChargeIndex;
        public int? FeeVarianceChargeIndex { get { return _feeVarianceChargeIndex; } set { _feeVarianceChargeIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeVarianceChargeIndex() => !_feeVarianceChargeIndex.Clean;
        private Value<string> _feeVarianceFeeType;
        public string FeeVarianceFeeType { get { return _feeVarianceFeeType; } set { _feeVarianceFeeType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeVarianceFeeType() => !_feeVarianceFeeType.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<decimal?> _initialLE;
        public decimal? InitialLE { get { return _initialLE; } set { _initialLE = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialLE() => !_initialLE.Clean;
        private Value<decimal?> _itemization;
        public decimal? Itemization { get { return _itemization; } set { _itemization = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeItemization() => !_itemization.Clean;
        private Value<decimal?> _lE;
        public decimal? LE { get { return _lE; } set { _lE = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLE() => !_lE.Clean;
        private Value<string> _line;
        public string Line { get { return _line; } set { _line = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine() => !_line.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _cD.Clean
                    && _description.Clean
                    && _feeVarianceChargeIndex.Clean
                    && _feeVarianceFeeType.Clean
                    && _id.Clean
                    && _initialLE.Clean
                    && _itemization.Clean
                    && _lE.Clean
                    && _line.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _cD; v0.Clean = value; _cD = v0;
                var v1 = _description; v1.Clean = value; _description = v1;
                var v2 = _feeVarianceChargeIndex; v2.Clean = value; _feeVarianceChargeIndex = v2;
                var v3 = _feeVarianceFeeType; v3.Clean = value; _feeVarianceFeeType = v3;
                var v4 = _id; v4.Clean = value; _id = v4;
                var v5 = _initialLE; v5.Clean = value; _initialLE = v5;
                var v6 = _itemization; v6.Clean = value; _itemization = v6;
                var v7 = _lE; v7.Clean = value; _lE = v7;
                var v8 = _line; v8.Clean = value; _line = v8;
                _settingClean = 0;
            }
        }
    }
}