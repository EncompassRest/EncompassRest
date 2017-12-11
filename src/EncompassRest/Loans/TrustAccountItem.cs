#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class TrustAccountItem : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _date;
        public DateTime? Date { get => _date; set => _date = value; }
        private DirtyValue<string> _description;
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _notes;
        public string Notes { get => _notes; set => _notes = value; }
        private DirtyValue<decimal?> _paymentAmount;
        public decimal? PaymentAmount { get => _paymentAmount; set => _paymentAmount = value; }
        private DirtyValue<string> _paymentCheckNo;
        public string PaymentCheckNo { get => _paymentCheckNo; set => _paymentCheckNo = value; }
        private DirtyValue<decimal?> _receiptAmount;
        public decimal? ReceiptAmount { get => _receiptAmount; set => _receiptAmount = value; }
        private DirtyValue<string> _receiptCheckNo;
        public string ReceiptCheckNo { get => _receiptCheckNo; set => _receiptCheckNo = value; }
        private DirtyValue<int?> _trustAccountItemIndex;
        public int? TrustAccountItemIndex { get => _trustAccountItemIndex; set => _trustAccountItemIndex = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _date.Dirty
                    || _description.Dirty
                    || _id.Dirty
                    || _notes.Dirty
                    || _paymentAmount.Dirty
                    || _paymentCheckNo.Dirty
                    || _receiptAmount.Dirty
                    || _receiptCheckNo.Dirty
                    || _trustAccountItemIndex.Dirty;
            }
            set
            {
                _date.Dirty = value;
                _description.Dirty = value;
                _id.Dirty = value;
                _notes.Dirty = value;
                _paymentAmount.Dirty = value;
                _paymentCheckNo.Dirty = value;
                _receiptAmount.Dirty = value;
                _receiptCheckNo.Dirty = value;
                _trustAccountItemIndex.Dirty = value;
            }
        }
    }
}