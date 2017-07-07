using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LoanSubmissionFee : IClean
    {
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private Value<decimal?> _dueBroker;
        public decimal? DueBroker { get { return _dueBroker; } set { _dueBroker = value; } }
        private Value<decimal?> _dueLender;
        public decimal? DueLender { get { return _dueLender; } set { _dueLender = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _loanSubmissionFeeType;
        public string LoanSubmissionFeeType { get { return _loanSubmissionFeeType; } set { _loanSubmissionFeeType = value; } }
        private Value<decimal?> _total;
        public decimal? Total { get { return _total; } set { _total = value; } }
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
                var description = _description; description.Clean = value; _description = description;
                var dueBroker = _dueBroker; dueBroker.Clean = value; _dueBroker = dueBroker;
                var dueLender = _dueLender; dueLender.Clean = value; _dueLender = dueLender;
                var id = _id; id.Clean = value; _id = id;
                var loanSubmissionFeeType = _loanSubmissionFeeType; loanSubmissionFeeType.Clean = value; _loanSubmissionFeeType = loanSubmissionFeeType;
                var total = _total; total.Clean = value; _total = total;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public LoanSubmissionFee()
        {
            Clean = true;
        }
    }
}