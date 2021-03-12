using System;

namespace EncompassApi.Loans
{
    /// <summary>
    /// MilestoneHistoryLog
    /// </summary>
    public sealed partial class MilestoneHistoryLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _addedByUserId;
        private DirtyValue<string?>? _changeReason;
        private DirtyValue<DateTime?>? _dateAddedUtc;
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _milestoneTemplate;
        private DirtyValue<string?>? _recordXML;

        /// <summary>
        /// MilestoneHistoryLog AddedByUserId
        /// </summary>
        public string? AddedByUserId { get => _addedByUserId; set => SetField(ref _addedByUserId, value); }

        /// <summary>
        /// MilestoneHistoryLog ChangeReason
        /// </summary>
        public string? ChangeReason { get => _changeReason; set => SetField(ref _changeReason, value); }

        /// <summary>
        /// MilestoneHistoryLog DateAddedUtc
        /// </summary>
        public DateTime? DateAddedUtc { get => _dateAddedUtc; set => SetField(ref _dateAddedUtc, value); }

        /// <summary>
        /// MilestoneHistoryLog Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// MilestoneHistoryLog MilestoneTemplate
        /// </summary>
        public string? MilestoneTemplate { get => _milestoneTemplate; set => SetField(ref _milestoneTemplate, value); }

        /// <summary>
        /// MilestoneHistoryLog RecordXML
        /// </summary>
        public string? RecordXML { get => _recordXML; set => SetField(ref _recordXML, value); }
    }
}