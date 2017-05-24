using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class PreliminaryConditionLog
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
        public Value<string> Category { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCategory() => !Category.Clean;
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
        public Value<DateTime?> DateExpected { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateExpected() => !DateExpected.Clean;
        public Value<DateTime?> DateFulfilled { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateFulfilled() => !DateFulfilled.Clean;
        public Value<DateTime?> DateReceived { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateReceived() => !DateReceived.Clean;
        public Value<DateTime?> DateRequestedUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateRequestedUtc() => !DateRequestedUtc.Clean;
        public Value<DateTime?> DateRerequestedUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateRerequestedUtc() => !DateRerequestedUtc.Clean;
        public Value<DateTime?> DateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateUtc() => !DateUtc.Clean;
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
        public Value<bool?> UnderwriterAccessIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwriterAccessIndicator() => !UnderwriterAccessIndicator.Clean;
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
                    && Category.Clean
                    && CommentList.Clean
                    && CommentListXml.Clean
                    && Comments.Clean
                    && DateAddedUtc.Clean
                    && DateExpected.Clean
                    && DateFulfilled.Clean
                    && DateReceived.Clean
                    && DateRequestedUtc.Clean
                    && DateRerequestedUtc.Clean
                    && DateUtc.Clean
                    && Description.Clean
                    && Details.Clean
                    && Expected.Clean
                    && FileAttachmentsMigrated.Clean
                    && Fulfilled.Clean
                    && FulfilledBy.Clean
                    && Guid.Clean
                    && Id.Clean
                    && IsPastDue.Clean
                    && IsSystemSpecificIndicator.Clean
                    && LogRecordIndex.Clean
                    && PairId.Clean
                    && PriorTo.Clean
                    && Received.Clean
                    && ReceivedBy.Clean
                    && Requested.Clean
                    && RequestedBy.Clean
                    && Rerequested.Clean
                    && RerequestedBy.Clean
                    && Source.Clean
                    && Status.Clean
                    && StatusDescription.Clean
                    && SystemId.Clean
                    && Title.Clean
                    && UnderwriterAccessIndicator.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AddedBy; v0.Clean = value; AddedBy = v0;
                var v1 = Alerts; v1.Clean = value; Alerts = v1;
                var v2 = AlertsXml; v2.Clean = value; AlertsXml = v2;
                var v3 = Category; v3.Clean = value; Category = v3;
                var v4 = CommentList; v4.Clean = value; CommentList = v4;
                var v5 = CommentListXml; v5.Clean = value; CommentListXml = v5;
                var v6 = Comments; v6.Clean = value; Comments = v6;
                var v7 = DateAddedUtc; v7.Clean = value; DateAddedUtc = v7;
                var v8 = DateExpected; v8.Clean = value; DateExpected = v8;
                var v9 = DateFulfilled; v9.Clean = value; DateFulfilled = v9;
                var v10 = DateReceived; v10.Clean = value; DateReceived = v10;
                var v11 = DateRequestedUtc; v11.Clean = value; DateRequestedUtc = v11;
                var v12 = DateRerequestedUtc; v12.Clean = value; DateRerequestedUtc = v12;
                var v13 = DateUtc; v13.Clean = value; DateUtc = v13;
                var v14 = Description; v14.Clean = value; Description = v14;
                var v15 = Details; v15.Clean = value; Details = v15;
                var v16 = Expected; v16.Clean = value; Expected = v16;
                var v17 = FileAttachmentsMigrated; v17.Clean = value; FileAttachmentsMigrated = v17;
                var v18 = Fulfilled; v18.Clean = value; Fulfilled = v18;
                var v19 = FulfilledBy; v19.Clean = value; FulfilledBy = v19;
                var v20 = Guid; v20.Clean = value; Guid = v20;
                var v21 = Id; v21.Clean = value; Id = v21;
                var v22 = IsPastDue; v22.Clean = value; IsPastDue = v22;
                var v23 = IsSystemSpecificIndicator; v23.Clean = value; IsSystemSpecificIndicator = v23;
                var v24 = LogRecordIndex; v24.Clean = value; LogRecordIndex = v24;
                var v25 = PairId; v25.Clean = value; PairId = v25;
                var v26 = PriorTo; v26.Clean = value; PriorTo = v26;
                var v27 = Received; v27.Clean = value; Received = v27;
                var v28 = ReceivedBy; v28.Clean = value; ReceivedBy = v28;
                var v29 = Requested; v29.Clean = value; Requested = v29;
                var v30 = RequestedBy; v30.Clean = value; RequestedBy = v30;
                var v31 = Rerequested; v31.Clean = value; Rerequested = v31;
                var v32 = RerequestedBy; v32.Clean = value; RerequestedBy = v32;
                var v33 = Source; v33.Clean = value; Source = v33;
                var v34 = Status; v34.Clean = value; Status = v34;
                var v35 = StatusDescription; v35.Clean = value; StatusDescription = v35;
                var v36 = SystemId; v36.Clean = value; SystemId = v36;
                var v37 = Title; v37.Clean = value; Title = v37;
                var v38 = UnderwriterAccessIndicator; v38.Clean = value; UnderwriterAccessIndicator = v38;
                _settingClean = 0;
            }
        }
    }
}