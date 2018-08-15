using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// TQLFraudAlert
    /// </summary>
    public sealed partial class TQLFraudAlert : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _driveFraudAlertCode;
        /// <summary>
        /// TQL - Fraud Orders -DRIVE  Fraud Alert Code #1-99 [TQLFRAUDALERTNN06]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Fraud Orders -DRIVE  Fraud Alert Code #1-99")]
        public string DriveFraudAlertCode { get => _driveFraudAlertCode; set => SetField(ref _driveFraudAlertCode, value); }
        private DirtyValue<string> _driveFraudAlertStatus;
        /// <summary>
        /// TQL - Fraud Orders - DRIVE Fraud Alert Status #1-99 [TQLFRAUDALERTNN05]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Fraud Orders - DRIVE Fraud Alert Status #1-99")]
        public string DriveFraudAlertStatus { get => _driveFraudAlertStatus; set => SetField(ref _driveFraudAlertStatus, value); }
        private DirtyValue<string> _fraudGuardFraudAlertCode;
        /// <summary>
        /// TQL - Fraud Orders - FraudGuard Fraud Alert Code #1-99 [TQLFRAUDALERTNN08]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Fraud Orders - FraudGuard Fraud Alert Code #1-99")]
        public string FraudGuardFraudAlertCode { get => _fraudGuardFraudAlertCode; set => SetField(ref _fraudGuardFraudAlertCode, value); }
        private DirtyValue<string> _fraudGuardFraudAlertStatus;
        /// <summary>
        /// TQL - Fraud Orders - FraudGuard Fraud Alert Status #1-99 [TQLFRAUDALERTNN07]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Fraud Orders - FraudGuard Fraud Alert Status #1-99")]
        public string FraudGuardFraudAlertStatus { get => _fraudGuardFraudAlertStatus; set => SetField(ref _fraudGuardFraudAlertStatus, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// TQLFraudAlert Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _lastFraudOrderAlertCategories;
        /// <summary>
        /// TQL - Fraud Orders - Last Fraud Categories [TQLFRAUDALERTNN01]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Fraud Orders - Last Fraud Categories")]
        public string LastFraudOrderAlertCategories { get => _lastFraudOrderAlertCategories; set => SetField(ref _lastFraudOrderAlertCategories, value); }
        private DirtyValue<string> _lastFraudOrderAlertID;
        /// <summary>
        /// TQL - Fraud Orders - Fraud Alert ID [TQLFRAUDALERTNN04]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Fraud Orders - Fraud Alert ID")]
        public string LastFraudOrderAlertID { get => _lastFraudOrderAlertID; set => SetField(ref _lastFraudOrderAlertID, value); }
        private DirtyValue<string> _lastFraudOrderAlertLevel;
        /// <summary>
        /// TQL - Fraud Orders - Last Alert Level [TQLFRAUDALERTNN03]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Fraud Orders - Last Alert Level")]
        public string LastFraudOrderAlertLevel { get => _lastFraudOrderAlertLevel; set => SetField(ref _lastFraudOrderAlertLevel, value); }
        private DirtyValue<string> _lastFraudOrderDescriptionOfAlerts;
        /// <summary>
        /// TQL - Fraud Orders - Last Alert Message [TQLFRAUDALERTNN02]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Fraud Orders - Last Alert Message")]
        public string LastFraudOrderDescriptionOfAlerts { get => _lastFraudOrderDescriptionOfAlerts; set => SetField(ref _lastFraudOrderDescriptionOfAlerts, value); }
        private DirtyValue<int?> _tQLFraudAlertIndex;
        /// <summary>
        /// TQLFraudAlert TQLFraudAlertIndex
        /// </summary>
        public int? TQLFraudAlertIndex { get => _tQLFraudAlertIndex; set => SetField(ref _tQLFraudAlertIndex, value); }
    }
}