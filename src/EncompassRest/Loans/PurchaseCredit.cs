using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class PurchaseCredit : IClean
    {
        private Value<decimal?> _amount;
        public decimal? Amount { get { return _amount; } set { _amount = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _purchaseCreditType;
        public string PurchaseCreditType { get { return _purchaseCreditType; } set { _purchaseCreditType = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _amount.Clean
                    && _id.Clean
                    && _purchaseCreditType.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var amount = _amount; amount.Clean = value; _amount = amount;
                var id = _id; id.Clean = value; _id = id;
                var purchaseCreditType = _purchaseCreditType; purchaseCreditType.Clean = value; _purchaseCreditType = purchaseCreditType;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public PurchaseCredit()
        {
            Clean = true;
        }
    }
}