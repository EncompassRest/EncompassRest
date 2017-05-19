using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class PurchaseCredit
    {
        public decimal? Amount { get; set; }
        public string PurchaseCreditType { get; set; }
        public string Id { get; set; }
    }
}