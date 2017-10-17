using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class EnergyEfficientMortgageItem : IDirty
    {
        private DirtyValue<decimal?> _actualAmount;
        public decimal? ActualAmount { get { return _actualAmount; } set { _actualAmount = value; } }
        private DirtyValue<decimal?> _allowedAmount;
        public decimal? AllowedAmount { get { return _allowedAmount; } set { _allowedAmount = value; } }
        private DirtyValue<int?> _energyEfficientMortgageItemIndex;
        public int? EnergyEfficientMortgageItemIndex { get { return _energyEfficientMortgageItemIndex; } set { _energyEfficientMortgageItemIndex = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _item;
        public string Item { get { return _item; } set { _item = value; } }
        private DirtyValue<int?> _lineNumber;
        public int? LineNumber { get { return _lineNumber; } set { _lineNumber = value; } }
        private ExtensionDataObject _extensionDataInternal;
        [JsonExtensionData]
        private ExtensionDataObject ExtensionDataInternal { get { return _extensionDataInternal ?? (_extensionDataInternal = new ExtensionDataObject()); } set { _extensionDataInternal = value; } }
        [JsonIgnore]
        public IDictionary<string, object> ExtensionData { get { return ExtensionDataInternal.InternalDictionary; } set { _extensionDataInternal = new ExtensionDataObject(value); } }
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
                  || _extensionDataInternal?.Dirty == true;
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
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}