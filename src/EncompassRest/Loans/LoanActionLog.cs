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
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// LoanActionLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// LoanActionLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// LoanActionLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// LoanActionLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _loanActionType;
        /// <summary>
        /// LoanActionLog LoanActionType
        /// </summary>
        public string LoanActionType { get => _loanActionType; set => SetField(ref _loanActionType, value); }
        private DirtyValue<string> _triggeredBy;
        /// <summary>
        /// LoanActionLog TriggeredBy
        /// </summary>
        public string TriggeredBy { get => _triggeredBy; set => SetField(ref _triggeredBy, value); }
    }
}