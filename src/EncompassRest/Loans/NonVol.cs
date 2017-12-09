#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class NonVol : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _adjustmentAmount;
        public decimal? AdjustmentAmount { get => _adjustmentAmount; set => _adjustmentAmount = value; }
        private DirtyValue<string> _adjustmentDescription;
        public string AdjustmentDescription { get => _adjustmentDescription; set => _adjustmentDescription = value; }
        private DirtyValue<string> _adjustmentOtherDescription;
        public string AdjustmentOtherDescription { get => _adjustmentOtherDescription; set => _adjustmentOtherDescription = value; }
        private DirtyValue<StringEnumValue<AdjustmentType>> _adjustmentType;
        public StringEnumValue<AdjustmentType> AdjustmentType { get => _adjustmentType; set => _adjustmentType = value; }
        private DirtyValue<bool?> _includedIndicator;
        public bool? IncludedIndicator { get => _includedIndicator; set => _includedIndicator = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _adjustmentAmount.Dirty
                    || _adjustmentDescription.Dirty
                    || _adjustmentOtherDescription.Dirty
                    || _adjustmentType.Dirty
                    || _includedIndicator.Dirty;
            }
            set
            {
                _adjustmentAmount.Dirty = value;
                _adjustmentDescription.Dirty = value;
                _adjustmentOtherDescription.Dirty = value;
                _adjustmentType.Dirty = value;
                _includedIndicator.Dirty = value;
            }
        }
    }
}