using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsItemize : IDirty
    {
        private DirtyValue<string> _date;
        public string Date { get { return _date; } set { _date = value; } }
        private DirtyValue<decimal?> _escrowPaymentBalance;
        public decimal? EscrowPaymentBalance { get { return _escrowPaymentBalance; } set { _escrowPaymentBalance = value; } }
        private DirtyValue<string> _escrowPaymentDescription;
        public string EscrowPaymentDescription { get { return _escrowPaymentDescription; } set { _escrowPaymentDescription = value; } }
        private DirtyValue<decimal?> _escrowPaymentFrom;
        public decimal? EscrowPaymentFrom { get { return _escrowPaymentFrom; } set { _escrowPaymentFrom = value; } }
        private DirtyValue<decimal?> _escrowPaymentTo;
        public decimal? EscrowPaymentTo { get { return _escrowPaymentTo; } set { _escrowPaymentTo = value; } }
        private DirtyValue<int?> _hud1EsItemizeIndex;
        public int? Hud1EsItemizeIndex { get { return _hud1EsItemizeIndex; } set { _hud1EsItemizeIndex = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _date.Dirty
                    || _escrowPaymentBalance.Dirty
                    || _escrowPaymentDescription.Dirty
                    || _escrowPaymentFrom.Dirty
                    || _escrowPaymentTo.Dirty
                    || _hud1EsItemizeIndex.Dirty
                    || _id.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _date.Dirty = value;
                _escrowPaymentBalance.Dirty = value;
                _escrowPaymentDescription.Dirty = value;
                _escrowPaymentFrom.Dirty = value;
                _escrowPaymentTo.Dirty = value;
                _hud1EsItemizeIndex.Dirty = value;
                _id.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}