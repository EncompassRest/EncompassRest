using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class MilestoneTemplateLog : IDirty
    {
        private DirtyValue<int?> _elliLogRecordId;
        public int? ElliLogRecordId { get { return _elliLogRecordId; } set { _elliLogRecordId = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<bool?> _isTemplateDatesLocked;
        public bool? IsTemplateDatesLocked { get { return _isTemplateDatesLocked; } set { _isTemplateDatesLocked = value; } }
        private DirtyValue<bool?> _isTemplateLocked;
        public bool? IsTemplateLocked { get { return _isTemplateLocked; } set { _isTemplateLocked = value; } }
        private DirtyValue<string> _milestoneTemplateID;
        public string MilestoneTemplateID { get { return _milestoneTemplateID; } set { _milestoneTemplateID = value; } }
        private DirtyValue<string> _milestoneTemplateName;
        public string MilestoneTemplateName { get { return _milestoneTemplateName; } set { _milestoneTemplateName = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _elliLogRecordId.Dirty
                    || _id.Dirty
                    || _isTemplateDatesLocked.Dirty
                    || _isTemplateLocked.Dirty
                    || _milestoneTemplateID.Dirty
                    || _milestoneTemplateName.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _elliLogRecordId.Dirty = value;
                _id.Dirty = value;
                _isTemplateDatesLocked.Dirty = value;
                _isTemplateLocked.Dirty = value;
                _milestoneTemplateID.Dirty = value;
                _milestoneTemplateName.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}