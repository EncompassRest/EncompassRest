using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class HtmlEmailLog
    {
        public Value<List<LogAlert>> Alerts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlerts() => !Alerts.Clean;
        public Value<string> Body { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBody() => !Body.Clean;
        public Value<List<LogComment>> CommentList { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentList() => !CommentList.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<string> Creator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreator() => !Creator.Clean;
        public Value<DateTime?> DateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateUtc() => !DateUtc.Clean;
        public Value<string> Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !Description.Clean;
        public Value<bool?> FileAttachmentsMigrated { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileAttachmentsMigrated() => !FileAttachmentsMigrated.Clean;
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
        public Value<string> Recipient { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecipient() => !Recipient.Clean;
        public Value<string> Sender { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSender() => !Sender.Clean;
        public Value<string> Subject { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubject() => !Subject.Clean;
        public Value<string> SystemId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSystemId() => !SystemId.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Alerts.Clean
                    && Body.Clean
                    && CommentList.Clean
                    && Comments.Clean
                    && Creator.Clean
                    && DateUtc.Clean
                    && Description.Clean
                    && FileAttachmentsMigrated.Clean
                    && Guid.Clean
                    && Id.Clean
                    && IsSystemSpecificIndicator.Clean
                    && LogRecordIndex.Clean
                    && Recipient.Clean
                    && Sender.Clean
                    && Subject.Clean
                    && SystemId.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Alerts; v0.Clean = value; Alerts = v0;
                var v1 = Body; v1.Clean = value; Body = v1;
                var v2 = CommentList; v2.Clean = value; CommentList = v2;
                var v3 = Comments; v3.Clean = value; Comments = v3;
                var v4 = Creator; v4.Clean = value; Creator = v4;
                var v5 = DateUtc; v5.Clean = value; DateUtc = v5;
                var v6 = Description; v6.Clean = value; Description = v6;
                var v7 = FileAttachmentsMigrated; v7.Clean = value; FileAttachmentsMigrated = v7;
                var v8 = Guid; v8.Clean = value; Guid = v8;
                var v9 = Id; v9.Clean = value; Id = v9;
                var v10 = IsSystemSpecificIndicator; v10.Clean = value; IsSystemSpecificIndicator = v10;
                var v11 = LogRecordIndex; v11.Clean = value; LogRecordIndex = v11;
                var v12 = Recipient; v12.Clean = value; Recipient = v12;
                var v13 = Sender; v13.Clean = value; Sender = v13;
                var v14 = Subject; v14.Clean = value; Subject = v14;
                var v15 = SystemId; v15.Clean = value; SystemId = v15;
                _settingClean = 0;
            }
        }
    }
}