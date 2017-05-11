using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class VerificationLog
    {
        public string Id { get; set; }
        public string AccessedBy { get; set; }
        public DateTime? AccessedDateUtc { get; set; }
        public string AddedBy { get; set; }
        public List<LogAlert> Alerts { get; set; }
        public List<EntityReference> AllowedRoles { get; set; }
        public DateTime? ArchiveDateUtc { get; set; }
        public string ArchivedBy { get; set; }
        public bool? ClosingDocumentIndicator { get; set; }
        public List<LogComment> CommentList { get; set; }
        public string Comments { get; set; }
        public string Company { get; set; }
        public List<EntityReference> Conditions { get; set; }
        public DateTime? DateAddedUtc { get; set; }
        public DateTime? DateUtc { get; set; }
        public int? DaysDue { get; set; }
        public int? DaysTillExpire { get; set; }
        public bool? EDisclosureIndicator { get; set; }
        public string EPassSignature { get; set; }
        public bool? FileAttachmentsMigrated { get; set; }
        public string Guid { get; set; }
        public bool? IsEPassIndicator { get; set; }
        public bool? IsExternalIndicator { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public bool? IsThirdPartyDocIndicator { get; set; }
        public bool? IsTPOWebcenterPortalIndicator { get; set; }
        public bool? IsWebCenterIndicator { get; set; }
        public string LogId { get; set; }
        public int? LogRecordIndex { get; set; }
        public DateTime? OrderDateUtc { get; set; }
        public string PairId { get; set; }
        public DateTime? ReceiveDateUtc { get; set; }
        public string ReceivedBy { get; set; }
        public DateTime? ReorderDateUtc { get; set; }
        public string RequestedBy { get; set; }
        public string RerequestedBy { get; set; }
        public string ReviewedBy { get; set; }
        public DateTime? ReviewedDateUtc { get; set; }
        public string ShippingReadyBy { get; set; }
        public DateTime? ShippingReadyDateUtc { get; set; }
        public string Stage { get; set; }
        public string SystemId { get; set; }
        public string Title { get; set; }
        public string UnderwritingReadyBy { get; set; }
        public DateTime? UnderwritingReadyDateUtc { get; set; }
        public string DocumentDateTimeType { get; set; }
        public bool? PreClosingDocumentIndicator { get; set; }
        public string RequestedFrom { get; set; }
        public bool? Requested { get; set; }
        public DateTime? DateRequested { get; set; }
        public bool? Rerequested { get; set; }
        public DateTime? DateRerequested { get; set; }
        public bool? Received { get; set; }
        public DateTime? DateReceived { get; set; }
        public DateTime? DateExpected { get; set; }
        public DateTime? DateExpires { get; set; }
        public bool? Expires { get; set; }
        public bool? IsExpired { get; set; }
        public bool? ShippingReady { get; set; }
        public bool? UnderwritingReady { get; set; }
        public bool? Reviewed { get; set; }
        public bool? Expected { get; set; }
        public bool? IsPastDue { get; set; }
        public string Status { get; set; }
        public string ConditionsXml { get; set; }
        public string AllowedRolesXml { get; set; }
        public string AllowedRoleDelimitedList { get; set; }
        public string FileAttachmentsXml { get; set; }
        public string AlertsXml { get; set; }
        public string CommentListXml { get; set; }
    }
}