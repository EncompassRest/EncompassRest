
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class HelocRepaymentDrawPeriod
    {
        public int? year { get; set; }
        public decimal? indexRatePercent { get; set; }
        public decimal? marginRatePercent { get; set; }
        public decimal? apr { get; set; }
        public decimal? minimumMonthlyPaymentAmount { get; set; }
        public string id { get; set; }
        public bool? drawIndicator { get; set; }

    }
}