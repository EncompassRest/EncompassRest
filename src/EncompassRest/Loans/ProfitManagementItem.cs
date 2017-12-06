#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class ProfitManagementItem : ExtensibleObject
    {
        private DirtyValue<decimal?> _atPercent;
        public decimal? AtPercent { get => _atPercent; set => _atPercent = value; }
        private DirtyValue<string> _description;
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _plusAmount;
        public decimal? PlusAmount { get => _plusAmount; set => _plusAmount = value; }
        private DirtyValue<int?> _profitManagementItemIndex;
        public int? ProfitManagementItemIndex { get => _profitManagementItemIndex; set => _profitManagementItemIndex = value; }
        private DirtyValue<decimal?> _total;
        public decimal? Total { get => _total; set => _total = value; }
        private DirtyValue<StringEnumValue<ProfitManagementItemType>> _type;
        public StringEnumValue<ProfitManagementItemType> Type { get => _type; set => _type = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _atPercent.Dirty
                    || _description.Dirty
                    || _id.Dirty
                    || _plusAmount.Dirty
                    || _profitManagementItemIndex.Dirty
                    || _total.Dirty
                    || _type.Dirty;
            }
            set
            {
                _atPercent.Dirty = value;
                _description.Dirty = value;
                _id.Dirty = value;
                _plusAmount.Dirty = value;
                _profitManagementItemIndex.Dirty = value;
                _total.Dirty = value;
                _type.Dirty = value;
            }
        }
    }
}