using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class SelfEmployedIncome : IDirty
    {
        private DirtyValue<bool?> _boolFieldValue;
        public bool? BoolFieldValue { get => _boolFieldValue; set => _boolFieldValue = value; }
        private DirtyValue<string> _businessName;
        public string BusinessName { get => _businessName; set => _businessName = value; }
        private DirtyValue<string> _fieldName;
        public string FieldName { get => _fieldName; set => _fieldName = value; }
        private DirtyValue<decimal?> _fieldValue;
        public decimal? FieldValue { get => _fieldValue; set => _fieldValue = value; }
        private DirtyValue<decimal?> _firstYearAmount;
        public decimal? FirstYearAmount { get => _firstYearAmount; set => _firstYearAmount = value; }
        private StringEnumValue<FormType> _formType;
        public StringEnumValue<FormType> FormType { get => _formType; set => _formType = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _secondYearAmount;
        public decimal? SecondYearAmount { get => _secondYearAmount; set => _secondYearAmount = value; }
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
                var dirty = _boolFieldValue.Dirty
                    || _businessName.Dirty
                    || _fieldName.Dirty
                    || _fieldValue.Dirty
                    || _firstYearAmount.Dirty
                    || _formType.Dirty
                    || _id.Dirty
                    || _secondYearAmount.Dirty
                    || _extensionData?.Dirty == true;
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
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}