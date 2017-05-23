using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class SecondaryFinancingProvider
    {
        public JsonNullable<decimal?> FinancingAmount { get; set; }
        public string Id { get; set; }
        public string SecondaryFinancingProviderType { get; set; }
        public JsonNullable<bool?> SellerFundedDapIndicator { get; set; }
        public string Source { get; set; }
        public JsonNullable<bool?> SourceFromFamilyIndicator { get; set; }
        public JsonNullable<bool?> SourceFromGovernmentIndicator { get; set; }
        public JsonNullable<bool?> SourceFromNPIndicator { get; set; }
        public JsonNullable<bool?> SourceFromOtherIndicator { get; set; }
        public string SourceOtherDetail { get; set; }
    }
}