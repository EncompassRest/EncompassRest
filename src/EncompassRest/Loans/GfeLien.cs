using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class GfeLien : IDirty
    {
        private DirtyValue<decimal?> _amountOwing;
        public decimal? AmountOwing { get { return _amountOwing; } set { _amountOwing = value; } }
        private DirtyValue<int?> _gfeLienIndex;
        public int? GfeLienIndex { get { return _gfeLienIndex; } set { _gfeLienIndex = value; } }
        private DirtyValue<string> _gfeLienType;
        public string GfeLienType { get { return _gfeLienType; } set { _gfeLienType = value; } }
        private DirtyValue<string> _holderName;
        public string HolderName { get { return _holderName; } set { _holderName = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _priority;
        public string Priority { get { return _priority; } set { _priority = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _amountOwing.Dirty
                    || _gfeLienIndex.Dirty
                    || _gfeLienType.Dirty
                    || _holderName.Dirty
                    || _id.Dirty
                    || _priority.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _amountOwing.Dirty = value;
                _gfeLienIndex.Dirty = value;
                _gfeLienType.Dirty = value;
                _holderName.Dirty = value;
                _id.Dirty = value;
                _priority.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}