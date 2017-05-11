using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class GfeLien
    {
        public string GfeLienType { get; set; }
        public int? GfeLienIndex { get; set; }
        public string HolderName { get; set; }
        public decimal? AmountOwing { get; set; }
        public string Priority { get; set; }
        public string Id { get; set; }
    }
}