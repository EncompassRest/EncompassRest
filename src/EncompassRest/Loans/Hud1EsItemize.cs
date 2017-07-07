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
                var date = _date; date.Clean = value; _date = date;
                var escrowPaymentBalance = _escrowPaymentBalance; escrowPaymentBalance.Clean = value; _escrowPaymentBalance = escrowPaymentBalance;
                var escrowPaymentDescription = _escrowPaymentDescription; escrowPaymentDescription.Clean = value; _escrowPaymentDescription = escrowPaymentDescription;
                var escrowPaymentFrom = _escrowPaymentFrom; escrowPaymentFrom.Clean = value; _escrowPaymentFrom = escrowPaymentFrom;
                var escrowPaymentTo = _escrowPaymentTo; escrowPaymentTo.Clean = value; _escrowPaymentTo = escrowPaymentTo;
                var hud1EsItemizeIndex = _hud1EsItemizeIndex; hud1EsItemizeIndex.Clean = value; _hud1EsItemizeIndex = hud1EsItemizeIndex;
                var id = _id; id.Clean = value; _id = id;
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