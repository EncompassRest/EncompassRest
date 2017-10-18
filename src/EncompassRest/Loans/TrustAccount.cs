using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class TrustAccount : IDirty
    {
        private DirtyValue<decimal?> _balance;
        public decimal? Balance { get { return _balance; } set { _balance = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _total1;
        public decimal? Total1 { get { return _total1; } set { _total1 = value; } }
        private DirtyValue<decimal?> _total2;
        public decimal? Total2 { get { return _total2; } set { _total2 = value; } }
        private DirtyList<TrustAccountItem> _trustAccountItems;
        public IList<TrustAccountItem> TrustAccountItems { get { return _trustAccountItems ?? (_trustAccountItems = new DirtyList<TrustAccountItem>()); } set { _trustAccountItems = new DirtyList<TrustAccountItem>(value); } }
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
                var dirty = _balance.Dirty
                    || _id.Dirty
                    || _total1.Dirty
                    || _total2.Dirty
                    || _trustAccountItems?.Dirty == true
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _balance.Dirty = value;
                _id.Dirty = value;
                _total1.Dirty = value;
                _total2.Dirty = value;
                if (_trustAccountItems != null) _trustAccountItems.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}