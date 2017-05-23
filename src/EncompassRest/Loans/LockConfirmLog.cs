using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class LockConfirmLog
    {
        public JsonNullable<bool?> AlertIndicator { get; set; }
        public JsonNullable<List<LogAlert>> Alerts { get; set; }
        public JsonNullable<DateTime?> BuySideExpirationDate { get; set; }
        public JsonNullable<List<LogComment>> CommentList { get; set; }
        public string Comments { get; set; }
        public string ConfirmedBy { get; set; }
        public JsonNullable<bool?> ConfirmedByIdIndicator { get; set; }
        public JsonNullable<DateTime?> DateUtc { get; set; }
        public JsonNullable<bool?> FileAttachmentsMigrated { get; set; }
        public string Guid { get; set; }
        public string Id { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public string RequestGuid { get; set; }
        public string SellSideDeliveredBy { get; set; }
        public JsonNullable<DateTime?> SellSideDeliveryDate { get; set; }
        public JsonNullable<DateTime?> SellSideExpirationDate { get; set; }
        public JsonNullable<string> SystemId { get; set; }
        public string TimeConfirmed { get; set; }
    }
}