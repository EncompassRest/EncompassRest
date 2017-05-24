using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class PrintLog
    {
        public Value<string> Action { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAction() => !Action.Clean;
        public Value<List<LogAlert>> Alerts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlerts() => !Alerts.Clean;
        public Value<List<LogComment>> CommentList { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentList() => !CommentList.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<DateTime?> DateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateUtc() => !DateUtc.Clean;
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
        public Value<string> PrintedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintedBy() => !PrintedBy.Clean;
        public Value<string> PrintedByFullName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintedByFullName() => !PrintedByFullName.Clean;
        public Value<List<PrintForm>> PrintForms { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintForms() => !PrintForms.Clean;
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
                var clean = Action.Clean
                    && Alerts.Clean
                    && CommentList.Clean
                    && Comments.Clean
                    && DateUtc.Clean
                    && FileAttachmentsMigrated.Clean
                    && Guid.Clean
                    && Id.Clean
                    && IsSystemSpecificIndicator.Clean
                    && LogRecordIndex.Clean
                    && PrintedBy.Clean
                    && PrintedByFullName.Clean
                    && PrintForms.Clean
                    && SystemId.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Action; v0.Clean = value; Action = v0;
                var v1 = Alerts; v1.Clean = value; Alerts = v1;
                var v2 = CommentList; v2.Clean = value; CommentList = v2;
                var v3 = Comments; v3.Clean = value; Comments = v3;
                var v4 = DateUtc; v4.Clean = value; DateUtc = v4;
                var v5 = FileAttachmentsMigrated; v5.Clean = value; FileAttachmentsMigrated = v5;
                var v6 = Guid; v6.Clean = value; Guid = v6;
                var v7 = Id; v7.Clean = value; Id = v7;
                var v8 = IsSystemSpecificIndicator; v8.Clean = value; IsSystemSpecificIndicator = v8;
                var v9 = LogRecordIndex; v9.Clean = value; LogRecordIndex = v9;
                var v10 = PrintedBy; v10.Clean = value; PrintedBy = v10;
                var v11 = PrintedByFullName; v11.Clean = value; PrintedByFullName = v11;
                var v12 = PrintForms; v12.Clean = value; PrintForms = v12;
                var v13 = SystemId; v13.Clean = value; SystemId = v13;
                _settingClean = 0;
            }
        }
    }
}