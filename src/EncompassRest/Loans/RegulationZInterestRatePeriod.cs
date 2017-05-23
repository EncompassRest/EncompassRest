using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class RegulationZInterestRatePeriod
    {
        public JsonNullable<DateTime?> AdjustmentDate { get; set; }
        public JsonNullable<int?> AdjustmentMonths { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> InterestPayment { get; set; }
        public JsonNullable<decimal?> InterestPrincipalPayment { get; set; }
        public JsonNullable<decimal?> InterestRatePercent { get; set; }
        public JsonNullable<decimal?> MonthlyPayment { get; set; }
        public JsonNullable<decimal?> PrincipalPayment { get; set; }
        public string RegulationZInterestRatePeriodType { get; set; }
        public JsonNullable<decimal?> TaxInsuranceAmount { get; set; }
        public JsonNullable<decimal?> TotalPayment { get; set; }
    }
}