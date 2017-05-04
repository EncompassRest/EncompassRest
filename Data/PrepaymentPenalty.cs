using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class PrepaymentPenalty
    {
        public string fullPrepaymentPenaltyOptionType { get; set; }
        public int? termMonthsCount { get; set; }
        public decimal? prepaymentPenaltyPercent { get; set; }
        public string id { get; set; }

    }
}
