using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// TQLComplianceAlert
    /// </summary>
    public sealed partial class TQLComplianceAlert : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        /// <summary>
        /// TQLComplianceAlert Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _lastComplianceOrderAlertCategories;
        /// <summary>
        /// TQL - Compliance Orders - Last Alert Categories [TQLCOMPLIANCEALERTNN01]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders - Last Alert Categories")]
        public string LastComplianceOrderAlertCategories { get => _lastComplianceOrderAlertCategories; set => SetField(ref _lastComplianceOrderAlertCategories, value); }
        private DirtyValue<string> _lastComplianceOrderAlertMessage;
        /// <summary>
        /// TQL - Compliance Orders - Last Alert Message [TQLCOMPLIANCEALERTNN03]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders - Last Alert Message")]
        public string LastComplianceOrderAlertMessage { get => _lastComplianceOrderAlertMessage; set => SetField(ref _lastComplianceOrderAlertMessage, value); }
        private DirtyValue<string> _lastComplianceOrderDescriptionOfAlerts;
        /// <summary>
        /// TQL - Compliance Orders - Last Alert Category Result [TQLCOMPLIANCEALERTNN02]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders - Last Alert Category Result")]
        public string LastComplianceOrderDescriptionOfAlerts { get => _lastComplianceOrderDescriptionOfAlerts; set => SetField(ref _lastComplianceOrderDescriptionOfAlerts, value); }
        private DirtyValue<int?> _tQLComplianceAlertIndex;
        /// <summary>
        /// TQLComplianceAlert TQLComplianceAlertIndex
        /// </summary>
        public int? TQLComplianceAlertIndex { get => _tQLComplianceAlertIndex; set => SetField(ref _tQLComplianceAlertIndex, value); }
    }
}