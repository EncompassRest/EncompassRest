using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class EnergyEfficientMortgageItem : IClean
    {
        private Value<decimal?> _actualAmount;
        public decimal? ActualAmount { get { return _actualAmount; } set { _actualAmount = value; } }
        private Value<decimal?> _allowedAmount;
        public decimal? AllowedAmount { get { return _allowedAmount; } set { _allowedAmount = value; } }
        private Value<int?> _energyEfficientMortgageItemIndex;
        public int? EnergyEfficientMortgageItemIndex { get { return _energyEfficientMortgageItemIndex; } set { _energyEfficientMortgageItemIndex = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _item;
        public string Item { get { return _item; } set { _item = value; } }
        private Value<int?> _lineNumber;
        public int? LineNumber { get { return _lineNumber; } set { _lineNumber = value; } }
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
                var actualAmount = _actualAmount; actualAmount.Clean = value; _actualAmount = actualAmount;
                var allowedAmount = _allowedAmount; allowedAmount.Clean = value; _allowedAmount = allowedAmount;
                var energyEfficientMortgageItemIndex = _energyEfficientMortgageItemIndex; energyEfficientMortgageItemIndex.Clean = value; _energyEfficientMortgageItemIndex = energyEfficientMortgageItemIndex;
                var id = _id; id.Clean = value; _id = id;
                var item = _item; item.Clean = value; _item = item;
                var lineNumber = _lineNumber; lineNumber.Clean = value; _lineNumber = lineNumber;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public EnergyEfficientMortgageItem()
        {
            Clean = true;
        }
    }
}