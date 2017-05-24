using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class TrustAccount
    {
        private Value<decimal?> _balance;
        public decimal? Balance { get { return _balance; } set { _balance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBalance() => !_balance.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<decimal?> _total1;
        public decimal? Total1 { get { return _total1; } set { _total1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotal1() => !_total1.Clean;
        private Value<decimal?> _total2;
        public decimal? Total2 { get { return _total2; } set { _total2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotal2() => !_total2.Clean;
        private Value<List<TrustAccountItem>> _trustAccountItems;
        public List<TrustAccountItem> TrustAccountItems { get { return _trustAccountItems; } set { _trustAccountItems = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrustAccountItems() => !_trustAccountItems.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _balance.Clean
                    && _id.Clean
                    && _total1.Clean
                    && _total2.Clean
                    && _trustAccountItems.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _balance; v0.Clean = value; _balance = v0;
                var v1 = _id; v1.Clean = value; _id = v1;
                var v2 = _total1; v2.Clean = value; _total1 = v2;
                var v3 = _total2; v3.Clean = value; _total2 = v3;
                var v4 = _trustAccountItems; v4.Clean = value; _trustAccountItems = v4;
                _settingClean = 0;
            }
        }
    }
}