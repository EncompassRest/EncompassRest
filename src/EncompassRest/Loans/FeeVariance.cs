using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class FeeVariance
    {
        public JsonNullable<decimal?> CD { get; set; }
        public string Description { get; set; }
        public JsonNullable<int?> FeeVarianceChargeIndex { get; set; }
        public string FeeVarianceFeeType { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> InitialLE { get; set; }
        public JsonNullable<decimal?> Itemization { get; set; }
        public JsonNullable<decimal?> LE { get; set; }
        public string Line { get; set; }
    }
}