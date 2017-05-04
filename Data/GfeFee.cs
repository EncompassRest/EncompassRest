using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class GfeFee
    {
        public string gfeFeeType { get; set; }
        public int? gfeFeeIndex { get; set; }
        public string description { get; set; }
        public string amountDescription { get; set; }
        public decimal? brokerAmount { get; set; }
        public string rate { get; set; }
        public decimal? otherAmount { get; set; }
        public string id { get; set; }

    }
}
