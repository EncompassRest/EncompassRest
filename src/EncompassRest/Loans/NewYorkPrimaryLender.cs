using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class NewYorkPrimaryLender : IDirty
    {
        private DirtyValue<string> _address;
        public string Address { get { return _address; } set { _address = value; } }
        private DirtyValue<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        private DirtyValue<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _name;
        public string Name { get { return _name; } set { _name = value; } }
        private DirtyValue<int?> _newYorkPrimaryLenderIndex;
        public int? NewYorkPrimaryLenderIndex { get { return _newYorkPrimaryLenderIndex; } set { _newYorkPrimaryLenderIndex = value; } }
        private DirtyValue<string> _postalCode;
        public string PostalCode { get { return _postalCode; } set { _postalCode = value; } }
        private DirtyValue<string> _state;
        public string State { get { return _state; } set { _state = value; } }
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
                var dirty = _address.Dirty
                    || _city.Dirty
                    || _comments.Dirty
                    || _id.Dirty
                    || _name.Dirty
                    || _newYorkPrimaryLenderIndex.Dirty
                    || _postalCode.Dirty
                    || _state.Dirty
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _address.Dirty = value;
                _city.Dirty = value;
                _comments.Dirty = value;
                _id.Dirty = value;
                _name.Dirty = value;
                _newYorkPrimaryLenderIndex.Dirty = value;
                _postalCode.Dirty = value;
                _state.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}