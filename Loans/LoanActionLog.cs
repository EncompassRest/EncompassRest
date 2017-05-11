using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class LoanActionLog
    {
        public string Id { get; set; }
        public DateTime? DateUtc { get; set; }
        public string LoanActionType { get; set; }
        public string TriggeredBy { get; set; }
        public List<LogAlert> Alerts { get; set; }
        public List<LogComment> CommentList { get; set; }
        public string Comments { get; set; }
    }
}