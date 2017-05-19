using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class CustomModelFields
    {
        public string Id { get; set; }
        public bool? ProvideAmortizationScenario { get; set; }
        public bool? ProvideWorstCaseScenario { get; set; }
        public bool? ProvideBestCaseScenario { get; set; }
        public bool? ProvideFHAScenario { get; set; }
    }
}