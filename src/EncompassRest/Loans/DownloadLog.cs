using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class DownloadLog
    {
        public Value<List<LogAlert>> Alerts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlerts() => !Alerts.Clean;
        public Value<string> BarcodePage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBarcodePage() => !BarcodePage.Clean;
        public Value<List<LogComment>> CommentList { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentList() => !CommentList.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<string> DateReceived { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateReceived() => !DateReceived.Clean;
        public Value<DateTime?> DateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateUtc() => !DateUtc.Clean;
        public Value<string> DocumentId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocumentId() => !DocumentId.Clean;
        public Value<string> DownloadId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDownloadId() => !DownloadId.Clean;
        public Value<bool?> FileAttachmentsMigrated { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileAttachmentsMigrated() => !FileAttachmentsMigrated.Clean;
        public Value<string> FileSource { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileSource() => !FileSource.Clean;
        public Value<string> FileType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileType() => !FileType.Clean;
        public Value<string> Guid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuid() => !Guid.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IsSystemSpecificIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsSystemSpecificIndicator() => !IsSystemSpecificIndicator.Clean;
        public Value<int?> LogRecordIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLogRecordIndex() => !LogRecordIndex.Clean;
        public Value<string> ReceivedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceivedBy() => !ReceivedBy.Clean;
        public Value<string> Sender { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSender() => !Sender.Clean;
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
                var clean = Alerts.Clean
                    && BarcodePage.Clean
                    && CommentList.Clean
                    && Comments.Clean
                    && DateReceived.Clean
                    && DateUtc.Clean
                    && DocumentId.Clean
                    && DownloadId.Clean
                    && FileAttachmentsMigrated.Clean
                    && FileSource.Clean
                    && FileType.Clean
                    && Guid.Clean
                    && Id.Clean
                    && IsSystemSpecificIndicator.Clean
                    && LogRecordIndex.Clean
                    && ReceivedBy.Clean
                    && Sender.Clean
                    && SystemId.Clean
                    && Title.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Alerts; v0.Clean = value; Alerts = v0;
                var v1 = BarcodePage; v1.Clean = value; BarcodePage = v1;
                var v2 = CommentList; v2.Clean = value; CommentList = v2;
                var v3 = Comments; v3.Clean = value; Comments = v3;
                var v4 = DateReceived; v4.Clean = value; DateReceived = v4;
                var v5 = DateUtc; v5.Clean = value; DateUtc = v5;
                var v6 = DocumentId; v6.Clean = value; DocumentId = v6;
                var v7 = DownloadId; v7.Clean = value; DownloadId = v7;
                var v8 = FileAttachmentsMigrated; v8.Clean = value; FileAttachmentsMigrated = v8;
                var v9 = FileSource; v9.Clean = value; FileSource = v9;
                var v10 = FileType; v10.Clean = value; FileType = v10;
                var v11 = Guid; v11.Clean = value; Guid = v11;
                var v12 = Id; v12.Clean = value; Id = v12;
                var v13 = IsSystemSpecificIndicator; v13.Clean = value; IsSystemSpecificIndicator = v13;
                var v14 = LogRecordIndex; v14.Clean = value; LogRecordIndex = v14;
                var v15 = ReceivedBy; v15.Clean = value; ReceivedBy = v15;
                var v16 = Sender; v16.Clean = value; Sender = v16;
                var v17 = SystemId; v17.Clean = value; SystemId = v17;
                var v18 = Title; v18.Clean = value; Title = v18;
                _settingClean = 0;
            }
        }
    }
}