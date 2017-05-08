using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class Hmda
    {
        public string loanPurpose { get; set; }
        public string mSANumber { get; set; }
        public string censusTrack { get; set; }
        public string actionTaken { get; set; }
        public string stateCode { get; set; }
        public string countyCode { get; set; }
        public string typeOfPurchaser { get; set; }
        public string propertyType { get; set; }
        public string preapprovals { get; set; }
        public string hOEPAStatus { get; set; }
        public string lienStatus { get; set; }
        public string rateSpread { get; set; }
        public string denialReason1 { get; set; }
        public string denialReason2 { get; set; }
        public string denialReason3 { get; set; }
        public bool? excludeLoanFromHMDAReportIndicator { get; set; }
        public bool? reportPurposeOfLoanIndicator { get; set; }
        public string qMStatus { get; set; }
        public string id { get; set; }

    }
}
