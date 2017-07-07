using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class CustomModelFields : IClean
    {
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _provideAmortizationScenario;
        public bool? ProvideAmortizationScenario { get { return _provideAmortizationScenario; } set { _provideAmortizationScenario = value; } }
        private Value<bool?> _provideBestCaseScenario;
        public bool? ProvideBestCaseScenario { get { return _provideBestCaseScenario; } set { _provideBestCaseScenario = value; } }
        private Value<bool?> _provideFHAScenario;
        public bool? ProvideFHAScenario { get { return _provideFHAScenario; } set { _provideFHAScenario = value; } }
        private Value<bool?> _provideWorstCaseScenario;
        public bool? ProvideWorstCaseScenario { get { return _provideWorstCaseScenario; } set { _provideWorstCaseScenario = value; } }
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
                var id = _id; id.Clean = value; _id = id;
                var provideAmortizationScenario = _provideAmortizationScenario; provideAmortizationScenario.Clean = value; _provideAmortizationScenario = provideAmortizationScenario;
                var provideBestCaseScenario = _provideBestCaseScenario; provideBestCaseScenario.Clean = value; _provideBestCaseScenario = provideBestCaseScenario;
                var provideFHAScenario = _provideFHAScenario; provideFHAScenario.Clean = value; _provideFHAScenario = provideFHAScenario;
                var provideWorstCaseScenario = _provideWorstCaseScenario; provideWorstCaseScenario.Clean = value; _provideWorstCaseScenario = provideWorstCaseScenario;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public CustomModelFields()
        {
            Clean = true;
        }
    }
}