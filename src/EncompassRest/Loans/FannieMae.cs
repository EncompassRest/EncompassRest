using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class FannieMae
    {
        public JsonNullable<decimal?> Cltv { get; set; }
        public string CollateralUnderwriterScore { get; set; }
        public string Community2ndRepaymentStructure { get; set; }
        public JsonNullable<bool?> CommunityLending { get; set; }
        public string DuVersion { get; set; }
        public JsonNullable<decimal?> Hcltv { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> InterestedPartyContribution { get; set; }
        public JsonNullable<decimal?> Ltv { get; set; }
        public string MornetPlusCaseFileId { get; set; }
        public string PropertyInspectionWaiverMessage { get; set; }
        public JsonNullable<bool?> StartUpMortgage { get; set; }
    }
}