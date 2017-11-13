using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class EnergyEfficientMortgageItem : IDirty
    {
        private DirtyValue<decimal?> _actualAmount;
        public decimal? ActualAmount { get => _actualAmount; set => _actualAmount = value; }
        private DirtyValue<decimal?> _allowedAmount;
        public decimal? AllowedAmount { get => _allowedAmount; set => _allowedAmount = value; }
        private DirtyValue<int?> _energyEfficientMortgageItemIndex;
        public int? EnergyEfficientMortgageItemIndex { get => _energyEfficientMortgageItemIndex; set => _energyEfficientMortgageItemIndex = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _item;
        public string Item { get => _item; set => _item = value; }
        private DirtyValue<int?> _lineNumber;
        public int? LineNumber { get => _lineNumber; set => _lineNumber = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _actualAmount.Dirty
                    || _allowedAmount.Dirty
                    || _energyEfficientMortgageItemIndex.Dirty
                    || _id.Dirty
                    || _item.Dirty
                    || _lineNumber.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _actualAmount.Dirty = value;
                _allowedAmount.Dirty = value;
                _energyEfficientMortgageItemIndex.Dirty = value;
                _id.Dirty = value;
                _item.Dirty = value;
                _lineNumber.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}