using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class PurchaseAdvicePayout : IClean
    {
        private Value<decimal?> _amount;
        public decimal? Amount { get { return _amount; } set { _amount = value; } }
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private Value<decimal?> _diffAmount;
        public decimal? DiffAmount { get { return _diffAmount; } set { _diffAmount = value; } }
        private Value<decimal?> _expectedAmount;
        public decimal? ExpectedAmount { get { return _expectedAmount; } set { _expectedAmount = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _amount.Clean
                    && _description.Clean
                    && _diffAmount.Clean
                    && _expectedAmount.Clean
                    && _id.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _amount; v0.Clean = value; _amount = v0;
                var v1 = _description; v1.Clean = value; _description = v1;
                var v2 = _diffAmount; v2.Clean = value; _diffAmount = v2;
                var v3 = _expectedAmount; v3.Clean = value; _expectedAmount = v3;
                var v4 = _id; v4.Clean = value; _id = v4;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public PurchaseAdvicePayout()
        {
            Clean = true;
        }
    }
}