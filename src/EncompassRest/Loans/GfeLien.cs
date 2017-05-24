using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class GfeLien
    {
        private Value<decimal?> _amountOwing;
        public decimal? AmountOwing { get { return _amountOwing; } set { _amountOwing = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountOwing() => !_amountOwing.Clean;
        private Value<int?> _gfeLienIndex;
        public int? GfeLienIndex { get { return _gfeLienIndex; } set { _gfeLienIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeLienIndex() => !_gfeLienIndex.Clean;
        private Value<string> _gfeLienType;
        public string GfeLienType { get { return _gfeLienType; } set { _gfeLienType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeLienType() => !_gfeLienType.Clean;
        private Value<string> _holderName;
        public string HolderName { get { return _holderName; } set { _holderName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderName() => !_holderName.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _priority;
        public string Priority { get { return _priority; } set { _priority = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriority() => !_priority.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _amountOwing.Clean
                    && _gfeLienIndex.Clean
                    && _gfeLienType.Clean
                    && _holderName.Clean
                    && _id.Clean
                    && _priority.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _amountOwing; v0.Clean = value; _amountOwing = v0;
                var v1 = _gfeLienIndex; v1.Clean = value; _gfeLienIndex = v1;
                var v2 = _gfeLienType; v2.Clean = value; _gfeLienType = v2;
                var v3 = _holderName; v3.Clean = value; _holderName = v3;
                var v4 = _id; v4.Clean = value; _id = v4;
                var v5 = _priority; v5.Clean = value; _priority = v5;
                _settingClean = 0;
            }
        }
    }
}