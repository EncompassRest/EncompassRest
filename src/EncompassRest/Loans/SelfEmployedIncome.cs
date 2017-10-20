using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class SelfEmployedIncome : IDirty
    {
        private DirtyValue<bool?> _boolFieldValue;
        public bool? BoolFieldValue { get { return _boolFieldValue; } set { _boolFieldValue = value; } }
        private DirtyValue<string> _businessName;
        public string BusinessName { get { return _businessName; } set { _businessName = value; } }
        private DirtyValue<string> _fieldName;
        public string FieldName { get { return _fieldName; } set { _fieldName = value; } }
        private DirtyValue<decimal?> _fieldValue;
        public decimal? FieldValue { get { return _fieldValue; } set { _fieldValue = value; } }
        private DirtyValue<decimal?> _firstYearAmount;
        public decimal? FirstYearAmount { get { return _firstYearAmount; } set { _firstYearAmount = value; } }
        private DirtyValue<string> _formType;
        public string FormType { get { return _formType; } set { _formType = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _secondYearAmount;
        public decimal? SecondYearAmount { get { return _secondYearAmount; } set { _secondYearAmount = value; } }
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
                var dirty = _boolFieldValue.Dirty
                    || _businessName.Dirty
                    || _fieldName.Dirty
                    || _fieldValue.Dirty
                    || _firstYearAmount.Dirty
                    || _formType.Dirty
                    || _id.Dirty
                    || _secondYearAmount.Dirty
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _boolFieldValue.Dirty = value;
                _businessName.Dirty = value;
                _fieldName.Dirty = value;
                _fieldValue.Dirty = value;
                _firstYearAmount.Dirty = value;
                _formType.Dirty = value;
                _id.Dirty = value;
                _secondYearAmount.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}