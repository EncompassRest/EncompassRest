using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class MilestoneLog
    {
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
        public Value<int?> Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDays() => !Days.Clean;
        public Value<bool?> DoneIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDoneIndicator() => !DoneIndicator.Clean;
        public Value<int?> Duration { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDuration() => !Duration.Clean;
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
        public LoanAssociate LoanAssociate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAssociate() => LoanAssociate?.Clean == false;
        public Value<int?> LogRecordIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLogRecordIndex() => !LogRecordIndex.Clean;
        public Value<string> MilestoneIdString { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneIdString() => !MilestoneIdString.Clean;
        public Value<bool?> ReviewedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReviewedIndicator() => !ReviewedIndicator.Clean;
        public Value<string> RoleRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRoleRequired() => !RoleRequired.Clean;
        public Value<string> Stage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStage() => !Stage.Clean;
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
                    && CommentList.Clean
                    && Comments.Clean
                    && DateUtc.Clean
                    && Days.Clean
                    && DoneIndicator.Clean
                    && Duration.Clean
                    && FileAttachmentsMigrated.Clean
                    && Guid.Clean
                    && Id.Clean
                    && IsSystemSpecificIndicator.Clean
                    && LogRecordIndex.Clean
                    && MilestoneIdString.Clean
                    && ReviewedIndicator.Clean
                    && RoleRequired.Clean
                    && Stage.Clean
                    && SystemId.Clean
                    && LoanAssociate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Alerts; v0.Clean = value; Alerts = v0;
                var v1 = CommentList; v1.Clean = value; CommentList = v1;
                var v2 = Comments; v2.Clean = value; Comments = v2;
                var v3 = DateUtc; v3.Clean = value; DateUtc = v3;
                var v4 = Days; v4.Clean = value; Days = v4;
                var v5 = DoneIndicator; v5.Clean = value; DoneIndicator = v5;
                var v6 = Duration; v6.Clean = value; Duration = v6;
                var v7 = FileAttachmentsMigrated; v7.Clean = value; FileAttachmentsMigrated = v7;
                var v8 = Guid; v8.Clean = value; Guid = v8;
                var v9 = Id; v9.Clean = value; Id = v9;
                var v10 = IsSystemSpecificIndicator; v10.Clean = value; IsSystemSpecificIndicator = v10;
                var v11 = LogRecordIndex; v11.Clean = value; LogRecordIndex = v11;
                var v12 = MilestoneIdString; v12.Clean = value; MilestoneIdString = v12;
                var v13 = ReviewedIndicator; v13.Clean = value; ReviewedIndicator = v13;
                var v14 = RoleRequired; v14.Clean = value; RoleRequired = v14;
                var v15 = Stage; v15.Clean = value; Stage = v15;
                var v16 = SystemId; v16.Clean = value; SystemId = v16;
                if (LoanAssociate != null) LoanAssociate.Clean = value;
                _settingClean = 0;
            }
        }
    }
}