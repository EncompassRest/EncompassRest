#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class CustomModelFields : ExtensibleObject
    {
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _provideAmortizationScenario;
        public bool? ProvideAmortizationScenario { get => _provideAmortizationScenario; set => _provideAmortizationScenario = value; }
        private DirtyValue<bool?> _provideBestCaseScenario;
        public bool? ProvideBestCaseScenario { get => _provideBestCaseScenario; set => _provideBestCaseScenario = value; }
        private DirtyValue<bool?> _provideFHAScenario;
        public bool? ProvideFHAScenario { get => _provideFHAScenario; set => _provideFHAScenario = value; }
        private DirtyValue<bool?> _provideWorstCaseScenario;
        public bool? ProvideWorstCaseScenario { get => _provideWorstCaseScenario; set => _provideWorstCaseScenario = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _id.Dirty
                    || _provideAmortizationScenario.Dirty
                    || _provideBestCaseScenario.Dirty
                    || _provideFHAScenario.Dirty
                    || _provideWorstCaseScenario.Dirty;
            }
            set
            {
                _id.Dirty = value;
                _provideAmortizationScenario.Dirty = value;
                _provideBestCaseScenario.Dirty = value;
                _provideFHAScenario.Dirty = value;
                _provideWorstCaseScenario.Dirty = value;
            }
        }
    }
}