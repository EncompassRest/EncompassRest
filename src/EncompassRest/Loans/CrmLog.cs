using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class CrmLog
    {
        public JsonNullable<List<LogAlert>> Alerts { get; set; }
        public JsonNullable<List<LogComment>> CommentList { get; set; }
        public string Comments { get; set; }
        public string ContactGuid { get; set; }
        public JsonNullable<DateTime?> DateUtc { get; set; }
        public JsonNullable<bool?> FileAttachmentsMigrated { get; set; }
        public string Guid { get; set; }
        public string Id { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public string MappingId { get; set; }
        public int? MappingType { get; set; }
        public int? RoleType { get; set; }
        public JsonNullable<string> SystemId { get; set; }
    }
}