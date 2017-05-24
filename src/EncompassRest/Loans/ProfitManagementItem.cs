using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ProfitManagementItem
    {
        public Value<decimal?> AtPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAtPercent() => !AtPercent.Clean;
        public Value<string> Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !Description.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> PlusAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlusAmount() => !PlusAmount.Clean;
        public Value<int?> ProfitManagementItemIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProfitManagementItemIndex() => !ProfitManagementItemIndex.Clean;
        public Value<decimal?> Total { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotal() => !Total.Clean;
        public Value<string> Type { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeType() => !Type.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AtPercent.Clean
                    && Description.Clean
                    && Id.Clean
                    && PlusAmount.Clean
                    && ProfitManagementItemIndex.Clean
                    && Total.Clean
                    && Type.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AtPercent; v0.Clean = value; AtPercent = v0;
                var v1 = Description; v1.Clean = value; Description = v1;
                var v2 = Id; v2.Clean = value; Id = v2;
                var v3 = PlusAmount; v3.Clean = value; PlusAmount = v3;
                var v4 = ProfitManagementItemIndex; v4.Clean = value; ProfitManagementItemIndex = v4;
                var v5 = Total; v5.Clean = value; Total = v5;
                var v6 = Type; v6.Clean = value; Type = v6;
                _settingClean = 0;
            }
        }
    }
}