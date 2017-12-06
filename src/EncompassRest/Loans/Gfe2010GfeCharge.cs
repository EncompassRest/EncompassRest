#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010GfeCharge : ExtensibleObject
    {
        private DirtyValue<bool?> _chargeBelow10Indicator;
        public bool? ChargeBelow10Indicator { get => _chargeBelow10Indicator; set => _chargeBelow10Indicator = value; }
        private DirtyValue<string> _description;
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<int?> _gfe2010GfeChargeIndex;
        public int? Gfe2010GfeChargeIndex { get => _gfe2010GfeChargeIndex; set => _gfe2010GfeChargeIndex = value; }
        private DirtyValue<decimal?> _gfeCharge;
        public decimal? GfeCharge { get => _gfeCharge; set => _gfeCharge = value; }
        private DirtyValue<decimal?> _hudCharge;
        public decimal? HudCharge { get => _hudCharge; set => _hudCharge = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _line;
        public string Line { get => _line; set => _line = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _chargeBelow10Indicator.Dirty
                    || _description.Dirty
                    || _gfe2010GfeChargeIndex.Dirty
                    || _gfeCharge.Dirty
                    || _hudCharge.Dirty
                    || _id.Dirty
                    || _line.Dirty;
            }
            set
            {
                _chargeBelow10Indicator.Dirty = value;
                _description.Dirty = value;
                _gfe2010GfeChargeIndex.Dirty = value;
                _gfeCharge.Dirty = value;
                _hudCharge.Dirty = value;
                _id.Dirty = value;
                _line.Dirty = value;
            }
        }
    }
}