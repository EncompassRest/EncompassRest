using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class RegulationZPayment
    {
        public int? regulationZPaymentIndex { get; set; }
        public decimal? interestRatePercent { get; set; }
        public decimal? balance { get; set; }
        public int? numberOfPayments { get; set; }
        public decimal? monthlyPayment { get; set; }
        public DateTime? paymentDate { get; set; }
        public string id { get; set; }

    }
}
