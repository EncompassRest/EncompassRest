using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class GfePayoff
    {
        public int? GfePayoffIndex { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public string Id { get; set; }
    }
}