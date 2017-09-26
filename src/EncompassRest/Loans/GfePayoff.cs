using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class GfePayoff : IDirty
    {
        private Value<decimal?> _amount;
        public decimal? Amount { get { return _amount; } set { _amount = value; } }
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private Value<int?> _gfePayoffIndex;
        public int? GfePayoffIndex { get { return _gfePayoffIndex; } set { _gfePayoffIndex = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _amount.Dirty
                    || _description.Dirty
                    || _gfePayoffIndex.Dirty
                    || _id.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _amount.Dirty = value;
                _description.Dirty = value;
                _gfePayoffIndex.Dirty = value;
                _id.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}