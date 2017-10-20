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
        private ExtensionDataObject _extensionDataInternal;
        [JsonExtensionData]
        private ExtensionDataObject ExtensionDataInternal { get { return _extensionDataInternal ?? (_extensionDataInternal = new ExtensionDataObject()); } set { _extensionDataInternal = value; } }
        [JsonIgnore]
        public IDictionary<string, object> ExtensionData { get { return ExtensionDataInternal.InternalDictionary; } set { _extensionDataInternal = new ExtensionDataObject(value); } }
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
                    || _extensionDataInternal?.Dirty == true;
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
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}