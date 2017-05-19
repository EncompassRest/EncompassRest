using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class SecondaryFinancingProvider
    {
        public string SecondaryFinancingProviderType { get; set; }
        public string Source { get; set; }
        public bool? SourceFromGovernmentIndicator { get; set; }
        public bool? SourceFromNPIndicator { get; set; }
        public bool? SourceFromFamilyIndicator { get; set; }
        public bool? SourceFromOtherIndicator { get; set; }
        public string SourceOtherDetail { get; set; }
        public decimal? FinancingAmount { get; set; }
        public bool? SellerFundedDapIndicator { get; set; }
        public string Id { get; set; }
    }
}