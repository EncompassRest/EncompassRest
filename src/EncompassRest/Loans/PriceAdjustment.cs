using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class PriceAdjustment
    {
        public string AdjustmentType { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
        public string PriceAdjustmentType { get; set; }
        public JsonNullable<decimal?> Rate { get; set; }
        public string RateLockAdjustmentType { get; set; }
    }
}