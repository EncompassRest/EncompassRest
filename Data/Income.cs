using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class Income
    {
        public string owner { get; set; }
        public string incomeType { get; set; }
        public decimal? amount { get; set; }
        public int? otherIncomeIndex { get; set; }
        public string description { get; set; }
        public string id { get; set; }
        public bool? currentIndicator { get; set; }

    }
}
