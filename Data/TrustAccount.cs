
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class TrustAccount
{
public List<TrustAccountItem> trustAccountItems { get; set; }
public decimal? balance { get; set; }
public decimal? total1 { get; set; }
public decimal? total2 { get; set; }
public string id { get; set; }

    }
}