
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class RespaHudDetail
    {
        public int? lineNumber { get; set; }
        public decimal? lineItemAmount { get; set; }
        public DateTime? hUD1LineItemFromDate { get; set; }
        public DateTime? hUD1LineItemToDate { get; set; }
        public string lineItemDescription { get; set; }
        public decimal? realValue { get; set; }
        public string creditDebt { get; set; }
        public string fWBC { get; set; }
        public string id { get; set; }

    }
}