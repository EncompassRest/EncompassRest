using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class PrepaymentPenalty
    {
        public Value<string> FullPrepaymentPenaltyOptionType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFullPrepaymentPenaltyOptionType() => !FullPrepaymentPenaltyOptionType.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> PrepaymentPenaltyPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyPercent() => !PrepaymentPenaltyPercent.Clean;
        public Value<int?> TermMonthsCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTermMonthsCount() => !TermMonthsCount.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = FullPrepaymentPenaltyOptionType.Clean
                    && Id.Clean
                    && PrepaymentPenaltyPercent.Clean
                    && TermMonthsCount.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = FullPrepaymentPenaltyOptionType; v0.Clean = value; FullPrepaymentPenaltyOptionType = v0;
                var v1 = Id; v1.Clean = value; Id = v1;
                var v2 = PrepaymentPenaltyPercent; v2.Clean = value; PrepaymentPenaltyPercent = v2;
                var v3 = TermMonthsCount; v3.Clean = value; TermMonthsCount = v3;
                _settingClean = 0;
            }
        }
    }
}