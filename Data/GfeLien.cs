
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class GfeLien
    {
        public string gfeLienType { get; set; }
        public int? gfeLienIndex { get; set; }
        public string holderName { get; set; }
        public decimal? amountOwing { get; set; }
        public string priority { get; set; }
        public string id { get; set; }

    }
}