using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LoanSubmissionFee
    {
        public Value<string> Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !Description.Clean;
        public Value<decimal?> DueBroker { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDueBroker() => !DueBroker.Clean;
        public Value<decimal?> DueLender { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDueLender() => !DueLender.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> LoanSubmissionFeeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSubmissionFeeType() => !LoanSubmissionFeeType.Clean;
        public Value<decimal?> Total { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotal() => !Total.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Description.Clean
                    && DueBroker.Clean
                    && DueLender.Clean
                    && Id.Clean
                    && LoanSubmissionFeeType.Clean
                    && Total.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Description; v0.Clean = value; Description = v0;
                var v1 = DueBroker; v1.Clean = value; DueBroker = v1;
                var v2 = DueLender; v2.Clean = value; DueLender = v2;
                var v3 = Id; v3.Clean = value; Id = v3;
                var v4 = LoanSubmissionFeeType; v4.Clean = value; LoanSubmissionFeeType = v4;
                var v5 = Total; v5.Clean = value; Total = v5;
                _settingClean = 0;
            }
        }
    }
}