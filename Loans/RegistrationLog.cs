using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class RegistrationLog
    {
        public string Id { get; set; }
        public List<LogAlert> Alerts { get; set; }
        public List<LogComment> CommentList { get; set; }
        public string Comments { get; set; }
        public bool? CurrentIndicator { get; set; }
        public DateTime? DateUtc { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public bool? FileAttachmentsMigrated { get; set; }
        public string Guid { get; set; }
        public string InvestorName { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public string Reference { get; set; }
        public string RegisteredById { get; set; }
        public string RegisteredByName { get; set; }
        public DateTime? RegisteredDate { get; set; }
        public string SystemId { get; set; }
    }
}