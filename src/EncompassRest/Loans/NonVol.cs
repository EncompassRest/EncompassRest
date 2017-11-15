using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class NonVol : IDirty
    {
        private DirtyValue<decimal?> _adjustmentAmount;
        public decimal? AdjustmentAmount { get => _adjustmentAmount; set => _adjustmentAmount = value; }
        private DirtyValue<string> _adjustmentDescription;
        public string AdjustmentDescription { get => _adjustmentDescription; set => _adjustmentDescription = value; }
        private DirtyValue<string> _adjustmentOtherDescription;
        public string AdjustmentOtherDescription { get => _adjustmentOtherDescription; set => _adjustmentOtherDescription = value; }
        private DirtyValue<StringEnumValue<AdjustmentType>> _adjustmentType;
        public StringEnumValue<AdjustmentType> AdjustmentType { get => _adjustmentType; set => _adjustmentType = value; }
        private DirtyValue<bool?> _includedIndicator;
        public bool? IncludedIndicator { get => _includedIndicator; set => _includedIndicator = value; }
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
                var dirty = _adjustmentAmount.Dirty
                    || _adjustmentDescription.Dirty
                    || _adjustmentOtherDescription.Dirty
                    || _adjustmentType.Dirty
                    || _includedIndicator.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _adjustmentAmount.Dirty = value;
                _adjustmentDescription.Dirty = value;
                _adjustmentOtherDescription.Dirty = value;
                _adjustmentType.Dirty = value;
                _includedIndicator.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}