using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class TQLComplianceAlert : IDirty
    {
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _lastComplianceOrderAlertCategories;
        public string LastComplianceOrderAlertCategories { get => _lastComplianceOrderAlertCategories; set => _lastComplianceOrderAlertCategories = value; }
        private DirtyValue<string> _lastComplianceOrderAlertMessage;
        public string LastComplianceOrderAlertMessage { get => _lastComplianceOrderAlertMessage; set => _lastComplianceOrderAlertMessage = value; }
        private DirtyValue<string> _lastComplianceOrderDescriptionOfAlerts;
        public string LastComplianceOrderDescriptionOfAlerts { get => _lastComplianceOrderDescriptionOfAlerts; set => _lastComplianceOrderDescriptionOfAlerts = value; }
        private DirtyValue<int?> _tQLComplianceAlertIndex;
        public int? TQLComplianceAlertIndex { get => _tQLComplianceAlertIndex; set => _tQLComplianceAlertIndex = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _id.Dirty
                    || _lastComplianceOrderAlertCategories.Dirty
                    || _lastComplianceOrderAlertMessage.Dirty
                    || _lastComplianceOrderDescriptionOfAlerts.Dirty
                    || _tQLComplianceAlertIndex.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _id.Dirty = value;
                _lastComplianceOrderAlertCategories.Dirty = value;
                _lastComplianceOrderAlertMessage.Dirty = value;
                _lastComplianceOrderDescriptionOfAlerts.Dirty = value;
                _tQLComplianceAlertIndex.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}