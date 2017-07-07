using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class GfeLien : IClean
    {
        private Value<decimal?> _amountOwing;
        public decimal? AmountOwing { get { return _amountOwing; } set { _amountOwing = value; } }
        private Value<int?> _gfeLienIndex;
        public int? GfeLienIndex { get { return _gfeLienIndex; } set { _gfeLienIndex = value; } }
        private Value<string> _gfeLienType;
        public string GfeLienType { get { return _gfeLienType; } set { _gfeLienType = value; } }
        private Value<string> _holderName;
        public string HolderName { get { return _holderName; } set { _holderName = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _priority;
        public string Priority { get { return _priority; } set { _priority = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _amountOwing.Clean
                    && _gfeLienIndex.Clean
                    && _gfeLienType.Clean
                    && _holderName.Clean
                    && _id.Clean
                    && _priority.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var amountOwing = _amountOwing; amountOwing.Clean = value; _amountOwing = amountOwing;
                var gfeLienIndex = _gfeLienIndex; gfeLienIndex.Clean = value; _gfeLienIndex = gfeLienIndex;
                var gfeLienType = _gfeLienType; gfeLienType.Clean = value; _gfeLienType = gfeLienType;
                var holderName = _holderName; holderName.Clean = value; _holderName = holderName;
                var id = _id; id.Clean = value; _id = id;
                var priority = _priority; priority.Clean = value; _priority = priority;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public GfeLien()
        {
            Clean = true;
        }
    }
}