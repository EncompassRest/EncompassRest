using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LoanSubmissionFee : IDirty
    {
        private DirtyValue<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private DirtyValue<decimal?> _dueBroker;
        public decimal? DueBroker { get { return _dueBroker; } set { _dueBroker = value; } }
        private DirtyValue<decimal?> _dueLender;
        public decimal? DueLender { get { return _dueLender; } set { _dueLender = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _loanSubmissionFeeType;
        public string LoanSubmissionFeeType { get { return _loanSubmissionFeeType; } set { _loanSubmissionFeeType = value; } }
        private DirtyValue<decimal?> _total;
        public decimal? Total { get { return _total; } set { _total = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _description.Dirty
                    || _dueBroker.Dirty
                    || _dueLender.Dirty
                    || _id.Dirty
                    || _loanSubmissionFeeType.Dirty
                    || _total.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _description.Dirty = value;
                _dueBroker.Dirty = value;
                _dueLender.Dirty = value;
                _id.Dirty = value;
                _loanSubmissionFeeType.Dirty = value;
                _total.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}