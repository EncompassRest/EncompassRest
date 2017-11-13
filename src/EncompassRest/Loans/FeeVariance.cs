using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class FeeVariance : IDirty
    {
        private DirtyValue<decimal?> _cD;
        public decimal? CD { get => _cD; set => _cD = value; }
        private DirtyValue<string> _description;
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<int?> _feeVarianceChargeIndex;
        public int? FeeVarianceChargeIndex { get => _feeVarianceChargeIndex; set => _feeVarianceChargeIndex = value; }
        private DirtyValue<string> _feeVarianceFeeType;
        public string FeeVarianceFeeType { get => _feeVarianceFeeType; set => _feeVarianceFeeType = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _initialLE;
        public decimal? InitialLE { get => _initialLE; set => _initialLE = value; }
        private DirtyValue<decimal?> _itemization;
        public decimal? Itemization { get => _itemization; set => _itemization = value; }
        private DirtyValue<decimal?> _lE;
        public decimal? LE { get => _lE; set => _lE = value; }
        private DirtyValue<string> _line;
        public string Line { get => _line; set => _line = value; }
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
                var dirty = _cD.Dirty
                    || _description.Dirty
                    || _feeVarianceChargeIndex.Dirty
                    || _feeVarianceFeeType.Dirty
                    || _id.Dirty
                    || _initialLE.Dirty
                    || _itemization.Dirty
                    || _lE.Dirty
                    || _line.Dirty
                    || _extensionData?.Dirty == true;
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
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}