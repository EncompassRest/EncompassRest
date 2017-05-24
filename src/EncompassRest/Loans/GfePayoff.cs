using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class GfePayoff
    {
        private Value<decimal?> _amount;
        public decimal? Amount { get { return _amount; } set { _amount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmount() => !_amount.Clean;
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !_description.Clean;
        private Value<int?> _gfePayoffIndex;
        public int? GfePayoffIndex { get { return _gfePayoffIndex; } set { _gfePayoffIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfePayoffIndex() => !_gfePayoffIndex.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _amount.Clean
                    && _description.Clean
                    && _gfePayoffIndex.Clean
                    && _id.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _amount; v0.Clean = value; _amount = v0;
                var v1 = _description; v1.Clean = value; _description = v1;
                var v2 = _gfePayoffIndex; v2.Clean = value; _gfePayoffIndex = v2;
                var v3 = _id; v3.Clean = value; _id = v3;
                _settingClean = 0;
            }
        }
    }
}