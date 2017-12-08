#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class EnergyEfficientMortgageItem : ExtensibleObject
    {
        private DirtyValue<decimal?> _actualAmount;
        public decimal? ActualAmount { get => _actualAmount; set => _actualAmount = value; }
        private DirtyValue<decimal?> _allowedAmount;
        public decimal? AllowedAmount { get => _allowedAmount; set => _allowedAmount = value; }
        private DirtyValue<int?> _energyEfficientMortgageItemIndex;
        public int? EnergyEfficientMortgageItemIndex { get => _energyEfficientMortgageItemIndex; set => _energyEfficientMortgageItemIndex = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _item;
        public string Item { get => _item; set => _item = value; }
        private DirtyValue<int?> _lineNumber;
        public int? LineNumber { get => _lineNumber; set => _lineNumber = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _actualAmount.Dirty
                    || _allowedAmount.Dirty
                    || _energyEfficientMortgageItemIndex.Dirty
                    || _id.Dirty
                    || _item.Dirty
                    || _lineNumber.Dirty;
            }
            set
            {
                _actualAmount.Dirty = value;
                _allowedAmount.Dirty = value;
                _energyEfficientMortgageItemIndex.Dirty = value;
                _id.Dirty = value;
                _item.Dirty = value;
                _lineNumber.Dirty = value;
            }
        }
    }
}