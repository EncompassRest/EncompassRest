using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LoanActionLog : IClean
    {
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _loanActionType;
        public string LoanActionType { get { return _loanActionType; } set { _loanActionType = value; } }
        private Value<string> _triggeredBy;
        public string TriggeredBy { get { return _triggeredBy; } set { _triggeredBy = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _alerts.Clean
                    && _commentList.Clean
                    && _comments.Clean
                    && _dateUtc.Clean
                    && _id.Clean
                    && _loanActionType.Clean
                    && _triggeredBy.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var alerts = _alerts; alerts.Clean = value; _alerts = alerts;
                var commentList = _commentList; commentList.Clean = value; _commentList = commentList;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var dateUtc = _dateUtc; dateUtc.Clean = value; _dateUtc = dateUtc;
                var id = _id; id.Clean = value; _id = id;
                var loanActionType = _loanActionType; loanActionType.Clean = value; _loanActionType = loanActionType;
                var triggeredBy = _triggeredBy; triggeredBy.Clean = value; _triggeredBy = triggeredBy;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public LoanActionLog()
        {
            Clean = true;
        }
    }
}