using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassRest.Contacts
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed class BusinessContactLicense : IDirty
    {
        private DirtyValue<string> _licenseAuthName;
        public string LicenseAuthName { get { return _licenseAuthName; } set { _licenseAuthName = value; } }
        private DirtyValue<string> _licenseAuthType;
        public string LicenseAuthType { get { return _licenseAuthType; } set { _licenseAuthType = value; } }
        private DirtyValue<DateTime?> _licenseIssueDate;
        public DateTime? LicenseIssueDate { get { return _licenseIssueDate; } set { _licenseIssueDate = value; } }
        private DirtyValue<string> _licenseNumber;
        public string LicenseNumber { get { return _licenseNumber; } set { _licenseNumber = value; } }
        private DirtyValue<string> _licenseStateCode;
        public string LicenseStateCode { get { return _licenseStateCode; } set { _licenseStateCode = value; } }
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
                var dirty = _licenseAuthName.Dirty
                    || _licenseAuthType.Dirty
                    || _licenseIssueDate.Dirty
                    || _licenseNumber.Dirty
                    || _licenseStateCode.Dirty
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _licenseAuthName.Dirty = value;
                _licenseAuthType.Dirty = value;
                _licenseIssueDate.Dirty = value;
                _licenseNumber.Dirty = value;
                _licenseStateCode.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}
