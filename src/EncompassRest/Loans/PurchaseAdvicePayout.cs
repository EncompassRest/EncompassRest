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
                var amount = _amount; amount.Clean = value; _amount = amount;
                var description = _description; description.Clean = value; _description = description;
                var diffAmount = _diffAmount; diffAmount.Clean = value; _diffAmount = diffAmount;
                var expectedAmount = _expectedAmount; expectedAmount.Clean = value; _expectedAmount = expectedAmount;
                var id = _id; id.Clean = value; _id = id;
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