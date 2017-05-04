
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class FannieMae
    {
        public bool? startUpMortgage { get; set; }
        public string mornetPlusCaseFileId { get; set; }
        public bool? communityLending { get; set; }
        public string community2ndRepaymentStructure { get; set; }
        public string duVersion { get; set; }
        public decimal? ltv { get; set; }
        public decimal? cltv { get; set; }
        public decimal? hcltv { get; set; }
        public decimal? interestedPartyContribution { get; set; }
        public string id { get; set; }

    }
}