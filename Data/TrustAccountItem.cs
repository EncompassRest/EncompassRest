
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class TrustAccountItem
{
public string description { get; set; }
public DateTime? date { get; set; }
public string notes { get; set; }
public decimal? paymentAmount { get; set; }
public string paymentCheckNo { get; set; }
public decimal? receiptAmount { get; set; }
public string receiptCheckNo { get; set; }
public string id { get; set; }
public int? trustAccountItemIndex { get; set; }

    }
}