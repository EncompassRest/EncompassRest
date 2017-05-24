using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class EnergyEfficientMortgageItem
    {
        private Value<decimal?> _actualAmount;
        public decimal? ActualAmount { get { return _actualAmount; } set { _actualAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualAmount() => !_actualAmount.Clean;
        private Value<decimal?> _allowedAmount;
        public decimal? AllowedAmount { get { return _allowedAmount; } set { _allowedAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllowedAmount() => !_allowedAmount.Clean;
        private Value<int?> _energyEfficientMortgageItemIndex;
        public int? EnergyEfficientMortgageItemIndex { get { return _energyEfficientMortgageItemIndex; } set { _energyEfficientMortgageItemIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEnergyEfficientMortgageItemIndex() => !_energyEfficientMortgageItemIndex.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _item;
        public string Item { get { return _item; } set { _item = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeItem() => !_item.Clean;
        private Value<int?> _lineNumber;
        public int? LineNumber { get { return _lineNumber; } set { _lineNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineNumber() => !_lineNumber.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _actualAmount.Clean
                    && _allowedAmount.Clean
                    && _energyEfficientMortgageItemIndex.Clean
                    && _id.Clean
                    && _item.Clean
                    && _lineNumber.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _actualAmount; v0.Clean = value; _actualAmount = v0;
                var v1 = _allowedAmount; v1.Clean = value; _allowedAmount = v1;
                var v2 = _energyEfficientMortgageItemIndex; v2.Clean = value; _energyEfficientMortgageItemIndex = v2;
                var v3 = _id; v3.Clean = value; _id = v3;
                var v4 = _item; v4.Clean = value; _item = v4;
                var v5 = _lineNumber; v5.Clean = value; _lineNumber = v5;
                _settingClean = 0;
            }
        }
    }
}