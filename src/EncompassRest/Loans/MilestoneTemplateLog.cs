using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class MilestoneTemplateLog : IDirty
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
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _elliLogRecordId.Dirty
                    || _id.Dirty
                    || _isTemplateDatesLocked.Dirty
                    || _isTemplateLocked.Dirty
                    || _milestoneTemplateID.Dirty
                    || _milestoneTemplateName.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _elliLogRecordId.Dirty = value;
                _id.Dirty = value;
                _isTemplateDatesLocked.Dirty = value;
                _isTemplateLocked.Dirty = value;
                _milestoneTemplateID.Dirty = value;
                _milestoneTemplateName.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}