using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// CustomModelFields
    /// </summary>
    public sealed partial class CustomModelFields : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        /// <summary>
        /// CustomModelFields Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _provideAmortizationScenario;
        /// <summary>
        /// CustomModelFields ProvideAmortizationScenario
        /// </summary>
        public bool? ProvideAmortizationScenario { get => _provideAmortizationScenario; set => _provideAmortizationScenario = value; }
        private DirtyValue<bool?> _provideBestCaseScenario;
        /// <summary>
        /// CustomModelFields ProvideBestCaseScenario
        /// </summary>
        public bool? ProvideBestCaseScenario { get => _provideBestCaseScenario; set => _provideBestCaseScenario = value; }
        private DirtyValue<bool?> _provideFHAScenario;
        /// <summary>
        /// CustomModelFields ProvideFHAScenario
        /// </summary>
        public bool? ProvideFHAScenario { get => _provideFHAScenario; set => _provideFHAScenario = value; }
        private DirtyValue<bool?> _provideWorstCaseScenario;
        /// <summary>
        /// CustomModelFields ProvideWorstCaseScenario
        /// </summary>
        public bool? ProvideWorstCaseScenario { get => _provideWorstCaseScenario; set => _provideWorstCaseScenario = value; }
        internal override bool DirtyInternal
        {
            get => _id.Dirty
                || _provideAmortizationScenario.Dirty
                || _provideBestCaseScenario.Dirty
                || _provideFHAScenario.Dirty
                || _provideWorstCaseScenario.Dirty;
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