using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class MilestoneTemplateLog : IClean
    {
        private Value<int?> _elliLogRecordId;
        public int? ElliLogRecordId { get { return _elliLogRecordId; } set { _elliLogRecordId = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isTemplateDatesLocked;
        public bool? IsTemplateDatesLocked { get { return _isTemplateDatesLocked; } set { _isTemplateDatesLocked = value; } }
        private Value<bool?> _isTemplateLocked;
        public bool? IsTemplateLocked { get { return _isTemplateLocked; } set { _isTemplateLocked = value; } }
        private Value<string> _milestoneTemplateID;
        public string MilestoneTemplateID { get { return _milestoneTemplateID; } set { _milestoneTemplateID = value; } }
        private Value<string> _milestoneTemplateName;
        public string MilestoneTemplateName { get { return _milestoneTemplateName; } set { _milestoneTemplateName = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _elliLogRecordId.Clean
                    && _id.Clean
                    && _isTemplateDatesLocked.Clean
                    && _isTemplateLocked.Clean
                    && _milestoneTemplateID.Clean
                    && _milestoneTemplateName.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var elliLogRecordId = _elliLogRecordId; elliLogRecordId.Clean = value; _elliLogRecordId = elliLogRecordId;
                var id = _id; id.Clean = value; _id = id;
                var isTemplateDatesLocked = _isTemplateDatesLocked; isTemplateDatesLocked.Clean = value; _isTemplateDatesLocked = isTemplateDatesLocked;
                var isTemplateLocked = _isTemplateLocked; isTemplateLocked.Clean = value; _isTemplateLocked = isTemplateLocked;
                var milestoneTemplateID = _milestoneTemplateID; milestoneTemplateID.Clean = value; _milestoneTemplateID = milestoneTemplateID;
                var milestoneTemplateName = _milestoneTemplateName; milestoneTemplateName.Clean = value; _milestoneTemplateName = milestoneTemplateName;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public MilestoneTemplateLog()
        {
            Clean = true;
        }
    }
}