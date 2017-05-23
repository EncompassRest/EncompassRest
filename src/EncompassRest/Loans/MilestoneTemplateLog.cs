using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class MilestoneTemplateLog
    {
        public int? ElliLogRecordId { get; set; }
        public string Id { get; set; }
        public bool? IsTemplateDatesLocked { get; set; }
        public bool? IsTemplateLocked { get; set; }
        public string MilestoneTemplateID { get; set; }
        public string MilestoneTemplateName { get; set; }
    }
}