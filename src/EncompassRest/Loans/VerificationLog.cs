using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class VerificationLog
    {
        public string AccessedBy { get; set; }
        public JsonNullable<DateTime?> AccessedDateUtc { get; set; }
        public string AddedBy { get; set; }
        public JsonNullable<List<LogAlert>> Alerts { get; set; }
        public string AlertsXml { get; set; }
        public string AllowedRoleDelimitedList { get; set; }
        public JsonNullable<List<EntityReference>> AllowedRoles { get; set; }
        public string AllowedRolesXml { get; set; }
        public JsonNullable<DateTime?> ArchiveDateUtc { get; set; }
        public string ArchivedBy { get; set; }
        public bool? ClosingDocumentIndicator { get; set; }
        public JsonNullable<List<LogComment>> CommentList { get; set; }
        public string CommentListXml { get; set; }
        public string Comments { get; set; }
        public string Company { get; set; }
        public JsonNullable<List<EntityReference>> Conditions { get; set; }
        public string ConditionsXml { get; set; }
        public JsonNullable<DateTime?> DateAddedUtc { get; set; }
        public JsonNullable<DateTime?> DateExpected { get; set; }
        public JsonNullable<DateTime?> DateExpires { get; set; }
        public JsonNullable<DateTime?> DateReceived { get; set; }
        public JsonNullable<DateTime?> DateRequested { get; set; }
        public JsonNullable<DateTime?> DateRerequested { get; set; }
        public JsonNullable<DateTime?> DateUtc { get; set; }
        public int? DaysDue { get; set; }
        public int? DaysTillExpire { get; set; }
        public string DocumentDateTimeType { get; set; }
        public bool? EDisclosureIndicator { get; set; }
        public string EPassSignature { get; set; }
        public bool? Expected { get; set; }
        public bool? Expires { get; set; }
        public bool? FileAttachmentsMigrated { get; set; }
        public string FileAttachmentsXml { get; set; }
        public string Guid { get; set; }
        public string Id { get; set; }
        public bool? IsEPassIndicator { get; set; }
        public bool? IsExpired { get; set; }
        public bool? IsExternalIndicator { get; set; }
        public bool? IsPastDue { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public bool? IsThirdPartyDocIndicator { get; set; }
        public bool? IsTPOWebcenterPortalIndicator { get; set; }
        public bool? IsWebCenterIndicator { get; set; }
        public string LogId { get; set; }
        public int? LogRecordIndex { get; set; }
        public JsonNullable<DateTime?> OrderDateUtc { get; set; }
        public string PairId { get; set; }
        public bool? PreClosingDocumentIndicator { get; set; }
        public bool? Received { get; set; }
        public JsonNullable<DateTime?> ReceiveDateUtc { get; set; }
        public string ReceivedBy { get; set; }
        public JsonNullable<DateTime?> ReorderDateUtc { get; set; }
        public bool? Requested { get; set; }
        public string RequestedBy { get; set; }
        public string RequestedFrom { get; set; }
        public bool? Rerequested { get; set; }
        public string RerequestedBy { get; set; }
        public bool? Reviewed { get; set; }
        public string ReviewedBy { get; set; }
        public JsonNullable<DateTime?> ReviewedDateUtc { get; set; }
        public bool? ShippingReady { get; set; }
        public string ShippingReadyBy { get; set; }
        public JsonNullable<DateTime?> ShippingReadyDateUtc { get; set; }
        public string Stage { get; set; }
        public string Status { get; set; }
        public JsonNullable<string> SystemId { get; set; }
        public string Title { get; set; }
        public bool? UnderwritingReady { get; set; }
        public string UnderwritingReadyBy { get; set; }
        public JsonNullable<DateTime?> UnderwritingReadyDateUtc { get; set; }
    }
}