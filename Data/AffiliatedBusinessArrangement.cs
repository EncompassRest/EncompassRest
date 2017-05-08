
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class AffiliatedBusinessArrangement
{
public string lenderName { get; set; }
public string lenderAddress { get; set; }
public string lenderAddressCity { get; set; }
public string lenderAddressState { get; set; }
public string lenderAddressZipcode { get; set; }
public string affiliateName { get; set; }
public string natureOfRelationship { get; set; }
public bool? settlementIndicator { get; set; }
public bool? purchaseSaleRefinanceIndicator { get; set; }
public string serviceDescription1 { get; set; }
public string serviceDescription2 { get; set; }
public string serviceDescription3 { get; set; }
public string serviceDescription4 { get; set; }
public string serviceDescription5 { get; set; }
public string serviceDescription6 { get; set; }
public string chargeRangeChargesDescription1 { get; set; }
public string chargeRangeChargesDescription2 { get; set; }
public string chargeRangeChargesDescription3 { get; set; }
public string chargeRangeChargesDescription4 { get; set; }
public string chargeRangeChargesDescription5 { get; set; }
public string chargeRangeChargesDescription6 { get; set; }
public bool? requiredUseIndicator1 { get; set; }
public bool? requiredUseIndicator2 { get; set; }
public bool? requiredUseIndicator3 { get; set; }
public bool? requiredUseIndicator4 { get; set; }
public bool? requiredUseIndicator5 { get; set; }
public bool? requiredUseIndicator6 { get; set; }
public decimal? percentOwnershipInterest { get; set; }
public string id { get; set; }
public int? affiliatedBusinessArrangementIndex { get; set; }

    }
}