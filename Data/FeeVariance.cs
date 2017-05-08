
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class FeeVariance
{
public string feeVarianceFeeType { get; set; }
public int? feeVarianceChargeIndex { get; set; }
public decimal? initialLE { get; set; }
public decimal? lE { get; set; }
public decimal? cD { get; set; }
public decimal? itemization { get; set; }
public string description { get; set; }
public string line { get; set; }
public string id { get; set; }

    }
}