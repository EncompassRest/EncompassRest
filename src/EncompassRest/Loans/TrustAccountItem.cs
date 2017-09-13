using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class TrustAccountItem : IDirty
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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _date.Dirty
                    || _description.Dirty
                    || _id.Dirty
                    || _notes.Dirty
                    || _paymentAmount.Dirty
                    || _paymentCheckNo.Dirty
                    || _receiptAmount.Dirty
                    || _receiptCheckNo.Dirty
                    || _trustAccountItemIndex.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _date.Dirty = value;
                _description.Dirty = value;
                _id.Dirty = value;
                _notes.Dirty = value;
                _paymentAmount.Dirty = value;
                _paymentCheckNo.Dirty = value;
                _receiptAmount.Dirty = value;
                _receiptCheckNo.Dirty = value;
                _trustAccountItemIndex.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}