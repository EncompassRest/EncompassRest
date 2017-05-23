using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class TQLComplianceAlert
    {
        public string Id { get; set; }
        public string LastComplianceOrderAlertCategories { get; set; }
        public string LastComplianceOrderAlertMessage { get; set; }
        public string LastComplianceOrderDescriptionOfAlerts { get; set; }
        public int? TQLComplianceAlertIndex { get; set; }
    }
}