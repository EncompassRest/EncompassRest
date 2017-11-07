using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using EncompassRest.Loans.Enums;
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
        private ExtensionDataObject _extensionDataInternal;
        [JsonExtensionData]
        private ExtensionDataObject ExtensionDataInternal { get { return _extensionDataInternal ?? (_extensionDataInternal = new ExtensionDataObject()); } set { _extensionDataInternal = value; } }
        [JsonIgnore]
        public IDictionary<string, object> ExtensionData { get { return ExtensionDataInternal.InternalDictionary; } set { _extensionDataInternal = new ExtensionDataObject(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _driveFraudAlertCode.Dirty
                    || _driveFraudAlertStatus.Dirty
                    || _fraudGuardFraudAlertCode.Dirty
                    || _fraudGuardFraudAlertStatus.Dirty
                    || _id.Dirty
                    || _lastFraudOrderAlertCategories.Dirty
                    || _lastFraudOrderAlertID.Dirty
                    || _lastFraudOrderAlertLevel.Dirty
                    || _lastFraudOrderDescriptionOfAlerts.Dirty
                    || _tQLFraudAlertIndex.Dirty
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}