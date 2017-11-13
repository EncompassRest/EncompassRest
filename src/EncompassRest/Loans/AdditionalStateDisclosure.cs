using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class AdditionalStateDisclosure : IDirty
    {
        private DirtyValue<string> _disclosureName;
        public string DisclosureName { get => _disclosureName; set => _disclosureName = value; }
        private DirtyValue<string> _disclosureValue;
        public string DisclosureValue { get => _disclosureValue; set => _disclosureValue = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _stateCode;
        public string StateCode { get => _stateCode; set => _stateCode = value; }
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
                var dirty = _disclosureName.Dirty
                    || _disclosureValue.Dirty
                    || _id.Dirty
                    || _stateCode.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _disclosureName.Dirty = value;
                _disclosureValue.Dirty = value;
                _id.Dirty = value;
                _stateCode.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}