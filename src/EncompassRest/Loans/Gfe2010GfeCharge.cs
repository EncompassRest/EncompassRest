using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _chargeBelow10Indicator.Dirty
                    || _description.Dirty
                    || _gfe2010GfeChargeIndex.Dirty
                    || _gfeCharge.Dirty
                    || _hudCharge.Dirty
                    || _id.Dirty
                    || _line.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _chargeBelow10Indicator.Dirty = value;
                _description.Dirty = value;
                _gfe2010GfeChargeIndex.Dirty = value;
                _gfeCharge.Dirty = value;
                _hudCharge.Dirty = value;
                _id.Dirty = value;
                _line.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}