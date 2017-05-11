using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class MilestoneTemplateLog
    {
        public bool? IsTemplateLocked { get; set; }
        public bool? IsTemplateDatesLocked { get; set; }
        public string Id { get; set; }
        public int? ElliLogRecordId { get; set; }
        public string MilestoneTemplateID { get; set; }
        public string MilestoneTemplateName { get; set; }
    }
}