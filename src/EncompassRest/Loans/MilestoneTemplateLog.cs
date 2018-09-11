using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// MilestoneTemplateLog
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class MilestoneTemplateLog : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?> _elliLogRecordId;
        /// <summary>
        /// MilestoneTemplateLog ElliLogRecordId
        /// </summary>
        public int? ElliLogRecordId { get => _elliLogRecordId; set => SetField(ref _elliLogRecordId, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// MilestoneTemplateLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _isTemplateDatesLocked;
        /// <summary>
        /// Milestone Dates Mode [3670]
        /// </summary>
        [LoanFieldProperty(Description = "Milestone Dates Mode")]
        public bool? IsTemplateDatesLocked { get => _isTemplateDatesLocked; set => SetField(ref _isTemplateDatesLocked, value); }
        private DirtyValue<bool?> _isTemplateLocked;
        /// <summary>
        /// Milestones List Lock [3669]
        /// </summary>
        [LoanFieldProperty(Description = "Milestones List Lock")]
        public bool? IsTemplateLocked { get => _isTemplateLocked; set => SetField(ref _isTemplateLocked, value); }
        private DirtyValue<string> _milestoneTemplateID;
        /// <summary>
        /// MilestoneTemplateLog MilestoneTemplateID
        /// </summary>
        public string MilestoneTemplateID { get => _milestoneTemplateID; set => SetField(ref _milestoneTemplateID, value); }
        private DirtyValue<string> _milestoneTemplateName;
        /// <summary>
        /// MilestoneTemplateLog MilestoneTemplateName
        /// </summary>
        public string MilestoneTemplateName { get => _milestoneTemplateName; set => SetField(ref _milestoneTemplateName, value); }
    }
}