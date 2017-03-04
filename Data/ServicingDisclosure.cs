
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassREST.Data
    {
        public class ServicingDisclosure
{
public bool? weMayAssignIndicator { get; set; }
public bool? zeroTo25Indicator { get; set; }
public bool? twentySixTo50Indicator { get; set; }
public bool? fiftyOneTo75Indicator { get; set; }
public bool? seventySixTo100Indicator { get; set; }
public string thisInformationType { get; set; }
public string weAreAbleType { get; set; }
public bool? weHavePreviouslyAssignedIndicator { get; set; }
public bool? thisIsOurRecordOfTransferingIndicator { get; set; }
public string disclosureYear1 { get; set; }
public decimal? disclosurePercent1 { get; set; }
public string disclosureYear2 { get; set; }
public decimal? disclosurePercent2 { get; set; }
public string disclosureYear3 { get; set; }
public decimal? disclosurePercent3 { get; set; }
public bool? weDoNotSellMortgageLoansIndicator { get; set; }
public bool? weDoNotServiceMortgageLoansIndicator { get; set; }
public bool? weHaveNotServicedMortgLoansIn3YrsIndicator { get; set; }
public string thisEstimateType { get; set; }
public string id { get; set; }

    }
}