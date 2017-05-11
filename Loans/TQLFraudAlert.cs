using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class TQLFraudAlert
    {
        public string LastFraudOrderAlertCategories { get; set; }
        public string LastFraudOrderDescriptionOfAlerts { get; set; }
        public string LastFraudOrderAlertLevel { get; set; }
        public string LastFraudOrderAlertID { get; set; }
        public string Id { get; set; }
        public int? TQLFraudAlertIndex { get; set; }
    }
}