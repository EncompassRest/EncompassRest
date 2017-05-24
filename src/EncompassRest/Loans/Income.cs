using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Income
    {
        public Value<decimal?> Amount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmount() => !Amount.Clean;
        public Value<bool?> CurrentIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentIndicator() => !CurrentIndicator.Clean;
        public Value<string> Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !Description.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> IncomeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIncomeType() => !IncomeType.Clean;
        public Value<int?> OtherIncomeIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherIncomeIndex() => !OtherIncomeIndex.Clean;
        public Value<string> Owner { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOwner() => !Owner.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Amount.Clean
                    && CurrentIndicator.Clean
                    && Description.Clean
                    && Id.Clean
                    && IncomeType.Clean
                    && OtherIncomeIndex.Clean
                    && Owner.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Amount; v0.Clean = value; Amount = v0;
                var v1 = CurrentIndicator; v1.Clean = value; CurrentIndicator = v1;
                var v2 = Description; v2.Clean = value; Description = v2;
                var v3 = Id; v3.Clean = value; Id = v3;
                var v4 = IncomeType; v4.Clean = value; IncomeType = v4;
                var v5 = OtherIncomeIndex; v5.Clean = value; OtherIncomeIndex = v5;
                var v6 = Owner; v6.Clean = value; Owner = v6;
                _settingClean = 0;
            }
        }
    }
}