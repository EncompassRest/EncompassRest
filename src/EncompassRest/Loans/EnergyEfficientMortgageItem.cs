using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class EnergyEfficientMortgageItem
    {
        public JsonNullable<decimal?> ActualAmount { get; set; }
        public JsonNullable<decimal?> AllowedAmount { get; set; }
        public int? EnergyEfficientMortgageItemIndex { get; set; }
        public string Id { get; set; }
        public string Item { get; set; }
        public int? LineNumber { get; set; }
    }
}