#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class LoanActionLog : ExtensibleObject
    {
        private DirtyList<LogAlert> _alerts;
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyList<LogComment> _commentList;
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<DateTime?> _dateUtc;
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _loanActionType;
        public string LoanActionType { get => _loanActionType; set => _loanActionType = value; }
        private DirtyValue<string> _triggeredBy;
        public string TriggeredBy { get => _triggeredBy; set => _triggeredBy = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _comments.Dirty
                    || _dateUtc.Dirty
                    || _id.Dirty
                    || _loanActionType.Dirty
                    || _triggeredBy.Dirty
                    || _alerts?.Dirty == true
                    || _commentList?.Dirty == true;
            }
            set
            {
                _comments.Dirty = value;
                _dateUtc.Dirty = value;
                _id.Dirty = value;
                _loanActionType.Dirty = value;
                _triggeredBy.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
            }
        }
    }
}