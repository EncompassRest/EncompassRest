using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class GfeFee : IDirty
    {
        private DirtyValue<string> _amountDescription;
        public string AmountDescription { get { return _amountDescription; } set { _amountDescription = value; } }
        private DirtyValue<decimal?> _brokerAmount;
        public decimal? BrokerAmount { get { return _brokerAmount; } set { _brokerAmount = value; } }
        private DirtyValue<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private DirtyValue<int?> _gfeFeeIndex;
        public int? GfeFeeIndex { get { return _gfeFeeIndex; } set { _gfeFeeIndex = value; } }
        private StringEnumValue<GfeFeeType> _gfeFeeType;
        public StringEnumValue<GfeFeeType> GfeFeeType { get { return _gfeFeeType; } set { _gfeFeeType = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _otherAmount;
        public decimal? OtherAmount { get { return _otherAmount; } set { _otherAmount = value; } }
        private DirtyValue<string> _rate;
        public string Rate { get { return _rate; } set { _rate = value; } }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get { return _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); } set { _extensionData = new DirtyDictionary<string, object>(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _amountDescription.Dirty
                    || _brokerAmount.Dirty
                    || _description.Dirty
                    || _gfeFeeIndex.Dirty
                    || _gfeFeeType.Dirty
                    || _id.Dirty
                    || _otherAmount.Dirty
                    || _rate.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _amountDescription.Dirty = value;
                _brokerAmount.Dirty = value;
                _description.Dirty = value;
                _gfeFeeIndex.Dirty = value;
                _gfeFeeType.Dirty = value;
                _id.Dirty = value;
                _otherAmount.Dirty = value;
                _rate.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}