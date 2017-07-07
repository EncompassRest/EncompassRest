using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Income : IClean
    {
        private Value<decimal?> _amount;
        public decimal? Amount { get { return _amount; } set { _amount = value; } }
        private Value<bool?> _currentIndicator;
        public bool? CurrentIndicator { get { return _currentIndicator; } set { _currentIndicator = value; } }
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _incomeType;
        public string IncomeType { get { return _incomeType; } set { _incomeType = value; } }
        private Value<int?> _otherIncomeIndex;
        public int? OtherIncomeIndex { get { return _otherIncomeIndex; } set { _otherIncomeIndex = value; } }
        private Value<string> _owner;
        public string Owner { get { return _owner; } set { _owner = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _amount.Clean
                    && _currentIndicator.Clean
                    && _description.Clean
                    && _id.Clean
                    && _incomeType.Clean
                    && _otherIncomeIndex.Clean
                    && _owner.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var amount = _amount; amount.Clean = value; _amount = amount;
                var currentIndicator = _currentIndicator; currentIndicator.Clean = value; _currentIndicator = currentIndicator;
                var description = _description; description.Clean = value; _description = description;
                var id = _id; id.Clean = value; _id = id;
                var incomeType = _incomeType; incomeType.Clean = value; _incomeType = incomeType;
                var otherIncomeIndex = _otherIncomeIndex; otherIncomeIndex.Clean = value; _otherIncomeIndex = otherIncomeIndex;
                var owner = _owner; owner.Clean = value; _owner = owner;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Income()
        {
            Clean = true;
        }
    }
}