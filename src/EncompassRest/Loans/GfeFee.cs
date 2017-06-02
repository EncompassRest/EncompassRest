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
                var v0 = _amountDescription; v0.Clean = value; _amountDescription = v0;
                var v1 = _brokerAmount; v1.Clean = value; _brokerAmount = v1;
                var v2 = _description; v2.Clean = value; _description = v2;
                var v3 = _gfeFeeIndex; v3.Clean = value; _gfeFeeIndex = v3;
                var v4 = _gfeFeeType; v4.Clean = value; _gfeFeeType = v4;
                var v5 = _id; v5.Clean = value; _id = v5;
                var v6 = _otherAmount; v6.Clean = value; _otherAmount = v6;
                var v7 = _rate; v7.Clean = value; _rate = v7;
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