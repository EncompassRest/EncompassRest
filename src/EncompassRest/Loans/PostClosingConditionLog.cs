using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class PostClosingConditionLog
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
        public Value<DateTime?> DateReceived { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateReceived() => !DateReceived.Clean;
        public Value<DateTime?> DateRequestedUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateRequestedUtc() => !DateRequestedUtc.Clean;
        public Value<DateTime?> DateRerequestedUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateRerequestedUtc() => !DateRerequestedUtc.Clean;
        public Value<DateTime?> DateSentUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateSentUtc() => !DateSentUtc.Clean;
        public Value<DateTime?> DateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateUtc() => !DateUtc.Clean;
        public Value<int?> DaysTillDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDaysTillDue() => !DaysTillDue.Clean;
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
        public Value<bool?> Received { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceived() => !Received.Clean;
        public Value<string> ReceivedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceivedBy() => !ReceivedBy.Clean;
        public Value<string> Recipient { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecipient() => !Recipient.Clean;
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
        public Value<bool?> Sent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSent() => !Sent.Clean;
        public Value<string> SentBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSentBy() => !SentBy.Clean;
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
                    && Cleared.Clean
                    && ClearedBy.Clean
                    && CommentList.Clean
                    && CommentListXml.Clean
                    && Comments.Clean
                    && DateAddedUtc.Clean
                    && DateClearedUtc.Clean
                    && DateExpected.Clean
                    && DateReceived.Clean
                    && DateRequestedUtc.Clean
                    && DateRerequestedUtc.Clean
                    && DateSentUtc.Clean
                    && DateUtc.Clean
                    && DaysTillDue.Clean
                    && Description.Clean
                    && Details.Clean
                    && Expected.Clean
                    && FileAttachmentsMigrated.Clean
                    && Guid.Clean
                    && Id.Clean
                    && IsPastDue.Clean
                    && IsSystemSpecificIndicator.Clean
                    && LogRecordIndex.Clean
                    && PairId.Clean
                    && Received.Clean
                    && ReceivedBy.Clean
                    && Recipient.Clean
                    && Requested.Clean
                    && RequestedBy.Clean
                    && RequestedFrom.Clean
                    && Rerequested.Clean
                    && RerequestedBy.Clean
                    && Sent.Clean
                    && SentBy.Clean
                    && Source.Clean
                    && Status.Clean
                    && StatusDescription.Clean
                    && SystemId.Clean
                    && Title.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AddedBy; v0.Clean = value; AddedBy = v0;
                var v1 = Alerts; v1.Clean = value; Alerts = v1;
                var v2 = AlertsXml; v2.Clean = value; AlertsXml = v2;
                var v3 = Cleared; v3.Clean = value; Cleared = v3;
                var v4 = ClearedBy; v4.Clean = value; ClearedBy = v4;
                var v5 = CommentList; v5.Clean = value; CommentList = v5;
                var v6 = CommentListXml; v6.Clean = value; CommentListXml = v6;
                var v7 = Comments; v7.Clean = value; Comments = v7;
                var v8 = DateAddedUtc; v8.Clean = value; DateAddedUtc = v8;
                var v9 = DateClearedUtc; v9.Clean = value; DateClearedUtc = v9;
                var v10 = DateExpected; v10.Clean = value; DateExpected = v10;
                var v11 = DateReceived; v11.Clean = value; DateReceived = v11;
                var v12 = DateRequestedUtc; v12.Clean = value; DateRequestedUtc = v12;
                var v13 = DateRerequestedUtc; v13.Clean = value; DateRerequestedUtc = v13;
                var v14 = DateSentUtc; v14.Clean = value; DateSentUtc = v14;
                var v15 = DateUtc; v15.Clean = value; DateUtc = v15;
                var v16 = DaysTillDue; v16.Clean = value; DaysTillDue = v16;
                var v17 = Description; v17.Clean = value; Description = v17;
                var v18 = Details; v18.Clean = value; Details = v18;
                var v19 = Expected; v19.Clean = value; Expected = v19;
                var v20 = FileAttachmentsMigrated; v20.Clean = value; FileAttachmentsMigrated = v20;
                var v21 = Guid; v21.Clean = value; Guid = v21;
                var v22 = Id; v22.Clean = value; Id = v22;
                var v23 = IsPastDue; v23.Clean = value; IsPastDue = v23;
                var v24 = IsSystemSpecificIndicator; v24.Clean = value; IsSystemSpecificIndicator = v24;
                var v25 = LogRecordIndex; v25.Clean = value; LogRecordIndex = v25;
                var v26 = PairId; v26.Clean = value; PairId = v26;
                var v27 = Received; v27.Clean = value; Received = v27;
                var v28 = ReceivedBy; v28.Clean = value; ReceivedBy = v28;
                var v29 = Recipient; v29.Clean = value; Recipient = v29;
                var v30 = Requested; v30.Clean = value; Requested = v30;
                var v31 = RequestedBy; v31.Clean = value; RequestedBy = v31;
                var v32 = RequestedFrom; v32.Clean = value; RequestedFrom = v32;
                var v33 = Rerequested; v33.Clean = value; Rerequested = v33;
                var v34 = RerequestedBy; v34.Clean = value; RerequestedBy = v34;
                var v35 = Sent; v35.Clean = value; Sent = v35;
                var v36 = SentBy; v36.Clean = value; SentBy = v36;
                var v37 = Source; v37.Clean = value; Source = v37;
                var v38 = Status; v38.Clean = value; Status = v38;
                var v39 = StatusDescription; v39.Clean = value; StatusDescription = v39;
                var v40 = SystemId; v40.Clean = value; SystemId = v40;
                var v41 = Title; v41.Clean = value; Title = v41;
                _settingClean = 0;
            }
        }
    }
}