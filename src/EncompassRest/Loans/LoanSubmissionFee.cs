#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class LoanSubmissionFee : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _description;
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<decimal?> _dueBroker;
        public decimal? DueBroker { get => _dueBroker; set => _dueBroker = value; }
        private DirtyValue<decimal?> _dueLender;
        public decimal? DueLender { get => _dueLender; set => _dueLender = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<StringEnumValue<LoanSubmissionFeeType>> _loanSubmissionFeeType;
        public StringEnumValue<LoanSubmissionFeeType> LoanSubmissionFeeType { get => _loanSubmissionFeeType; set => _loanSubmissionFeeType = value; }
        private DirtyValue<decimal?> _total;
        public decimal? Total { get => _total; set => _total = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _description.Dirty
                    || _dueBroker.Dirty
                    || _dueLender.Dirty
                    || _id.Dirty
                    || _loanSubmissionFeeType.Dirty
                    || _total.Dirty;
            }
            set
            {
                _description.Dirty = value;
                _dueBroker.Dirty = value;
                _dueLender.Dirty = value;
                _id.Dirty = value;
                _loanSubmissionFeeType.Dirty = value;
                _total.Dirty = value;
            }
        }
    }
}