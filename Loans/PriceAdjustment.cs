using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class PriceAdjustment
    {
        public string Description { get; set; }
        public decimal? Rate { get; set; }
        public string Id { get; set; }
        public string AdjustmentType { get; set; }
        public string PriceAdjustmentType { get; set; }
        public string RateLockAdjustmentType { get; set; }
    }
}