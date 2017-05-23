using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class LoanActionLog
    {
        public JsonNullable<List<LogAlert>> Alerts { get; set; }
        public JsonNullable<List<LogComment>> CommentList { get; set; }
        public string Comments { get; set; }
        public JsonNullable<DateTime?> DateUtc { get; set; }
        public string Id { get; set; }
        public string LoanActionType { get; set; }
        public string TriggeredBy { get; set; }
    }
}