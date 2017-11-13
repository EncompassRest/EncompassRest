using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class Income : IDirty
    {
        private DirtyValue<decimal?> _amount;
        public decimal? Amount { get => _amount; set => _amount = value; }
        private DirtyValue<bool?> _currentIndicator;
        public bool? CurrentIndicator { get => _currentIndicator; set => _currentIndicator = value; }
        private StringEnumValue<Description> _description;
        public StringEnumValue<Description> Description { get => _description; set => _description = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _incomeType;
        public string IncomeType { get => _incomeType; set => _incomeType = value; }
        private DirtyValue<int?> _otherIncomeIndex;
        public int? OtherIncomeIndex { get => _otherIncomeIndex; set => _otherIncomeIndex = value; }
        private DirtyValue<string> _owner;
        public string Owner { get => _owner; set => _owner = value; }
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
                var dirty = _amount.Dirty
                    || _currentIndicator.Dirty
                    || _description.Dirty
                    || _id.Dirty
                    || _incomeType.Dirty
                    || _otherIncomeIndex.Dirty
                    || _owner.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _amount.Dirty = value;
                _currentIndicator.Dirty = value;
                _description.Dirty = value;
                _id.Dirty = value;
                _incomeType.Dirty = value;
                _otherIncomeIndex.Dirty = value;
                _owner.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}