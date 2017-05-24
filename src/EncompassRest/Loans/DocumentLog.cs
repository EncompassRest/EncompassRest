using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class DocumentLog
    {
        public Value<string> AccessedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAccessedBy() => !AccessedBy.Clean;
        public Value<DateTime?> AccessedDateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAccessedDateUtc() => !AccessedDateUtc.Clean;
        public Value<string> AddedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddedBy() => !AddedBy.Clean;
        public Value<List<LogAlert>> Alerts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlerts() => !Alerts.Clean;
        public Value<string> AlertsXml { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlertsXml() => !AlertsXml.Clean;
        public Value<string> AllowedRoleDelimitedList { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllowedRoleDelimitedList() => !AllowedRoleDelimitedList.Clean;
        public Value<List<EntityReference>> AllowedRoles { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllowedRoles() => !AllowedRoles.Clean;
        public Value<string> AllowedRolesXml { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllowedRolesXml() => !AllowedRolesXml.Clean;
        public Value<DateTime?> ArchiveDateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeArchiveDateUtc() => !ArchiveDateUtc.Clean;
        public Value<string> ArchivedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeArchivedBy() => !ArchivedBy.Clean;
        public Value<bool?> ClosingDocumentIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingDocumentIndicator() => !ClosingDocumentIndicator.Clean;
        public Value<List<LogComment>> CommentList { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentList() => !CommentList.Clean;
        public Value<string> CommentListXml { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentListXml() => !CommentListXml.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<string> Company { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompany() => !Company.Clean;
        public Value<List<EntityReference>> Conditions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConditions() => !Conditions.Clean;
        public Value<string> ConditionsXml { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConditionsXml() => !ConditionsXml.Clean;
        public Value<DateTime?> DateAddedUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateAddedUtc() => !DateAddedUtc.Clean;
        public Value<DateTime?> DateExpected { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateExpected() => !DateExpected.Clean;
        public Value<DateTime?> DateExpires { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateExpires() => !DateExpires.Clean;
        public Value<DateTime?> DateReceived { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateReceived() => !DateReceived.Clean;
        public Value<DateTime?> DateRequested { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateRequested() => !DateRequested.Clean;
        public Value<DateTime?> DateRerequested { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateRerequested() => !DateRerequested.Clean;
        public Value<DateTime?> DateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateUtc() => !DateUtc.Clean;
        public Value<int?> DaysDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDaysDue() => !DaysDue.Clean;
        public Value<int?> DaysTillExpire { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDaysTillExpire() => !DaysTillExpire.Clean;
        public Value<string> DocumentDateTimeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocumentDateTimeType() => !DocumentDateTimeType.Clean;
        public Value<bool?> EDisclosureIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureIndicator() => !EDisclosureIndicator.Clean;
        public Value<string> EPassSignature { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEPassSignature() => !EPassSignature.Clean;
        public Value<bool?> Expected { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpected() => !Expected.Clean;
        public Value<bool?> Expires { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpires() => !Expires.Clean;
        public Value<List<FileAttachmentReference>> FileAttachmentReferences { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileAttachmentReferences() => !FileAttachmentReferences.Clean;
        public Value<bool?> FileAttachmentsMigrated { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileAttachmentsMigrated() => !FileAttachmentsMigrated.Clean;
        public Value<string> FileAttachmentsXml { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileAttachmentsXml() => !FileAttachmentsXml.Clean;
        public Value<string> Guid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuid() => !Guid.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IsEPassIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEPassIndicator() => !IsEPassIndicator.Clean;
        public Value<bool?> IsExpired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsExpired() => !IsExpired.Clean;
        public Value<bool?> IsPastDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsPastDue() => !IsPastDue.Clean;
        public Value<bool?> IsSystemSpecificIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsSystemSpecificIndicator() => !IsSystemSpecificIndicator.Clean;
        public Value<bool?> IsThirdPartyDocIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsThirdPartyDocIndicator() => !IsThirdPartyDocIndicator.Clean;
        public Value<bool?> IsTPOWebcenterPortalIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsTPOWebcenterPortalIndicator() => !IsTPOWebcenterPortalIndicator.Clean;
        public Value<bool?> IsWebCenterIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsWebCenterIndicator() => !IsWebCenterIndicator.Clean;
        public Value<int?> LogRecordIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLogRecordIndex() => !LogRecordIndex.Clean;
        public Value<DateTime?> OrderDateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOrderDateUtc() => !OrderDateUtc.Clean;
        public Value<string> PairId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePairId() => !PairId.Clean;
        public Value<bool?> PreClosingDocumentIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreClosingDocumentIndicator() => !PreClosingDocumentIndicator.Clean;
        public Value<bool?> Received { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceived() => !Received.Clean;
        public Value<DateTime?> ReceiveDateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceiveDateUtc() => !ReceiveDateUtc.Clean;
        public Value<string> ReceivedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceivedBy() => !ReceivedBy.Clean;
        public Value<DateTime?> ReorderDateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReorderDateUtc() => !ReorderDateUtc.Clean;
        public Value<bool?> Requested { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequested() => !Requested.Clean;
        public Value<string> RequestedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestedBy() => !RequestedBy.Clean;
        public Value<string> RequestedFrom { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestedFrom() => !RequestedFrom.Clean;
        public Value<bool?> Rerequested { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRerequested() => !Rerequested.Clean;
        public Value<string> RerequestedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRerequestedBy() => !RerequestedBy.Clean;
        public Value<bool?> Reviewed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReviewed() => !Reviewed.Clean;
        public Value<string> ReviewedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReviewedBy() => !ReviewedBy.Clean;
        public Value<DateTime?> ReviewedDateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReviewedDateUtc() => !ReviewedDateUtc.Clean;
        public Value<bool?> ShippingReady { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeShippingReady() => !ShippingReady.Clean;
        public Value<string> ShippingReadyBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeShippingReadyBy() => !ShippingReadyBy.Clean;
        public Value<DateTime?> ShippingReadyDateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeShippingReadyDateUtc() => !ShippingReadyDateUtc.Clean;
        public Value<string> Stage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStage() => !Stage.Clean;
        public Value<string> Status { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStatus() => !Status.Clean;
        public Value<string> SystemId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSystemId() => !SystemId.Clean;
        public Value<string> Title { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle() => !Title.Clean;
        public Value<bool?> UnderwritingReady { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingReady() => !UnderwritingReady.Clean;
        public Value<string> UnderwritingReadyBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingReadyBy() => !UnderwritingReadyBy.Clean;
        public Value<DateTime?> UnderwritingReadyDateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingReadyDateUtc() => !UnderwritingReadyDateUtc.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AccessedBy.Clean
                    && AccessedDateUtc.Clean
                    && AddedBy.Clean
                    && Alerts.Clean
                    && AlertsXml.Clean
                    && AllowedRoleDelimitedList.Clean
                    && AllowedRoles.Clean
                    && AllowedRolesXml.Clean
                    && ArchiveDateUtc.Clean
                    && ArchivedBy.Clean
                    && ClosingDocumentIndicator.Clean
                    && CommentList.Clean
                    && CommentListXml.Clean
                    && Comments.Clean
                    && Company.Clean
                    && Conditions.Clean
                    && ConditionsXml.Clean
                    && DateAddedUtc.Clean
                    && DateExpected.Clean
                    && DateExpires.Clean
                    && DateReceived.Clean
                    && DateRequested.Clean
                    && DateRerequested.Clean
                    && DateUtc.Clean
                    && DaysDue.Clean
                    && DaysTillExpire.Clean
                    && DocumentDateTimeType.Clean
                    && EDisclosureIndicator.Clean
                    && EPassSignature.Clean
                    && Expected.Clean
                    && Expires.Clean
                    && FileAttachmentReferences.Clean
                    && FileAttachmentsMigrated.Clean
                    && FileAttachmentsXml.Clean
                    && Guid.Clean
                    && Id.Clean
                    && IsEPassIndicator.Clean
                    && IsExpired.Clean
                    && IsPastDue.Clean
                    && IsSystemSpecificIndicator.Clean
                    && IsThirdPartyDocIndicator.Clean
                    && IsTPOWebcenterPortalIndicator.Clean
                    && IsWebCenterIndicator.Clean
                    && LogRecordIndex.Clean
                    && OrderDateUtc.Clean
                    && PairId.Clean
                    && PreClosingDocumentIndicator.Clean
                    && Received.Clean
                    && ReceiveDateUtc.Clean
                    && ReceivedBy.Clean
                    && ReorderDateUtc.Clean
                    && Requested.Clean
                    && RequestedBy.Clean
                    && RequestedFrom.Clean
                    && Rerequested.Clean
                    && RerequestedBy.Clean
                    && Reviewed.Clean
                    && ReviewedBy.Clean
                    && ReviewedDateUtc.Clean
                    && ShippingReady.Clean
                    && ShippingReadyBy.Clean
                    && ShippingReadyDateUtc.Clean
                    && Stage.Clean
                    && Status.Clean
                    && SystemId.Clean
                    && Title.Clean
                    && UnderwritingReady.Clean
                    && UnderwritingReadyBy.Clean
                    && UnderwritingReadyDateUtc.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AccessedBy; v0.Clean = value; AccessedBy = v0;
                var v1 = AccessedDateUtc; v1.Clean = value; AccessedDateUtc = v1;
                var v2 = AddedBy; v2.Clean = value; AddedBy = v2;
                var v3 = Alerts; v3.Clean = value; Alerts = v3;
                var v4 = AlertsXml; v4.Clean = value; AlertsXml = v4;
                var v5 = AllowedRoleDelimitedList; v5.Clean = value; AllowedRoleDelimitedList = v5;
                var v6 = AllowedRoles; v6.Clean = value; AllowedRoles = v6;
                var v7 = AllowedRolesXml; v7.Clean = value; AllowedRolesXml = v7;
                var v8 = ArchiveDateUtc; v8.Clean = value; ArchiveDateUtc = v8;
                var v9 = ArchivedBy; v9.Clean = value; ArchivedBy = v9;
                var v10 = ClosingDocumentIndicator; v10.Clean = value; ClosingDocumentIndicator = v10;
                var v11 = CommentList; v11.Clean = value; CommentList = v11;
                var v12 = CommentListXml; v12.Clean = value; CommentListXml = v12;
                var v13 = Comments; v13.Clean = value; Comments = v13;
                var v14 = Company; v14.Clean = value; Company = v14;
                var v15 = Conditions; v15.Clean = value; Conditions = v15;
                var v16 = ConditionsXml; v16.Clean = value; ConditionsXml = v16;
                var v17 = DateAddedUtc; v17.Clean = value; DateAddedUtc = v17;
                var v18 = DateExpected; v18.Clean = value; DateExpected = v18;
                var v19 = DateExpires; v19.Clean = value; DateExpires = v19;
                var v20 = DateReceived; v20.Clean = value; DateReceived = v20;
                var v21 = DateRequested; v21.Clean = value; DateRequested = v21;
                var v22 = DateRerequested; v22.Clean = value; DateRerequested = v22;
                var v23 = DateUtc; v23.Clean = value; DateUtc = v23;
                var v24 = DaysDue; v24.Clean = value; DaysDue = v24;
                var v25 = DaysTillExpire; v25.Clean = value; DaysTillExpire = v25;
                var v26 = DocumentDateTimeType; v26.Clean = value; DocumentDateTimeType = v26;
                var v27 = EDisclosureIndicator; v27.Clean = value; EDisclosureIndicator = v27;
                var v28 = EPassSignature; v28.Clean = value; EPassSignature = v28;
                var v29 = Expected; v29.Clean = value; Expected = v29;
                var v30 = Expires; v30.Clean = value; Expires = v30;
                var v31 = FileAttachmentReferences; v31.Clean = value; FileAttachmentReferences = v31;
                var v32 = FileAttachmentsMigrated; v32.Clean = value; FileAttachmentsMigrated = v32;
                var v33 = FileAttachmentsXml; v33.Clean = value; FileAttachmentsXml = v33;
                var v34 = Guid; v34.Clean = value; Guid = v34;
                var v35 = Id; v35.Clean = value; Id = v35;
                var v36 = IsEPassIndicator; v36.Clean = value; IsEPassIndicator = v36;
                var v37 = IsExpired; v37.Clean = value; IsExpired = v37;
                var v38 = IsPastDue; v38.Clean = value; IsPastDue = v38;
                var v39 = IsSystemSpecificIndicator; v39.Clean = value; IsSystemSpecificIndicator = v39;
                var v40 = IsThirdPartyDocIndicator; v40.Clean = value; IsThirdPartyDocIndicator = v40;
                var v41 = IsTPOWebcenterPortalIndicator; v41.Clean = value; IsTPOWebcenterPortalIndicator = v41;
                var v42 = IsWebCenterIndicator; v42.Clean = value; IsWebCenterIndicator = v42;
                var v43 = LogRecordIndex; v43.Clean = value; LogRecordIndex = v43;
                var v44 = OrderDateUtc; v44.Clean = value; OrderDateUtc = v44;
                var v45 = PairId; v45.Clean = value; PairId = v45;
                var v46 = PreClosingDocumentIndicator; v46.Clean = value; PreClosingDocumentIndicator = v46;
                var v47 = Received; v47.Clean = value; Received = v47;
                var v48 = ReceiveDateUtc; v48.Clean = value; ReceiveDateUtc = v48;
                var v49 = ReceivedBy; v49.Clean = value; ReceivedBy = v49;
                var v50 = ReorderDateUtc; v50.Clean = value; ReorderDateUtc = v50;
                var v51 = Requested; v51.Clean = value; Requested = v51;
                var v52 = RequestedBy; v52.Clean = value; RequestedBy = v52;
                var v53 = RequestedFrom; v53.Clean = value; RequestedFrom = v53;
                var v54 = Rerequested; v54.Clean = value; Rerequested = v54;
                var v55 = RerequestedBy; v55.Clean = value; RerequestedBy = v55;
                var v56 = Reviewed; v56.Clean = value; Reviewed = v56;
                var v57 = ReviewedBy; v57.Clean = value; ReviewedBy = v57;
                var v58 = ReviewedDateUtc; v58.Clean = value; ReviewedDateUtc = v58;
                var v59 = ShippingReady; v59.Clean = value; ShippingReady = v59;
                var v60 = ShippingReadyBy; v60.Clean = value; ShippingReadyBy = v60;
                var v61 = ShippingReadyDateUtc; v61.Clean = value; ShippingReadyDateUtc = v61;
                var v62 = Stage; v62.Clean = value; Stage = v62;
                var v63 = Status; v63.Clean = value; Status = v63;
                var v64 = SystemId; v64.Clean = value; SystemId = v64;
                var v65 = Title; v65.Clean = value; Title = v65;
                var v66 = UnderwritingReady; v66.Clean = value; UnderwritingReady = v66;
                var v67 = UnderwritingReadyBy; v67.Clean = value; UnderwritingReadyBy = v67;
                var v68 = UnderwritingReadyDateUtc; v68.Clean = value; UnderwritingReadyDateUtc = v68;
                _settingClean = 0;
            }
        }
    }
}