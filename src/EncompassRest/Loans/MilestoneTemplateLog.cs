#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class MilestoneTemplateLog : ExtensibleObject
    {
        private DirtyValue<int?> _elliLogRecordId;
        public int? ElliLogRecordId { get => _elliLogRecordId; set => _elliLogRecordId = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isTemplateDatesLocked;
        public bool? IsTemplateDatesLocked { get => _isTemplateDatesLocked; set => _isTemplateDatesLocked = value; }
        private DirtyValue<bool?> _isTemplateLocked;
        public bool? IsTemplateLocked { get => _isTemplateLocked; set => _isTemplateLocked = value; }
        private DirtyValue<string> _milestoneTemplateID;
        public string MilestoneTemplateID { get => _milestoneTemplateID; set => _milestoneTemplateID = value; }
        private DirtyValue<string> _milestoneTemplateName;
        public string MilestoneTemplateName { get => _milestoneTemplateName; set => _milestoneTemplateName = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _elliLogRecordId.Dirty
                    || _id.Dirty
                    || _isTemplateDatesLocked.Dirty
                    || _isTemplateLocked.Dirty
                    || _milestoneTemplateID.Dirty
                    || _milestoneTemplateName.Dirty;
            }
            set
            {
                _elliLogRecordId.Dirty = value;
                _id.Dirty = value;
                _isTemplateDatesLocked.Dirty = value;
                _isTemplateLocked.Dirty = value;
                _milestoneTemplateID.Dirty = value;
                _milestoneTemplateName.Dirty = value;
            }
        }
    }
}