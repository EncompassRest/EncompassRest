using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class Gfe2010WholePoc : IDirty
    {
        private DirtyValue<int?> _gfe2010WholePocIndex;
        public int? Gfe2010WholePocIndex { get { return _gfe2010WholePocIndex; } set { _gfe2010WholePocIndex = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<int?> _lineNumber;
        public int? LineNumber { get { return _lineNumber; } set { _lineNumber = value; } }
        private DirtyValue<decimal?> _wholePoc;
        public decimal? WholePoc { get { return _wholePoc; } set { _wholePoc = value; } }
        private DirtyValue<string> _wholePocPaidByType;
        public string WholePocPaidByType { get { return _wholePocPaidByType; } set { _wholePocPaidByType = value; } }
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
                var dirty = _gfe2010WholePocIndex.Dirty
                    || _id.Dirty
                    || _lineNumber.Dirty
                    || _wholePoc.Dirty
                    || _wholePocPaidByType.Dirty
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _gfe2010WholePocIndex.Dirty = value;
                _id.Dirty = value;
                _lineNumber.Dirty = value;
                _wholePoc.Dirty = value;
                _wholePocPaidByType.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}