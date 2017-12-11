#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class TQLFraudAlert : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _driveFraudAlertCode;
        public string DriveFraudAlertCode { get => _driveFraudAlertCode; set => _driveFraudAlertCode = value; }
        private DirtyValue<string> _driveFraudAlertStatus;
        public string DriveFraudAlertStatus { get => _driveFraudAlertStatus; set => _driveFraudAlertStatus = value; }
        private DirtyValue<string> _fraudGuardFraudAlertCode;
        public string FraudGuardFraudAlertCode { get => _fraudGuardFraudAlertCode; set => _fraudGuardFraudAlertCode = value; }
        private DirtyValue<string> _fraudGuardFraudAlertStatus;
        public string FraudGuardFraudAlertStatus { get => _fraudGuardFraudAlertStatus; set => _fraudGuardFraudAlertStatus = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _lastFraudOrderAlertCategories;
        public string LastFraudOrderAlertCategories { get => _lastFraudOrderAlertCategories; set => _lastFraudOrderAlertCategories = value; }
        private DirtyValue<string> _lastFraudOrderAlertID;
        public string LastFraudOrderAlertID { get => _lastFraudOrderAlertID; set => _lastFraudOrderAlertID = value; }
        private DirtyValue<string> _lastFraudOrderAlertLevel;
        public string LastFraudOrderAlertLevel { get => _lastFraudOrderAlertLevel; set => _lastFraudOrderAlertLevel = value; }
        private DirtyValue<string> _lastFraudOrderDescriptionOfAlerts;
        public string LastFraudOrderDescriptionOfAlerts { get => _lastFraudOrderDescriptionOfAlerts; set => _lastFraudOrderDescriptionOfAlerts = value; }
        private DirtyValue<int?> _tQLFraudAlertIndex;
        public int? TQLFraudAlertIndex { get => _tQLFraudAlertIndex; set => _tQLFraudAlertIndex = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _driveFraudAlertCode.Dirty
                    || _driveFraudAlertStatus.Dirty
                    || _fraudGuardFraudAlertCode.Dirty
                    || _fraudGuardFraudAlertStatus.Dirty
                    || _id.Dirty
                    || _lastFraudOrderAlertCategories.Dirty
                    || _lastFraudOrderAlertID.Dirty
                    || _lastFraudOrderAlertLevel.Dirty
                    || _lastFraudOrderDescriptionOfAlerts.Dirty
                    || _tQLFraudAlertIndex.Dirty;
            }
            set
            {
                _driveFraudAlertCode.Dirty = value;
                _driveFraudAlertStatus.Dirty = value;
                _fraudGuardFraudAlertCode.Dirty = value;
                _fraudGuardFraudAlertStatus.Dirty = value;
                _id.Dirty = value;
                _lastFraudOrderAlertCategories.Dirty = value;
                _lastFraudOrderAlertID.Dirty = value;
                _lastFraudOrderAlertLevel.Dirty = value;
                _lastFraudOrderDescriptionOfAlerts.Dirty = value;
                _tQLFraudAlertIndex.Dirty = value;
            }
        }
    }
}