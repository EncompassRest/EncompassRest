using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Gfe2010GfeCharge
    /// </summary>
    public sealed partial class Gfe2010GfeCharge : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _chargeBelow10Indicator;
        /// <summary>
        /// Gfe2010GfeCharge ChargeBelow10Indicator
        /// </summary>
        public bool? ChargeBelow10Indicator { get => _chargeBelow10Indicator; set => _chargeBelow10Indicator = value; }
        private DirtyValue<string> _description;
        /// <summary>
        /// Gfe2010GfeCharge Description
        /// </summary>
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<int?> _gfe2010GfeChargeIndex;
        /// <summary>
        /// Gfe2010GfeCharge Gfe2010GfeChargeIndex
        /// </summary>
        public int? Gfe2010GfeChargeIndex { get => _gfe2010GfeChargeIndex; set => _gfe2010GfeChargeIndex = value; }
        private DirtyValue<decimal?> _gfeCharge;
        /// <summary>
        /// Gfe2010GfeCharge GfeCharge
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? GfeCharge { get => _gfeCharge; set => _gfeCharge = value; }
        private DirtyValue<decimal?> _hudCharge;
        /// <summary>
        /// Gfe2010GfeCharge HudCharge
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? HudCharge { get => _hudCharge; set => _hudCharge = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Gfe2010GfeCharge Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _line;
        /// <summary>
        /// Gfe2010GfeCharge Line
        /// </summary>
        public string Line { get => _line; set => _line = value; }
        internal override bool DirtyInternal
        {
            get => _chargeBelow10Indicator.Dirty
                || _description.Dirty
                || _gfe2010GfeChargeIndex.Dirty
                || _gfeCharge.Dirty
                || _hudCharge.Dirty
                || _id.Dirty
                || _line.Dirty;
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