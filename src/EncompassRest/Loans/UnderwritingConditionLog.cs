using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class UnderwritingConditionLog
    {
        public Value<string> AddedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddedBy() => !AddedBy.Clean;
        public Value<List<LogAlert>> Alerts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlerts() => !Alerts.Clean;
        public Value<string> AlertsXml { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlertsXml() => !AlertsXml.Clean;
        public Value<bool?> AllowToClearIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllowToClearIndicator() => !AllowToClearIndicator.Clean;
        public Value<string> Category { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCategory() => !Category.Clean;
        public Value<bool?> Cleared { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCleared() => !Cleared.Clean;
        public Value<string> ClearedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClearedBy() => !ClearedBy.Clean;
        public Value<List<LogComment>> CommentList { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentList() => !CommentList.Clean;
        public Value<string> CommentListXml { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentListXml() => !CommentListXml.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<DateTime?> DateAddedUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateAddedUtc() => !DateAddedUtc.Clean;
        public Value<DateTime?> DateClearedUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateClearedUtc() => !DateClearedUtc.Clean;
        public Value<DateTime?> DateExpected { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateExpected() => !DateExpected.Clean;
        public Value<DateTime?> DateExpiredUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateExpiredUtc() => !DateExpiredUtc.Clean;
        public Value<DateTime?> DateFulfilledUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateFulfilledUtc() => !DateFulfilledUtc.Clean;
        public Value<DateTime?> DateReceived { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateReceived() => !DateReceived.Clean;
        public Value<DateTime?> DateReceivedUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateReceivedUtc() => !DateReceivedUtc.Clean;
        public Value<DateTime?> DateRejectedUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateRejectedUtc() => !DateRejectedUtc.Clean;
        public Value<DateTime?> DateRequestedUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateRequestedUtc() => !DateRequestedUtc.Clean;
        public Value<DateTime?> DateRerequestedUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateRerequestedUtc() => !DateRerequestedUtc.Clean;
        public Value<DateTime?> DateReviewedUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateReviewedUtc() => !DateReviewedUtc.Clean;
        public Value<DateTime?> DateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateUtc() => !DateUtc.Clean;
        public Value<DateTime?> DateWaivedUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateWaivedUtc() => !DateWaivedUtc.Clean;
        public Value<string> Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !Description.Clean;
        public Value<string> Details { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDetails() => !Details.Clean;
        public Value<bool?> Expected { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpected() => !Expected.Clean;
        public Value<bool?> FileAttachmentsMigrated { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileAttachmentsMigrated() => !FileAttachmentsMigrated.Clean;
        public Value<int?> ForRoleId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeForRoleId() => !ForRoleId.Clean;
        public Value<bool?> Fulfilled { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFulfilled() => !Fulfilled.Clean;
        public Value<string> FulfilledBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFulfilledBy() => !FulfilledBy.Clean;
        public Value<string> Guid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuid() => !Guid.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IsExternalIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsExternalIndicator() => !IsExternalIndicator.Clean;
        public Value<bool?> IsInternalIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsInternalIndicator() => !IsInternalIndicator.Clean;
        public Value<bool?> IsPastDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsPastDue() => !IsPastDue.Clean;
        public Value<bool?> IsSystemSpecificIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsSystemSpecificIndicator() => !IsSystemSpecificIndicator.Clean;
        public Value<int?> LogRecordIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLogRecordIndex() => !LogRecordIndex.Clean;
        public Value<string> PairId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePairId() => !PairId.Clean;
        public Value<string> PriorTo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriorTo() => !PriorTo.Clean;
        public Value<bool?> Received { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceived() => !Received.Clean;
        public Value<string> ReceivedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceivedBy() => !ReceivedBy.Clean;
        public Value<bool?> Rejected { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRejected() => !Rejected.Clean;
        public Value<string> RejectedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRejectedBy() => !RejectedBy.Clean;
        public Value<bool?> Requested { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequested() => !Requested.Clean;
        public Value<string> RequestedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestedBy() => !RequestedBy.Clean;
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
        public Value<string> Source { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSource() => !Source.Clean;
        public Value<string> Status { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStatus() => !Status.Clean;
        public Value<string> StatusDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStatusDescription() => !StatusDescription.Clean;
        public Value<string> SystemId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSystemId() => !SystemId.Clean;
        public Value<string> Title { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle() => !Title.Clean;
        public Value<bool?> Waived { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWaived() => !Waived.Clean;
        public Value<string> WaivedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWaivedBy() => !WaivedBy.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AddedBy.Clean
                    && Alerts.Clean
                    && AlertsXml.Clean
                    && AllowToClearIndicator.Clean
                    && Category.Clean
                    && Cleared.Clean
                    && ClearedBy.Clean
                    && CommentList.Clean
                    && CommentListXml.Clean
                    && Comments.Clean
                    && DateAddedUtc.Clean
                    && DateClearedUtc.Clean
                    && DateExpected.Clean
                    && DateExpiredUtc.Clean
                    && DateFulfilledUtc.Clean
                    && DateReceived.Clean
                    && DateReceivedUtc.Clean
                    && DateRejectedUtc.Clean
                    && DateRequestedUtc.Clean
                    && DateRerequestedUtc.Clean
                    && DateReviewedUtc.Clean
                    && DateUtc.Clean
                    && DateWaivedUtc.Clean
                    && Description.Clean
                    && Details.Clean
                    && Expected.Clean
                    && FileAttachmentsMigrated.Clean
                    && ForRoleId.Clean
                    && Fulfilled.Clean
                    && FulfilledBy.Clean
                    && Guid.Clean
                    && Id.Clean
                    && IsExternalIndicator.Clean
                    && IsInternalIndicator.Clean
                    && IsPastDue.Clean
                    && IsSystemSpecificIndicator.Clean
                    && LogRecordIndex.Clean
                    && PairId.Clean
                    && PriorTo.Clean
                    && Received.Clean
                    && ReceivedBy.Clean
                    && Rejected.Clean
                    && RejectedBy.Clean
                    && Requested.Clean
                    && RequestedBy.Clean
                    && Rerequested.Clean
                    && RerequestedBy.Clean
                    && Reviewed.Clean
                    && ReviewedBy.Clean
                    && Source.Clean
                    && Status.Clean
                    && StatusDescription.Clean
                    && SystemId.Clean
                    && Title.Clean
                    && Waived.Clean
                    && WaivedBy.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AddedBy; v0.Clean = value; AddedBy = v0;
                var v1 = Alerts; v1.Clean = value; Alerts = v1;
                var v2 = AlertsXml; v2.Clean = value; AlertsXml = v2;
                var v3 = AllowToClearIndicator; v3.Clean = value; AllowToClearIndicator = v3;
                var v4 = Category; v4.Clean = value; Category = v4;
                var v5 = Cleared; v5.Clean = value; Cleared = v5;
                var v6 = ClearedBy; v6.Clean = value; ClearedBy = v6;
                var v7 = CommentList; v7.Clean = value; CommentList = v7;
                var v8 = CommentListXml; v8.Clean = value; CommentListXml = v8;
                var v9 = Comments; v9.Clean = value; Comments = v9;
                var v10 = DateAddedUtc; v10.Clean = value; DateAddedUtc = v10;
                var v11 = DateClearedUtc; v11.Clean = value; DateClearedUtc = v11;
                var v12 = DateExpected; v12.Clean = value; DateExpected = v12;
                var v13 = DateExpiredUtc; v13.Clean = value; DateExpiredUtc = v13;
                var v14 = DateFulfilledUtc; v14.Clean = value; DateFulfilledUtc = v14;
                var v15 = DateReceived; v15.Clean = value; DateReceived = v15;
                var v16 = DateReceivedUtc; v16.Clean = value; DateReceivedUtc = v16;
                var v17 = DateRejectedUtc; v17.Clean = value; DateRejectedUtc = v17;
                var v18 = DateRequestedUtc; v18.Clean = value; DateRequestedUtc = v18;
                var v19 = DateRerequestedUtc; v19.Clean = value; DateRerequestedUtc = v19;
                var v20 = DateReviewedUtc; v20.Clean = value; DateReviewedUtc = v20;
                var v21 = DateUtc; v21.Clean = value; DateUtc = v21;
                var v22 = DateWaivedUtc; v22.Clean = value; DateWaivedUtc = v22;
                var v23 = Description; v23.Clean = value; Description = v23;
                var v24 = Details; v24.Clean = value; Details = v24;
                var v25 = Expected; v25.Clean = value; Expected = v25;
                var v26 = FileAttachmentsMigrated; v26.Clean = value; FileAttachmentsMigrated = v26;
                var v27 = ForRoleId; v27.Clean = value; ForRoleId = v27;
                var v28 = Fulfilled; v28.Clean = value; Fulfilled = v28;
                var v29 = FulfilledBy; v29.Clean = value; FulfilledBy = v29;
                var v30 = Guid; v30.Clean = value; Guid = v30;
                var v31 = Id; v31.Clean = value; Id = v31;
                var v32 = IsExternalIndicator; v32.Clean = value; IsExternalIndicator = v32;
                var v33 = IsInternalIndicator; v33.Clean = value; IsInternalIndicator = v33;
                var v34 = IsPastDue; v34.Clean = value; IsPastDue = v34;
                var v35 = IsSystemSpecificIndicator; v35.Clean = value; IsSystemSpecificIndicator = v35;
                var v36 = LogRecordIndex; v36.Clean = value; LogRecordIndex = v36;
                var v37 = PairId; v37.Clean = value; PairId = v37;
                var v38 = PriorTo; v38.Clean = value; PriorTo = v38;
                var v39 = Received; v39.Clean = value; Received = v39;
                var v40 = ReceivedBy; v40.Clean = value; ReceivedBy = v40;
                var v41 = Rejected; v41.Clean = value; Rejected = v41;
                var v42 = RejectedBy; v42.Clean = value; RejectedBy = v42;
                var v43 = Requested; v43.Clean = value; Requested = v43;
                var v44 = RequestedBy; v44.Clean = value; RequestedBy = v44;
                var v45 = Rerequested; v45.Clean = value; Rerequested = v45;
                var v46 = RerequestedBy; v46.Clean = value; RerequestedBy = v46;
                var v47 = Reviewed; v47.Clean = value; Reviewed = v47;
                var v48 = ReviewedBy; v48.Clean = value; ReviewedBy = v48;
                var v49 = Source; v49.Clean = value; Source = v49;
                var v50 = Status; v50.Clean = value; Status = v50;
                var v51 = StatusDescription; v51.Clean = value; StatusDescription = v51;
                var v52 = SystemId; v52.Clean = value; SystemId = v52;
                var v53 = Title; v53.Clean = value; Title = v53;
                var v54 = Waived; v54.Clean = value; Waived = v54;
                var v55 = WaivedBy; v55.Clean = value; WaivedBy = v55;
                _settingClean = 0;
            }
        }
    }
}