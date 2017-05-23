using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class PurchaseCredit
    {
        public JsonNullable<decimal?> Amount { get; set; }
        public string Id { get; set; }
        public string PurchaseCreditType { get; set; }
    }
}