using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class ProfitManagementItem : IDirty
    {
        private DirtyValue<decimal?> _atPercent;
        public decimal? AtPercent { get => _atPercent; set => _atPercent = value; }
        private DirtyValue<string> _description;
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _plusAmount;
        public decimal? PlusAmount { get => _plusAmount; set => _plusAmount = value; }
        private DirtyValue<int?> _profitManagementItemIndex;
        public int? ProfitManagementItemIndex { get => _profitManagementItemIndex; set => _profitManagementItemIndex = value; }
        private DirtyValue<decimal?> _total;
        public decimal? Total { get => _total; set => _total = value; }
        private DirtyValue<StringEnumValue<ProfitManagementItemType>> _type;
        public StringEnumValue<ProfitManagementItemType> Type { get => _type; set => _type = value; }
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
                var dirty = _atPercent.Dirty
                    || _description.Dirty
                    || _id.Dirty
                    || _plusAmount.Dirty
                    || _profitManagementItemIndex.Dirty
                    || _total.Dirty
                    || _type.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _atPercent.Dirty = value;
                _description.Dirty = value;
                _id.Dirty = value;
                _plusAmount.Dirty = value;
                _profitManagementItemIndex.Dirty = value;
                _total.Dirty = value;
                _type.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}