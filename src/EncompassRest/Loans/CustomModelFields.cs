using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class CustomModelFields
    {
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> ProvideAmortizationScenario { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProvideAmortizationScenario() => !ProvideAmortizationScenario.Clean;
        public Value<bool?> ProvideBestCaseScenario { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProvideBestCaseScenario() => !ProvideBestCaseScenario.Clean;
        public Value<bool?> ProvideFHAScenario { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProvideFHAScenario() => !ProvideFHAScenario.Clean;
        public Value<bool?> ProvideWorstCaseScenario { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProvideWorstCaseScenario() => !ProvideWorstCaseScenario.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Id.Clean
                    && ProvideAmortizationScenario.Clean
                    && ProvideBestCaseScenario.Clean
                    && ProvideFHAScenario.Clean
                    && ProvideWorstCaseScenario.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Id; v0.Clean = value; Id = v0;
                var v1 = ProvideAmortizationScenario; v1.Clean = value; ProvideAmortizationScenario = v1;
                var v2 = ProvideBestCaseScenario; v2.Clean = value; ProvideBestCaseScenario = v2;
                var v3 = ProvideFHAScenario; v3.Clean = value; ProvideFHAScenario = v3;
                var v4 = ProvideWorstCaseScenario; v4.Clean = value; ProvideWorstCaseScenario = v4;
                _settingClean = 0;
            }
        }
    }
}