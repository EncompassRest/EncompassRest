using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class CustomField : IDirty
    {
        private DirtyValue<DateTime?> _dateValue;
        public DateTime? DateValue { get { return _dateValue; } set { _dateValue = value; } }
        private DirtyValue<string> _fieldName;
        public string FieldName { get { return _fieldName; } set { _fieldName = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _numericValue;
        public decimal? NumericValue { get { return _numericValue; } set { _numericValue = value; } }
        private DirtyValue<string> _stringValue;
        public string StringValue { get { return _stringValue; } set { _stringValue = value; } }
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
                var dirty = _dateValue.Dirty
                    || _fieldName.Dirty
                    || _id.Dirty
                    || _numericValue.Dirty
                    || _stringValue.Dirty
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _dateValue.Dirty = value;
                _fieldName.Dirty = value;
                _id.Dirty = value;
                _numericValue.Dirty = value;
                _stringValue.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}