using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class ExtraPayment : IDirty
    {
        private DirtyValue<decimal?> _amount;
        public decimal? Amount { get => _amount; set => _amount = value; }
        private DirtyValue<DateTime?> _date;
        public DateTime? Date { get => _date; set => _date = value; }
        private DirtyValue<int?> _extraPaymentIndex;
        public int? ExtraPaymentIndex { get => _extraPaymentIndex; set => _extraPaymentIndex = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<int?> _lineNumber;
        public int? LineNumber { get => _lineNumber; set => _lineNumber = value; }
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
                    || _date.Dirty
                    || _extraPaymentIndex.Dirty
                    || _id.Dirty
                    || _lineNumber.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _amount.Dirty = value;
                _date.Dirty = value;
                _extraPaymentIndex.Dirty = value;
                _id.Dirty = value;
                _lineNumber.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}