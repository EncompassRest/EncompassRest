using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class PriceAdjustment
    {
        public string description { get; set; }
        public decimal? rate { get; set; }
        public string id { get; set; }
        public string adjustmentType { get; set; }
        public string priceAdjustmentType { get; set; }
        public string rateLockAdjustmentType { get; set; }

    }
}
