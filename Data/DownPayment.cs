using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class DownPayment
    {
        public string downPaymentType { get; set; }
        public string sourceDescription { get; set; }
        public decimal? amount { get; set; }
        public string id { get; set; }

    }
}
