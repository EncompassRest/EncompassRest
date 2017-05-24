using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsItemize
    {
        public Value<string> Date { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDate() => !Date.Clean;
        public Value<decimal?> EscrowPaymentBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowPaymentBalance() => !EscrowPaymentBalance.Clean;
        public Value<string> EscrowPaymentDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowPaymentDescription() => !EscrowPaymentDescription.Clean;
        public Value<decimal?> EscrowPaymentFrom { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowPaymentFrom() => !EscrowPaymentFrom.Clean;
        public Value<decimal?> EscrowPaymentTo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowPaymentTo() => !EscrowPaymentTo.Clean;
        public Value<int?> Hud1EsItemizeIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1EsItemizeIndex() => !Hud1EsItemizeIndex.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Date.Clean
                    && EscrowPaymentBalance.Clean
                    && EscrowPaymentDescription.Clean
                    && EscrowPaymentFrom.Clean
                    && EscrowPaymentTo.Clean
                    && Hud1EsItemizeIndex.Clean
                    && Id.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Date; v0.Clean = value; Date = v0;
                var v1 = EscrowPaymentBalance; v1.Clean = value; EscrowPaymentBalance = v1;
                var v2 = EscrowPaymentDescription; v2.Clean = value; EscrowPaymentDescription = v2;
                var v3 = EscrowPaymentFrom; v3.Clean = value; EscrowPaymentFrom = v3;
                var v4 = EscrowPaymentTo; v4.Clean = value; EscrowPaymentTo = v4;
                var v5 = Hud1EsItemizeIndex; v5.Clean = value; Hud1EsItemizeIndex = v5;
                var v6 = Id; v6.Clean = value; Id = v6;
                _settingClean = 0;
            }
        }
    }
}