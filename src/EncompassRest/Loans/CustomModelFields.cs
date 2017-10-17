using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class CustomModelFields : IDirty
    {
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<bool?> _provideAmortizationScenario;
        public bool? ProvideAmortizationScenario { get { return _provideAmortizationScenario; } set { _provideAmortizationScenario = value; } }
        private DirtyValue<bool?> _provideBestCaseScenario;
        public bool? ProvideBestCaseScenario { get { return _provideBestCaseScenario; } set { _provideBestCaseScenario = value; } }
        private DirtyValue<bool?> _provideFHAScenario;
        public bool? ProvideFHAScenario { get { return _provideFHAScenario; } set { _provideFHAScenario = value; } }
        private DirtyValue<bool?> _provideWorstCaseScenario;
        public bool? ProvideWorstCaseScenario { get { return _provideWorstCaseScenario; } set { _provideWorstCaseScenario = value; } }
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
                    || _provideAmortizationScenario.Dirty
                    || _provideBestCaseScenario.Dirty
                    || _provideFHAScenario.Dirty
                    || _provideWorstCaseScenario.Dirty
                  || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _id.Dirty = value;
                _provideAmortizationScenario.Dirty = value;
                _provideBestCaseScenario.Dirty = value;
                _provideFHAScenario.Dirty = value;
                _provideWorstCaseScenario.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}