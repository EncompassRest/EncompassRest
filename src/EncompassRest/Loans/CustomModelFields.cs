using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class CustomModelFields
    {
        public string Id { get; set; }
        public JsonNullable<bool?> ProvideAmortizationScenario { get; set; }
        public JsonNullable<bool?> ProvideBestCaseScenario { get; set; }
        public JsonNullable<bool?> ProvideFHAScenario { get; set; }
        public JsonNullable<bool?> ProvideWorstCaseScenario { get; set; }
    }
}