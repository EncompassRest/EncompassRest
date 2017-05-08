using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class Funding
    {
        public string funderName { get; set; }
        public DateTime? sentToFunderDate { get; set; }
        public string fundingType { get; set; }
        public DateTime? fundingCloseDate { get; set; }
        public string fundingClearedBy { get; set; }
        public DateTime? fundingOrderDate { get; set; }
        public DateTime? fundsSentDate { get; set; }
        public DateTime? collateralSentDate { get; set; }
        public DateTime? fundsReleasedDate { get; set; }
        public string fundsReleaseNumber { get; set; }
        public string fundsWireTo { get; set; }
        public string wiredToForCreditTo1 { get; set; }
        public string wiredToForCreditTo2 { get; set; }
        public string wiredToForFurtherCreditTo1 { get; set; }
        public string wiredToForFurtherCreditTo2 { get; set; }
        public string wiredToAbaNumber { get; set; }
        public string wiredToAccountNumber { get; set; }
        public string wiredToForCreditTo { get; set; }
        public string funderUrl { get; set; }
        public string fundingFees { get; set; }
        public string id { get; set; }

    }
}
