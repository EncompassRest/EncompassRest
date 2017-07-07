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
                var date = _date; date.Clean = value; _date = date;
                var description = _description; description.Clean = value; _description = description;
                var id = _id; id.Clean = value; _id = id;
                var notes = _notes; notes.Clean = value; _notes = notes;
                var paymentAmount = _paymentAmount; paymentAmount.Clean = value; _paymentAmount = paymentAmount;
                var paymentCheckNo = _paymentCheckNo; paymentCheckNo.Clean = value; _paymentCheckNo = paymentCheckNo;
                var receiptAmount = _receiptAmount; receiptAmount.Clean = value; _receiptAmount = receiptAmount;
                var receiptCheckNo = _receiptCheckNo; receiptCheckNo.Clean = value; _receiptCheckNo = receiptCheckNo;
                var trustAccountItemIndex = _trustAccountItemIndex; trustAccountItemIndex.Clean = value; _trustAccountItemIndex = trustAccountItemIndex;
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