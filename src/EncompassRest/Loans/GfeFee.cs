using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class GfeFee : IClean
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
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _amountDescription.Clean
                    && _brokerAmount.Clean
                    && _description.Clean
                    && _gfeFeeIndex.Clean
                    && _gfeFeeType.Clean
                    && _id.Clean
                    && _otherAmount.Clean
                    && _rate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var amountDescription = _amountDescription; amountDescription.Clean = value; _amountDescription = amountDescription;
                var brokerAmount = _brokerAmount; brokerAmount.Clean = value; _brokerAmount = brokerAmount;
                var description = _description; description.Clean = value; _description = description;
                var gfeFeeIndex = _gfeFeeIndex; gfeFeeIndex.Clean = value; _gfeFeeIndex = gfeFeeIndex;
                var gfeFeeType = _gfeFeeType; gfeFeeType.Clean = value; _gfeFeeType = gfeFeeType;
                var id = _id; id.Clean = value; _id = id;
                var otherAmount = _otherAmount; otherAmount.Clean = value; _otherAmount = otherAmount;
                var rate = _rate; rate.Clean = value; _rate = rate;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public GfeFee()
        {
            Clean = true;
        }
    }
}