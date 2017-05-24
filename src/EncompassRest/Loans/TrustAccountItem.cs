using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class TrustAccountItem
    {
        private Value<DateTime?> _date;
        public DateTime? Date { get { return _date; } set { _date = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDate() => !_date.Clean;
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !_description.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _notes;
        public string Notes { get { return _notes; } set { _notes = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNotes() => !_notes.Clean;
        private Value<decimal?> _paymentAmount;
        public decimal? PaymentAmount { get { return _paymentAmount; } set { _paymentAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentAmount() => !_paymentAmount.Clean;
        private Value<string> _paymentCheckNo;
        public string PaymentCheckNo { get { return _paymentCheckNo; } set { _paymentCheckNo = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentCheckNo() => !_paymentCheckNo.Clean;
        private Value<decimal?> _receiptAmount;
        public decimal? ReceiptAmount { get { return _receiptAmount; } set { _receiptAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceiptAmount() => !_receiptAmount.Clean;
        private Value<string> _receiptCheckNo;
        public string ReceiptCheckNo { get { return _receiptCheckNo; } set { _receiptCheckNo = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceiptCheckNo() => !_receiptCheckNo.Clean;
        private Value<int?> _trustAccountItemIndex;
        public int? TrustAccountItemIndex { get { return _trustAccountItemIndex; } set { _trustAccountItemIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrustAccountItemIndex() => !_trustAccountItemIndex.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _date.Clean
                    && _description.Clean
                    && _id.Clean
                    && _notes.Clean
                    && _paymentAmount.Clean
                    && _paymentCheckNo.Clean
                    && _receiptAmount.Clean
                    && _receiptCheckNo.Clean
                    && _trustAccountItemIndex.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _date; v0.Clean = value; _date = v0;
                var v1 = _description; v1.Clean = value; _description = v1;
                var v2 = _id; v2.Clean = value; _id = v2;
                var v3 = _notes; v3.Clean = value; _notes = v3;
                var v4 = _paymentAmount; v4.Clean = value; _paymentAmount = v4;
                var v5 = _paymentCheckNo; v5.Clean = value; _paymentCheckNo = v5;
                var v6 = _receiptAmount; v6.Clean = value; _receiptAmount = v6;
                var v7 = _receiptCheckNo; v7.Clean = value; _receiptCheckNo = v7;
                var v8 = _trustAccountItemIndex; v8.Clean = value; _trustAccountItemIndex = v8;
                _settingClean = 0;
            }
        }
    }
}