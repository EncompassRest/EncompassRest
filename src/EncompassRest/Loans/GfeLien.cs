#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class GfeLien : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _amountOwing;
        public decimal? AmountOwing { get => _amountOwing; set => _amountOwing = value; }
        private DirtyValue<int?> _gfeLienIndex;
        public int? GfeLienIndex { get => _gfeLienIndex; set => _gfeLienIndex = value; }
        private DirtyValue<StringEnumValue<GfeLienType>> _gfeLienType;
        public StringEnumValue<GfeLienType> GfeLienType { get => _gfeLienType; set => _gfeLienType = value; }
        private DirtyValue<string> _holderName;
        public string HolderName { get => _holderName; set => _holderName = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _priority;
        public string Priority { get => _priority; set => _priority = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _amountOwing.Dirty
                    || _gfeLienIndex.Dirty
                    || _gfeLienType.Dirty
                    || _holderName.Dirty
                    || _id.Dirty
                    || _priority.Dirty;
            }
            set
            {
                _amountOwing.Dirty = value;
                _gfeLienIndex.Dirty = value;
                _gfeLienType.Dirty = value;
                _holderName.Dirty = value;
                _id.Dirty = value;
                _priority.Dirty = value;
            }
        }
    }
}