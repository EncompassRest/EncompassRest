
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassREST.Data
    {
        public class RegulationZInterestRatePeriod
{
public string regulationZInterestRatePeriodType { get; set; }
public decimal? taxInsuranceAmount { get; set; }
public decimal? totalPayment { get; set; }
public DateTime? adjustmentDate { get; set; }
public decimal? principalPayment { get; set; }
public decimal? interestPayment { get; set; }
public decimal? interestRatePercent { get; set; }
public decimal? interestPrincipalPayment { get; set; }
public int? adjustmentMonths { get; set; }
public decimal? monthlyPayment { get; set; }
public string id { get; set; }

    }
}