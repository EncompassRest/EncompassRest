using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class TrustAccountItem : IClean
    {
        private Value<DateTime?> _date;
        public DateTime? Date { get { return _date; } set { _date = value; } }
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _notes;
        public string Notes { get { return _notes; } set { _notes = value; } }
        private Value<decimal?> _paymentAmount;
        public decimal? PaymentAmount { get { return _paymentAmount; } set { _paymentAmount = value; } }
        private Value<string> _paymentCheckNo;
        public string PaymentCheckNo { get { return _paymentCheckNo; } set { _paymentCheckNo = value; } }
        private Value<decimal?> _receiptAmount;
        public decimal? ReceiptAmount { get { return _receiptAmount; } set { _receiptAmount = value; } }
        private Value<string> _receiptCheckNo;
        public string ReceiptCheckNo { get { return _receiptCheckNo; } set { _receiptCheckNo = value; } }
        private Value<int?> _trustAccountItemIndex;
        public int? TrustAccountItemIndex { get { return _trustAccountItemIndex; } set { _trustAccountItemIndex = value; } }
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
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public TrustAccountItem()
        {
            Clean = true;
        }
    }
}