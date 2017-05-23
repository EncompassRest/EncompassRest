using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class RegistrationLog
    {
        public JsonNullable<List<LogAlert>> Alerts { get; set; }
        public JsonNullable<List<LogComment>> CommentList { get; set; }
        public string Comments { get; set; }
        public JsonNullable<bool?> CurrentIndicator { get; set; }
        public JsonNullable<DateTime?> DateUtc { get; set; }
        public JsonNullable<DateTime?> ExpiredDate { get; set; }
        public JsonNullable<bool?> FileAttachmentsMigrated { get; set; }
        public string Guid { get; set; }
        public string Id { get; set; }
        public string InvestorName { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public string Reference { get; set; }
        public string RegisteredById { get; set; }
        public string RegisteredByName { get; set; }
        public JsonNullable<DateTime?> RegisteredDate { get; set; }
        public JsonNullable<string> SystemId { get; set; }
    }
}