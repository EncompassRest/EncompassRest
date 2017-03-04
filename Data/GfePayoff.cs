
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class GfePayoff
    {
        public int? gfePayoffIndex { get; set; }
        public string description { get; set; }
        public decimal? amount { get; set; }
        public string id { get; set; }

    }
}