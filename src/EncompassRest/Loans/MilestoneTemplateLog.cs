using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

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
                var v0 = _elliLogRecordId; v0.Clean = value; _elliLogRecordId = v0;
                var v1 = _id; v1.Clean = value; _id = v1;
                var v2 = _isTemplateDatesLocked; v2.Clean = value; _isTemplateDatesLocked = v2;
                var v3 = _isTemplateLocked; v3.Clean = value; _isTemplateLocked = v3;
                var v4 = _milestoneTemplateID; v4.Clean = value; _milestoneTemplateID = v4;
                var v5 = _milestoneTemplateName; v5.Clean = value; _milestoneTemplateName = v5;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}