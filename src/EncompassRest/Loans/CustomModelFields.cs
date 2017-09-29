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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _id.Dirty
                    || _provideAmortizationScenario.Dirty
                    || _provideBestCaseScenario.Dirty
                    || _provideFHAScenario.Dirty
                    || _provideWorstCaseScenario.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _id.Dirty = value;
                _provideAmortizationScenario.Dirty = value;
                _provideBestCaseScenario.Dirty = value;
                _provideFHAScenario.Dirty = value;
                _provideWorstCaseScenario.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}