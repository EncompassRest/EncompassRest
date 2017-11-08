using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class ProfitManagementItem : IDirty
    {
        private DirtyValue<decimal?> _atPercent;
        public decimal? AtPercent { get { return _atPercent; } set { _atPercent = value; } }
        private DirtyValue<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _plusAmount;
        public decimal? PlusAmount { get { return _plusAmount; } set { _plusAmount = value; } }
        private DirtyValue<int?> _profitManagementItemIndex;
        public int? ProfitManagementItemIndex { get { return _profitManagementItemIndex; } set { _profitManagementItemIndex = value; } }
        private DirtyValue<decimal?> _total;
        public decimal? Total { get { return _total; } set { _total = value; } }
        private DirtyValue<string> _type;
        public string Type { get { return _type; } set { _type = value; } }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get { return _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); } set { _extensionData = new DirtyDictionary<string, object>(value); } }
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
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}