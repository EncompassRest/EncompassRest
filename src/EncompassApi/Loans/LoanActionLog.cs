using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassApi.Loans
{
    /// <summary>
    /// LoanActionLog
    /// </summary>
    public sealed partial class LoanActionLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert>? _alerts;
        private DirtyList<LogComment>? _commentList;
        private DirtyValue<string?>? _comments;
        private DirtyValue<DateTime?>? _dateUtc;
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _loanActionType;
        private DirtyValue<string?>? _triggeredBy;
        private DirtyValue<DateTime?>? _updatedDateUtc;

        /// <summary>
        /// LoanActionLog Alerts
        /// </summary>
        [AllowNull]
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

        /// <summary>
        /// LoanActionLog CommentList
        /// </summary>
        [AllowNull]
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

        /// <summary>
        /// LoanActionLog Comments
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// LoanActionLog DateUtc
        /// </summary>
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

        /// <summary>
        /// LoanActionLog Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// LoanActionLog LoanActionType
        /// </summary>
        public string? LoanActionType { get => _loanActionType; set => SetField(ref _loanActionType, value); }

        /// <summary>
        /// LoanActionLog TriggeredBy
        /// </summary>
        public string? TriggeredBy { get => _triggeredBy; set => SetField(ref _triggeredBy, value); }

        /// <summary>
        /// LoanActionLog UpdatedDateUtc
        /// </summary>
        public DateTime? UpdatedDateUtc { get => _updatedDateUtc; set => SetField(ref _updatedDateUtc, value); }
    }
}