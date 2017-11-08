using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
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
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get { return _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); } set { _extensionData = new DirtyDictionary<string, object>(value); } }
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
                    || _extensionData?.Dirty == true;
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
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}