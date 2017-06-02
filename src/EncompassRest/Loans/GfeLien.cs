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
                var v0 = _amountOwing; v0.Clean = value; _amountOwing = v0;
                var v1 = _gfeLienIndex; v1.Clean = value; _gfeLienIndex = v1;
                var v2 = _gfeLienType; v2.Clean = value; _gfeLienType = v2;
                var v3 = _holderName; v3.Clean = value; _holderName = v3;
                var v4 = _id; v4.Clean = value; _id = v4;
                var v5 = _priority; v5.Clean = value; _priority = v5;
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