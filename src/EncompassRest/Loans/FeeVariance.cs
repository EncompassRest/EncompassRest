using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class FeeVariance : IDirty
    {
        private DirtyValue<decimal?> _cD;
        public decimal? CD { get { return _cD; } set { _cD = value; } }
        private DirtyValue<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private DirtyValue<int?> _feeVarianceChargeIndex;
        public int? FeeVarianceChargeIndex { get { return _feeVarianceChargeIndex; } set { _feeVarianceChargeIndex = value; } }
        private DirtyValue<string> _feeVarianceFeeType;
        public string FeeVarianceFeeType { get { return _feeVarianceFeeType; } set { _feeVarianceFeeType = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _initialLE;
        public decimal? InitialLE { get { return _initialLE; } set { _initialLE = value; } }
        private DirtyValue<decimal?> _itemization;
        public decimal? Itemization { get { return _itemization; } set { _itemization = value; } }
        private DirtyValue<decimal?> _lE;
        public decimal? LE { get { return _lE; } set { _lE = value; } }
        private DirtyValue<string> _line;
        public string Line { get { return _line; } set { _line = value; } }
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
                var dirty = _cD.Dirty
                    || _description.Dirty
                    || _feeVarianceChargeIndex.Dirty
                    || _feeVarianceFeeType.Dirty
                    || _id.Dirty
                    || _initialLE.Dirty
                    || _itemization.Dirty
                    || _lE.Dirty
                    || _line.Dirty
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _cD.Dirty = value;
                _description.Dirty = value;
                _feeVarianceChargeIndex.Dirty = value;
                _feeVarianceFeeType.Dirty = value;
                _id.Dirty = value;
                _initialLE.Dirty = value;
                _itemization.Dirty = value;
                _lE.Dirty = value;
                _line.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}