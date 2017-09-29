using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class TQLFraudAlert : IDirty
    {
        private DirtyValue<string> _driveFraudAlertCode;
        public string DriveFraudAlertCode { get { return _driveFraudAlertCode; } set { _driveFraudAlertCode = value; } }
        private DirtyValue<string> _driveFraudAlertStatus;
        public string DriveFraudAlertStatus { get { return _driveFraudAlertStatus; } set { _driveFraudAlertStatus = value; } }
        private DirtyValue<string> _fraudGuardFraudAlertCode;
        public string FraudGuardFraudAlertCode { get { return _fraudGuardFraudAlertCode; } set { _fraudGuardFraudAlertCode = value; } }
        private DirtyValue<string> _fraudGuardFraudAlertStatus;
        public string FraudGuardFraudAlertStatus { get { return _fraudGuardFraudAlertStatus; } set { _fraudGuardFraudAlertStatus = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _lastFraudOrderAlertCategories;
        public string LastFraudOrderAlertCategories { get { return _lastFraudOrderAlertCategories; } set { _lastFraudOrderAlertCategories = value; } }
        private DirtyValue<string> _lastFraudOrderAlertID;
        public string LastFraudOrderAlertID { get { return _lastFraudOrderAlertID; } set { _lastFraudOrderAlertID = value; } }
        private DirtyValue<string> _lastFraudOrderAlertLevel;
        public string LastFraudOrderAlertLevel { get { return _lastFraudOrderAlertLevel; } set { _lastFraudOrderAlertLevel = value; } }
        private DirtyValue<string> _lastFraudOrderDescriptionOfAlerts;
        public string LastFraudOrderDescriptionOfAlerts { get { return _lastFraudOrderDescriptionOfAlerts; } set { _lastFraudOrderDescriptionOfAlerts = value; } }
        private DirtyValue<int?> _tQLFraudAlertIndex;
        public int? TQLFraudAlertIndex { get { return _tQLFraudAlertIndex; } set { _tQLFraudAlertIndex = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _driveFraudAlertCode.Dirty
                    || _driveFraudAlertStatus.Dirty
                    || _fraudGuardFraudAlertCode.Dirty
                    || _fraudGuardFraudAlertStatus.Dirty
                    || _id.Dirty
                    || _lastFraudOrderAlertCategories.Dirty
                    || _lastFraudOrderAlertID.Dirty
                    || _lastFraudOrderAlertLevel.Dirty
                    || _lastFraudOrderDescriptionOfAlerts.Dirty
                    || _tQLFraudAlertIndex.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}