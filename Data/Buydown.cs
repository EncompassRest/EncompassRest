using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class Buydown
    {
        public decimal? increaseRatePercent { get; set; }
        public int? durationMonthsCount { get; set; }
        public int? changeFrequencyMonthsCount { get; set; }
        public decimal? buydownRatePercent { get; set; }
        public decimal? subsidyAmount { get; set; }
        public decimal? fundTotalAmount { get; set; }
        public decimal? fundBalanceAmount { get; set; }
        public int? remainingMonthsCount { get; set; }
        public string id { get; set; }
        public int? buydownIndex { get; set; }

    }
}
