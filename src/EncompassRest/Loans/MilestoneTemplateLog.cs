using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class MilestoneTemplateLog
    {
        public Value<int?> ElliLogRecordId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeElliLogRecordId() => !ElliLogRecordId.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IsTemplateDatesLocked { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsTemplateDatesLocked() => !IsTemplateDatesLocked.Clean;
        public Value<bool?> IsTemplateLocked { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsTemplateLocked() => !IsTemplateLocked.Clean;
        public Value<string> MilestoneTemplateID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneTemplateID() => !MilestoneTemplateID.Clean;
        public Value<string> MilestoneTemplateName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneTemplateName() => !MilestoneTemplateName.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = ElliLogRecordId.Clean
                    && Id.Clean
                    && IsTemplateDatesLocked.Clean
                    && IsTemplateLocked.Clean
                    && MilestoneTemplateID.Clean
                    && MilestoneTemplateName.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = ElliLogRecordId; v0.Clean = value; ElliLogRecordId = v0;
                var v1 = Id; v1.Clean = value; Id = v1;
                var v2 = IsTemplateDatesLocked; v2.Clean = value; IsTemplateDatesLocked = v2;
                var v3 = IsTemplateLocked; v3.Clean = value; IsTemplateLocked = v3;
                var v4 = MilestoneTemplateID; v4.Clean = value; MilestoneTemplateID = v4;
                var v5 = MilestoneTemplateName; v5.Clean = value; MilestoneTemplateName = v5;
                _settingClean = 0;
            }
        }
    }
}