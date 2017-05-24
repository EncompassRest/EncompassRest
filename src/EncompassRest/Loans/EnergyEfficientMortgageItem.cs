using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class EnergyEfficientMortgageItem
    {
        public Value<decimal?> ActualAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualAmount() => !ActualAmount.Clean;
        public Value<decimal?> AllowedAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllowedAmount() => !AllowedAmount.Clean;
        public Value<int?> EnergyEfficientMortgageItemIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEnergyEfficientMortgageItemIndex() => !EnergyEfficientMortgageItemIndex.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> Item { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeItem() => !Item.Clean;
        public Value<int?> LineNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineNumber() => !LineNumber.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = ActualAmount.Clean
                    && AllowedAmount.Clean
                    && EnergyEfficientMortgageItemIndex.Clean
                    && Id.Clean
                    && Item.Clean
                    && LineNumber.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = ActualAmount; v0.Clean = value; ActualAmount = v0;
                var v1 = AllowedAmount; v1.Clean = value; AllowedAmount = v1;
                var v2 = EnergyEfficientMortgageItemIndex; v2.Clean = value; EnergyEfficientMortgageItemIndex = v2;
                var v3 = Id; v3.Clean = value; Id = v3;
                var v4 = Item; v4.Clean = value; Item = v4;
                var v5 = LineNumber; v5.Clean = value; LineNumber = v5;
                _settingClean = 0;
            }
        }
    }
}