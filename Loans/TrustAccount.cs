using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class TrustAccount
    {
        public List<TrustAccountItem> TrustAccountItems { get; set; }
        public decimal? Balance { get; set; }
        public decimal? Total1 { get; set; }
        public decimal? Total2 { get; set; }
        public string Id { get; set; }
    }
}