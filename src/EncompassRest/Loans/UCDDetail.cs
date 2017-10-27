using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class UCDDetail : IDirty
    {
        private DirtyValue<string> _feeAccountType;
        public string FeeAccountType { get { return _feeAccountType; } set { _feeAccountType = value; } }
        private DirtyValue<decimal?> _feeAmount;
        public decimal? FeeAmount { get { return _feeAmount; } set { _feeAmount = value; } }
        private DirtyValue<DateTime?> _feeDateFrom;
        public DateTime? FeeDateFrom { get { return _feeDateFrom; } set { _feeDateFrom = value; } }
        private DirtyValue<DateTime?> _feeDateTo;
        public DateTime? FeeDateTo { get { return _feeDateTo; } set { _feeDateTo = value; } }
        private DirtyValue<string> _feeDesc;
        public string FeeDesc { get { return _feeDesc; } set { _feeDesc = value; } }
        private DirtyValue<int?> _feeIndex;
        public int? FeeIndex { get { return _feeIndex; } set { _feeIndex = value; } }
        private DirtyValue<string> _feePaidBy;
        public string FeePaidBy { get { return _feePaidBy; } set { _feePaidBy = value; } }
        private DirtyValue<string> _feePaidTo;
        public string FeePaidTo { get { return _feePaidTo; } set { _feePaidTo = value; } }
        private DirtyValue<bool?> _feePOC;
        public bool? FeePOC { get { return _feePOC; } set { _feePOC = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<int?> _lineNumber;
        public int? LineNumber { get { return _lineNumber; } set { _lineNumber = value; } }
        private DirtyValue<string> _section;
        public string Section { get { return _section; } set { _section = value; } }
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
                var dirty = _feeAccountType.Dirty
                    || _feeAmount.Dirty
                    || _feeDateFrom.Dirty
                    || _feeDateTo.Dirty
                    || _feeDesc.Dirty
                    || _feeIndex.Dirty
                    || _feePaidBy.Dirty
                    || _feePaidTo.Dirty
                    || _feePOC.Dirty
                    || _id.Dirty
                    || _lineNumber.Dirty
                    || _section.Dirty
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _feeAccountType.Dirty = value;
                _feeAmount.Dirty = value;
                _feeDateFrom.Dirty = value;
                _feeDateTo.Dirty = value;
                _feeDesc.Dirty = value;
                _feeIndex.Dirty = value;
                _feePaidBy.Dirty = value;
                _feePaidTo.Dirty = value;
                _feePOC.Dirty = value;
                _id.Dirty = value;
                _lineNumber.Dirty = value;
                _section.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}