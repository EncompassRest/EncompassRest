using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LoanActionLog
    /// </summary>
    public sealed partial class LoanActionLog : ExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// LoanActionLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// LoanActionLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// LoanActionLog Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// LoanActionLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// LoanActionLog Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _loanActionType;
        /// <summary>
        /// LoanActionLog LoanActionType
        /// </summary>
        public string LoanActionType { get => _loanActionType; set => _loanActionType = value; }
        private DirtyValue<string> _triggeredBy;
        /// <summary>
        /// LoanActionLog TriggeredBy
        /// </summary>
        public string TriggeredBy { get => _triggeredBy; set => _triggeredBy = value; }
    }
}