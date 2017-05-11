using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class FeeVariance
    {
        public string FeeVarianceFeeType { get; set; }
        public int? FeeVarianceChargeIndex { get; set; }
        public decimal? InitialLE { get; set; }
        public decimal? LE { get; set; }
        public decimal? CD { get; set; }
        public decimal? Itemization { get; set; }
        public string Description { get; set; }
        public string Line { get; set; }
        public string Id { get; set; }
    }
}