
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class ProfitManagementItem
    {
        public int? profitManagementItemIndex { get; set; }
        public decimal? atPercent { get; set; }
        public string type { get; set; }
        public decimal? plusAmount { get; set; }
        public decimal? total { get; set; }
        public string description { get; set; }
        public string id { get; set; }

    }
}