using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class TQLComplianceAlert : IDirty
    {
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _lastComplianceOrderAlertCategories;
        public string LastComplianceOrderAlertCategories { get { return _lastComplianceOrderAlertCategories; } set { _lastComplianceOrderAlertCategories = value; } }
        private DirtyValue<string> _lastComplianceOrderAlertMessage;
        public string LastComplianceOrderAlertMessage { get { return _lastComplianceOrderAlertMessage; } set { _lastComplianceOrderAlertMessage = value; } }
        private DirtyValue<string> _lastComplianceOrderDescriptionOfAlerts;
        public string LastComplianceOrderDescriptionOfAlerts { get { return _lastComplianceOrderDescriptionOfAlerts; } set { _lastComplianceOrderDescriptionOfAlerts = value; } }
        private DirtyValue<int?> _tQLComplianceAlertIndex;
        public int? TQLComplianceAlertIndex { get { return _tQLComplianceAlertIndex; } set { _tQLComplianceAlertIndex = value; } }
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
                var dirty = _id.Dirty
                    || _lastComplianceOrderAlertCategories.Dirty
                    || _lastComplianceOrderAlertMessage.Dirty
                    || _lastComplianceOrderDescriptionOfAlerts.Dirty
                    || _tQLComplianceAlertIndex.Dirty
                    || _extensionDataInternal?.Dirty == true;
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
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}