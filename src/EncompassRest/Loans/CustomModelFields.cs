using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class CustomModelFields
    {
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<bool?> _provideAmortizationScenario;
        public bool? ProvideAmortizationScenario { get { return _provideAmortizationScenario; } set { _provideAmortizationScenario = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProvideAmortizationScenario() => !_provideAmortizationScenario.Clean;
        private Value<bool?> _provideBestCaseScenario;
        public bool? ProvideBestCaseScenario { get { return _provideBestCaseScenario; } set { _provideBestCaseScenario = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProvideBestCaseScenario() => !_provideBestCaseScenario.Clean;
        private Value<bool?> _provideFHAScenario;
        public bool? ProvideFHAScenario { get { return _provideFHAScenario; } set { _provideFHAScenario = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProvideFHAScenario() => !_provideFHAScenario.Clean;
        private Value<bool?> _provideWorstCaseScenario;
        public bool? ProvideWorstCaseScenario { get { return _provideWorstCaseScenario; } set { _provideWorstCaseScenario = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProvideWorstCaseScenario() => !_provideWorstCaseScenario.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _id.Clean
                    && _provideAmortizationScenario.Clean
                    && _provideBestCaseScenario.Clean
                    && _provideFHAScenario.Clean
                    && _provideWorstCaseScenario.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _id; v0.Clean = value; _id = v0;
                var v1 = _provideAmortizationScenario; v1.Clean = value; _provideAmortizationScenario = v1;
                var v2 = _provideBestCaseScenario; v2.Clean = value; _provideBestCaseScenario = v2;
                var v3 = _provideFHAScenario; v3.Clean = value; _provideFHAScenario = v3;
                var v4 = _provideWorstCaseScenario; v4.Clean = value; _provideWorstCaseScenario = v4;
                _settingClean = 0;
            }
        }
    }
}