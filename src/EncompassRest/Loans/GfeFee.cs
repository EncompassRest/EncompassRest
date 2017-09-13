using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class GfeFee : IDirty
    {
        private Value<string> _amountDescription;
        public string AmountDescription { get { return _amountDescription; } set { _amountDescription = value; } }
        private Value<decimal?> _brokerAmount;
        public decimal? BrokerAmount { get { return _brokerAmount; } set { _brokerAmount = value; } }
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private Value<int?> _gfeFeeIndex;
        public int? GfeFeeIndex { get { return _gfeFeeIndex; } set { _gfeFeeIndex = value; } }
        private Value<string> _gfeFeeType;
        public string GfeFeeType { get { return _gfeFeeType; } set { _gfeFeeType = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _otherAmount;
        public decimal? OtherAmount { get { return _otherAmount; } set { _otherAmount = value; } }
        private Value<string> _rate;
        public string Rate { get { return _rate; } set { _rate = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _amountDescription.Dirty
                    || _brokerAmount.Dirty
                    || _description.Dirty
                    || _gfeFeeIndex.Dirty
                    || _gfeFeeType.Dirty
                    || _id.Dirty
                    || _otherAmount.Dirty
                    || _rate.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _amountDescription.Dirty = value;
                _brokerAmount.Dirty = value;
                _description.Dirty = value;
                _gfeFeeIndex.Dirty = value;
                _gfeFeeType.Dirty = value;
                _id.Dirty = value;
                _otherAmount.Dirty = value;
                _rate.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}