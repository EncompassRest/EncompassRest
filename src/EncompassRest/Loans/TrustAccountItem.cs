using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class TrustAccountItem : IDirty
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
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _date.Dirty
                    || _description.Dirty
                    || _id.Dirty
                    || _notes.Dirty
                    || _paymentAmount.Dirty
                    || _paymentCheckNo.Dirty
                    || _receiptAmount.Dirty
                    || _receiptCheckNo.Dirty
                    || _trustAccountItemIndex.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _date.Dirty = value;
                _description.Dirty = value;
                _id.Dirty = value;
                _notes.Dirty = value;
                _paymentAmount.Dirty = value;
                _paymentCheckNo.Dirty = value;
                _receiptAmount.Dirty = value;
                _receiptCheckNo.Dirty = value;
                _trustAccountItemIndex.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}