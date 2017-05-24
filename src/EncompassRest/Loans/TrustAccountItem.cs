using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class TrustAccountItem
    {
        public Value<DateTime?> Date { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDate() => !Date.Clean;
        public Value<string> Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !Description.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> Notes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNotes() => !Notes.Clean;
        public Value<decimal?> PaymentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentAmount() => !PaymentAmount.Clean;
        public Value<string> PaymentCheckNo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentCheckNo() => !PaymentCheckNo.Clean;
        public Value<decimal?> ReceiptAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceiptAmount() => !ReceiptAmount.Clean;
        public Value<string> ReceiptCheckNo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceiptCheckNo() => !ReceiptCheckNo.Clean;
        public Value<int?> TrustAccountItemIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrustAccountItemIndex() => !TrustAccountItemIndex.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Date.Clean
                    && Description.Clean
                    && Id.Clean
                    && Notes.Clean
                    && PaymentAmount.Clean
                    && PaymentCheckNo.Clean
                    && ReceiptAmount.Clean
                    && ReceiptCheckNo.Clean
                    && TrustAccountItemIndex.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Date; v0.Clean = value; Date = v0;
                var v1 = Description; v1.Clean = value; Description = v1;
                var v2 = Id; v2.Clean = value; Id = v2;
                var v3 = Notes; v3.Clean = value; Notes = v3;
                var v4 = PaymentAmount; v4.Clean = value; PaymentAmount = v4;
                var v5 = PaymentCheckNo; v5.Clean = value; PaymentCheckNo = v5;
                var v6 = ReceiptAmount; v6.Clean = value; ReceiptAmount = v6;
                var v7 = ReceiptCheckNo; v7.Clean = value; ReceiptCheckNo = v7;
                var v8 = TrustAccountItemIndex; v8.Clean = value; TrustAccountItemIndex = v8;
                _settingClean = 0;
            }
        }
    }
}