using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class RespaHudDetail : IDirty
    {
        private DirtyValue<string> _creditDebt;
        public string CreditDebt { get { return _creditDebt; } set { _creditDebt = value; } }
        private DirtyValue<string> _fWBC;
        public string FWBC { get { return _fWBC; } set { _fWBC = value; } }
        private DirtyValue<DateTime?> _hUD1LineItemFromDate;
        public DateTime? HUD1LineItemFromDate { get { return _hUD1LineItemFromDate; } set { _hUD1LineItemFromDate = value; } }
        private DirtyValue<DateTime?> _hUD1LineItemToDate;
        public DateTime? HUD1LineItemToDate { get { return _hUD1LineItemToDate; } set { _hUD1LineItemToDate = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _lineItemAmount;
        public decimal? LineItemAmount { get { return _lineItemAmount; } set { _lineItemAmount = value; } }
        private DirtyValue<string> _lineItemDescription;
        public string LineItemDescription { get { return _lineItemDescription; } set { _lineItemDescription = value; } }
        private DirtyValue<int?> _lineNumber;
        public int? LineNumber { get { return _lineNumber; } set { _lineNumber = value; } }
        private DirtyValue<decimal?> _realValue;
        public decimal? RealValue { get { return _realValue; } set { _realValue = value; } }
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
                var dirty = _creditDebt.Dirty
                    || _fWBC.Dirty
                    || _hUD1LineItemFromDate.Dirty
                    || _hUD1LineItemToDate.Dirty
                    || _id.Dirty
                    || _lineItemAmount.Dirty
                    || _lineItemDescription.Dirty
                    || _lineNumber.Dirty
                    || _realValue.Dirty
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _creditDebt.Dirty = value;
                _fWBC.Dirty = value;
                _hUD1LineItemFromDate.Dirty = value;
                _hUD1LineItemToDate.Dirty = value;
                _id.Dirty = value;
                _lineItemAmount.Dirty = value;
                _lineItemDescription.Dirty = value;
                _lineNumber.Dirty = value;
                _realValue.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}