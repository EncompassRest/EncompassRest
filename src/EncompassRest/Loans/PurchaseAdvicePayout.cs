using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class PurchaseAdvicePayout
    {
        public JsonNullable<decimal?> Amount { get; set; }
        public string Description { get; set; }
        public JsonNullable<decimal?> DiffAmount { get; set; }
        public JsonNullable<decimal?> ExpectedAmount { get; set; }
        public string Id { get; set; }
    }
}