using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class PurchaseAdvicePayout
    {
        public decimal? ExpectedAmount { get; set; }
        public decimal? DiffAmount { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public string Id { get; set; }
    }
}