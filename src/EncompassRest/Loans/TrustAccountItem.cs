using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class TrustAccountItem : IDirty
    {
        private DirtyValue<DateTime?> _date;
        public DateTime? Date { get { return _date; } set { _date = value; } }
        private DirtyValue<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _notes;
        public string Notes { get { return _notes; } set { _notes = value; } }
        private DirtyValue<decimal?> _paymentAmount;
        public decimal? PaymentAmount { get { return _paymentAmount; } set { _paymentAmount = value; } }
        private DirtyValue<string> _paymentCheckNo;
        public string PaymentCheckNo { get { return _paymentCheckNo; } set { _paymentCheckNo = value; } }
        private DirtyValue<decimal?> _receiptAmount;
        public decimal? ReceiptAmount { get { return _receiptAmount; } set { _receiptAmount = value; } }
        private DirtyValue<string> _receiptCheckNo;
        public string ReceiptCheckNo { get { return _receiptCheckNo; } set { _receiptCheckNo = value; } }
        private DirtyValue<int?> _trustAccountItemIndex;
        public int? TrustAccountItemIndex { get { return _trustAccountItemIndex; } set { _trustAccountItemIndex = value; } }
        private ExtensionDataObject _extensionDataInternal;
        [JsonExtensionData]
        private ExtensionDataObject ExtensionDataInternal { get { return _extensionDataInternal ?? (_extensionDataInternal = new ExtensionDataObject()); } set { _extensionDataInternal = value; } }
        [JsonIgnore]
        public IDictionary<string, object> ExtensionData { get { return ExtensionDataInternal.InternalDictionary; } set { _extensionDataInternal = new ExtensionDataObject(value); } }
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
                  || _extensionDataInternal?.Dirty == true;
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
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}