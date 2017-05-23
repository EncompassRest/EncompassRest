using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class TrustAccountItem
    {
        public JsonNullable<DateTime?> Date { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
        public string Notes { get; set; }
        public JsonNullable<decimal?> PaymentAmount { get; set; }
        public string PaymentCheckNo { get; set; }
        public JsonNullable<decimal?> ReceiptAmount { get; set; }
        public string ReceiptCheckNo { get; set; }
        public int? TrustAccountItemIndex { get; set; }
    }
}