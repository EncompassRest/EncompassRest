
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class Hud1EsItemize
    {
        public string date { get; set; }
        public decimal? escrowPaymentTo { get; set; }
        public decimal? escrowPaymentFrom { get; set; }
        public string escrowPaymentDescription { get; set; }
        public decimal? escrowPaymentBalance { get; set; }
        public string id { get; set; }
        public int? hud1EsItemizeIndex { get; set; }

    }
}