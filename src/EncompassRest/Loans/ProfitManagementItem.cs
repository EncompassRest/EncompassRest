using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ProfitManagementItem : IDirty
    {
        private DirtyValue<decimal?> _atPercent;
        public decimal? AtPercent { get { return _atPercent; } set { _atPercent = value; } }
        private DirtyValue<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _plusAmount;
        public decimal? PlusAmount { get { return _plusAmount; } set { _plusAmount = value; } }
        private DirtyValue<int?> _profitManagementItemIndex;
        public int? ProfitManagementItemIndex { get { return _profitManagementItemIndex; } set { _profitManagementItemIndex = value; } }
        private DirtyValue<decimal?> _total;
        public decimal? Total { get { return _total; } set { _total = value; } }
        private DirtyValue<string> _type;
        public string Type { get { return _type; } set { _type = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _atPercent.Dirty
                    || _description.Dirty
                    || _id.Dirty
                    || _plusAmount.Dirty
                    || _profitManagementItemIndex.Dirty
                    || _total.Dirty
                    || _type.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _atPercent.Dirty = value;
                _description.Dirty = value;
                _id.Dirty = value;
                _plusAmount.Dirty = value;
                _profitManagementItemIndex.Dirty = value;
                _total.Dirty = value;
                _type.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}