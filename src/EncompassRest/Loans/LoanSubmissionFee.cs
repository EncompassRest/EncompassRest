using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LoanSubmissionFee
    {
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !_description.Clean;
        private Value<decimal?> _dueBroker;
        public decimal? DueBroker { get { return _dueBroker; } set { _dueBroker = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDueBroker() => !_dueBroker.Clean;
        private Value<decimal?> _dueLender;
        public decimal? DueLender { get { return _dueLender; } set { _dueLender = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDueLender() => !_dueLender.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _loanSubmissionFeeType;
        public string LoanSubmissionFeeType { get { return _loanSubmissionFeeType; } set { _loanSubmissionFeeType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSubmissionFeeType() => !_loanSubmissionFeeType.Clean;
        private Value<decimal?> _total;
        public decimal? Total { get { return _total; } set { _total = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotal() => !_total.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _description.Clean
                    && _dueBroker.Clean
                    && _dueLender.Clean
                    && _id.Clean
                    && _loanSubmissionFeeType.Clean
                    && _total.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _description; v0.Clean = value; _description = v0;
                var v1 = _dueBroker; v1.Clean = value; _dueBroker = v1;
                var v2 = _dueLender; v2.Clean = value; _dueLender = v2;
                var v3 = _id; v3.Clean = value; _id = v3;
                var v4 = _loanSubmissionFeeType; v4.Clean = value; _loanSubmissionFeeType = v4;
                var v5 = _total; v5.Clean = value; _total = v5;
                _settingClean = 0;
            }
        }
    }
}