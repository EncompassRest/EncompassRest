using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsItemize : IClean
    {
        private Value<string> _date;
        public string Date { get { return _date; } set { _date = value; } }
        private Value<decimal?> _escrowPaymentBalance;
        public decimal? EscrowPaymentBalance { get { return _escrowPaymentBalance; } set { _escrowPaymentBalance = value; } }
        private Value<string> _escrowPaymentDescription;
        public string EscrowPaymentDescription { get { return _escrowPaymentDescription; } set { _escrowPaymentDescription = value; } }
        private Value<decimal?> _escrowPaymentFrom;
        public decimal? EscrowPaymentFrom { get { return _escrowPaymentFrom; } set { _escrowPaymentFrom = value; } }
        private Value<decimal?> _escrowPaymentTo;
        public decimal? EscrowPaymentTo { get { return _escrowPaymentTo; } set { _escrowPaymentTo = value; } }
        private Value<int?> _hud1EsItemizeIndex;
        public int? Hud1EsItemizeIndex { get { return _hud1EsItemizeIndex; } set { _hud1EsItemizeIndex = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _date.Clean
                    && _escrowPaymentBalance.Clean
                    && _escrowPaymentDescription.Clean
                    && _escrowPaymentFrom.Clean
                    && _escrowPaymentTo.Clean
                    && _hud1EsItemizeIndex.Clean
                    && _id.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _date; v0.Clean = value; _date = v0;
                var v1 = _escrowPaymentBalance; v1.Clean = value; _escrowPaymentBalance = v1;
                var v2 = _escrowPaymentDescription; v2.Clean = value; _escrowPaymentDescription = v2;
                var v3 = _escrowPaymentFrom; v3.Clean = value; _escrowPaymentFrom = v3;
                var v4 = _escrowPaymentTo; v4.Clean = value; _escrowPaymentTo = v4;
                var v5 = _hud1EsItemizeIndex; v5.Clean = value; _hud1EsItemizeIndex = v5;
                var v6 = _id; v6.Clean = value; _id = v6;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Hud1EsItemize()
        {
            Clean = true;
        }
    }
}