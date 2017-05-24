using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class GfeLien
    {
        public Value<decimal?> AmountOwing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountOwing() => !AmountOwing.Clean;
        public Value<int?> GfeLienIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeLienIndex() => !GfeLienIndex.Clean;
        public Value<string> GfeLienType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeLienType() => !GfeLienType.Clean;
        public Value<string> HolderName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderName() => !HolderName.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> Priority { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriority() => !Priority.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AmountOwing.Clean
                    && GfeLienIndex.Clean
                    && GfeLienType.Clean
                    && HolderName.Clean
                    && Id.Clean
                    && Priority.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AmountOwing; v0.Clean = value; AmountOwing = v0;
                var v1 = GfeLienIndex; v1.Clean = value; GfeLienIndex = v1;
                var v2 = GfeLienType; v2.Clean = value; GfeLienType = v2;
                var v3 = HolderName; v3.Clean = value; HolderName = v3;
                var v4 = Id; v4.Clean = value; Id = v4;
                var v5 = Priority; v5.Clean = value; Priority = v5;
                _settingClean = 0;
            }
        }
    }
}