using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class GfePayoff
    {
        public JsonNullable<decimal?> Amount { get; set; }
        public string Description { get; set; }
        public int? GfePayoffIndex { get; set; }
        public string Id { get; set; }
    }
}