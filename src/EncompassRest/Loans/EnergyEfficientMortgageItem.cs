using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class EnergyEfficientMortgageItem
    {
        public string Item { get; set; }
        public decimal? ActualAmount { get; set; }
        public decimal? AllowedAmount { get; set; }
        public string Id { get; set; }
        public int? EnergyEfficientMortgageItemIndex { get; set; }
        public int? LineNumber { get; set; }
    }
}