using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class DownPayment : IDirty
    {
        private DirtyValue<decimal?> _amount;
        public decimal? Amount { get => _amount; set => _amount = value; }
        private StringEnumValue<DownPaymentType> _downPaymentType;
        public StringEnumValue<DownPaymentType> DownPaymentType { get => _downPaymentType; set => _downPaymentType = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _sourceDescription;
        public string SourceDescription { get => _sourceDescription; set => _sourceDescription = value; }
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
                    || _downPaymentType.Dirty
                    || _id.Dirty
                    || _sourceDescription.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _amount.Dirty = value;
                _downPaymentType.Dirty = value;
                _id.Dirty = value;
                _sourceDescription.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}