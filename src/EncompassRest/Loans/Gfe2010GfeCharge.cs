using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class Gfe2010GfeCharge : IDirty
    {
        private DirtyValue<bool?> _chargeBelow10Indicator;
        public bool? ChargeBelow10Indicator { get { return _chargeBelow10Indicator; } set { _chargeBelow10Indicator = value; } }
        private DirtyValue<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private DirtyValue<int?> _gfe2010GfeChargeIndex;
        public int? Gfe2010GfeChargeIndex { get { return _gfe2010GfeChargeIndex; } set { _gfe2010GfeChargeIndex = value; } }
        private DirtyValue<decimal?> _gfeCharge;
        public decimal? GfeCharge { get { return _gfeCharge; } set { _gfeCharge = value; } }
        private DirtyValue<decimal?> _hudCharge;
        public decimal? HudCharge { get { return _hudCharge; } set { _hudCharge = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _line;
        public string Line { get { return _line; } set { _line = value; } }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get { return _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); } set { _extensionData = new DirtyDictionary<string, object>(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _chargeBelow10Indicator.Dirty
                    || _description.Dirty
                    || _gfe2010GfeChargeIndex.Dirty
                    || _gfeCharge.Dirty
                    || _hudCharge.Dirty
                    || _id.Dirty
                    || _line.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _chargeBelow10Indicator.Dirty = value;
                _description.Dirty = value;
                _gfe2010GfeChargeIndex.Dirty = value;
                _gfeCharge.Dirty = value;
                _hudCharge.Dirty = value;
                _id.Dirty = value;
                _line.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}