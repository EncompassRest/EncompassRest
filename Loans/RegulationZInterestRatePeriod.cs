using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class RegulationZInterestRatePeriod
    {
        public string RegulationZInterestRatePeriodType { get; set; }
        public decimal? TaxInsuranceAmount { get; set; }
        public decimal? TotalPayment { get; set; }
        public DateTime? AdjustmentDate { get; set; }
        public decimal? PrincipalPayment { get; set; }
        public decimal? InterestPayment { get; set; }
        public decimal? InterestRatePercent { get; set; }
        public decimal? InterestPrincipalPayment { get; set; }
        public int? AdjustmentMonths { get; set; }
        public decimal? MonthlyPayment { get; set; }
        public string Id { get; set; }
    }
}