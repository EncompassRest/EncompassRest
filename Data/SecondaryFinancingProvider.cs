
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassREST.Data
    {
        public class SecondaryFinancingProvider
{
public string secondaryFinancingProviderType { get; set; }
public string source { get; set; }
public bool? sourceFromGovernmentIndicator { get; set; }
public bool? sourceFromNPIndicator { get; set; }
public bool? sourceFromFamilyIndicator { get; set; }
public bool? sourceFromOtherIndicator { get; set; }
public string sourceOtherDetail { get; set; }
public decimal? financingAmount { get; set; }
public bool? sellerFundedDapIndicator { get; set; }
public string id { get; set; }

    }
}