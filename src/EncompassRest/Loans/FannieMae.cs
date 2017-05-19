using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class FannieMae
    {
        public bool? StartUpMortgage { get; set; }
        public string MornetPlusCaseFileId { get; set; }
        public bool? CommunityLending { get; set; }
        public string Community2ndRepaymentStructure { get; set; }
        public string DuVersion { get; set; }
        public decimal? Ltv { get; set; }
        public decimal? Cltv { get; set; }
        public decimal? Hcltv { get; set; }
        public decimal? InterestedPartyContribution { get; set; }
        public string PropertyInspectionWaiverMessage { get; set; }
        public string CollateralUnderwriterScore { get; set; }
        public string Id { get; set; }
    }
}