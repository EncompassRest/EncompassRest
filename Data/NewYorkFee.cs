
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class NewYorkFee
    {
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public string comments { get; set; }
        public DateTime? date { get; set; }
        public decimal? amount { get; set; }
        public string feeType { get; set; }
        public string id { get; set; }
        public int? newYorkFeeIndex { get; set; }

    }
}