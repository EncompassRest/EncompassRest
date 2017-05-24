using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class MilestoneTaskLog
    {
        public Value<DateTime?> AddDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddDate() => !AddDate.Clean;
        public Value<string> AddedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddedBy() => !AddedBy.Clean;
        public Value<string> AddedByUserId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddedByUserId() => !AddedByUserId.Clean;
        public Value<List<LogAlert>> Alerts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlerts() => !Alerts.Clean;
        public Value<string> AlertsXml { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlertsXml() => !AlertsXml.Clean;
        public Value<List<LogComment>> CommentList { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentList() => !CommentList.Clean;
        public Value<string> CommentListXml { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentListXml() => !CommentListXml.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<bool?> Completed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompleted() => !Completed.Clean;
        public Value<string> CompletedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompletedBy() => !CompletedBy.Clean;
        public Value<string> CompletedByUserId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompletedByUserId() => !CompletedByUserId.Clean;
        public Value<DateTime?> CompletedDateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompletedDateUtc() => !CompletedDateUtc.Clean;
        public Value<int?> ContactCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactCount() => !ContactCount.Clean;
        public Value<List<MilestoneTaskContact>> Contacts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContacts() => !Contacts.Clean;
        public Value<string> ContactsXml { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactsXml() => !ContactsXml.Clean;
        public Value<DateTime?> DateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateUtc() => !DateUtc.Clean;
        public Value<int?> DaysToComplete { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDaysToComplete() => !DaysToComplete.Clean;
        public Value<int?> DaysToCompleteFromSetting { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDaysToCompleteFromSetting() => !DaysToCompleteFromSetting.Clean;
        public Value<DateTime?> ExpectedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpectedDate() => !ExpectedDate.Clean;
        public Value<bool?> FileAttachmentsMigrated { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileAttachmentsMigrated() => !FileAttachmentsMigrated.Clean;
        public Value<string> Guid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuid() => !Guid.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IsRequiredIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsRequiredIndicator() => !IsRequiredIndicator.Clean;
        public Value<bool?> IsSystemSpecificIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsSystemSpecificIndicator() => !IsSystemSpecificIndicator.Clean;
        public Value<int?> LogRecordIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLogRecordIndex() => !LogRecordIndex.Clean;
        public Value<DateTime?> MilestoneTaskLogDateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneTaskLogDateUtc() => !MilestoneTaskLogDateUtc.Clean;
        public Value<string> Priority { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriority() => !Priority.Clean;
        public Value<string> Stage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStage() => !Stage.Clean;
        public Value<string> SystemId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSystemId() => !SystemId.Clean;
        public Value<string> TaskDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaskDescription() => !TaskDescription.Clean;
        public Value<string> TaskGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaskGuid() => !TaskGuid.Clean;
        public Value<string> TaskName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaskName() => !TaskName.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AddDate.Clean
                    && AddedBy.Clean
                    && AddedByUserId.Clean
                    && Alerts.Clean
                    && AlertsXml.Clean
                    && CommentList.Clean
                    && CommentListXml.Clean
                    && Comments.Clean
                    && Completed.Clean
                    && CompletedBy.Clean
                    && CompletedByUserId.Clean
                    && CompletedDateUtc.Clean
                    && ContactCount.Clean
                    && Contacts.Clean
                    && ContactsXml.Clean
                    && DateUtc.Clean
                    && DaysToComplete.Clean
                    && DaysToCompleteFromSetting.Clean
                    && ExpectedDate.Clean
                    && FileAttachmentsMigrated.Clean
                    && Guid.Clean
                    && Id.Clean
                    && IsRequiredIndicator.Clean
                    && IsSystemSpecificIndicator.Clean
                    && LogRecordIndex.Clean
                    && MilestoneTaskLogDateUtc.Clean
                    && Priority.Clean
                    && Stage.Clean
                    && SystemId.Clean
                    && TaskDescription.Clean
                    && TaskGuid.Clean
                    && TaskName.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AddDate; v0.Clean = value; AddDate = v0;
                var v1 = AddedBy; v1.Clean = value; AddedBy = v1;
                var v2 = AddedByUserId; v2.Clean = value; AddedByUserId = v2;
                var v3 = Alerts; v3.Clean = value; Alerts = v3;
                var v4 = AlertsXml; v4.Clean = value; AlertsXml = v4;
                var v5 = CommentList; v5.Clean = value; CommentList = v5;
                var v6 = CommentListXml; v6.Clean = value; CommentListXml = v6;
                var v7 = Comments; v7.Clean = value; Comments = v7;
                var v8 = Completed; v8.Clean = value; Completed = v8;
                var v9 = CompletedBy; v9.Clean = value; CompletedBy = v9;
                var v10 = CompletedByUserId; v10.Clean = value; CompletedByUserId = v10;
                var v11 = CompletedDateUtc; v11.Clean = value; CompletedDateUtc = v11;
                var v12 = ContactCount; v12.Clean = value; ContactCount = v12;
                var v13 = Contacts; v13.Clean = value; Contacts = v13;
                var v14 = ContactsXml; v14.Clean = value; ContactsXml = v14;
                var v15 = DateUtc; v15.Clean = value; DateUtc = v15;
                var v16 = DaysToComplete; v16.Clean = value; DaysToComplete = v16;
                var v17 = DaysToCompleteFromSetting; v17.Clean = value; DaysToCompleteFromSetting = v17;
                var v18 = ExpectedDate; v18.Clean = value; ExpectedDate = v18;
                var v19 = FileAttachmentsMigrated; v19.Clean = value; FileAttachmentsMigrated = v19;
                var v20 = Guid; v20.Clean = value; Guid = v20;
                var v21 = Id; v21.Clean = value; Id = v21;
                var v22 = IsRequiredIndicator; v22.Clean = value; IsRequiredIndicator = v22;
                var v23 = IsSystemSpecificIndicator; v23.Clean = value; IsSystemSpecificIndicator = v23;
                var v24 = LogRecordIndex; v24.Clean = value; LogRecordIndex = v24;
                var v25 = MilestoneTaskLogDateUtc; v25.Clean = value; MilestoneTaskLogDateUtc = v25;
                var v26 = Priority; v26.Clean = value; Priority = v26;
                var v27 = Stage; v27.Clean = value; Stage = v27;
                var v28 = SystemId; v28.Clean = value; SystemId = v28;
                var v29 = TaskDescription; v29.Clean = value; TaskDescription = v29;
                var v30 = TaskGuid; v30.Clean = value; TaskGuid = v30;
                var v31 = TaskName; v31.Clean = value; TaskName = v31;
                _settingClean = 0;
            }
        }
    }
}