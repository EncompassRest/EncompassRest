using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class TrustAccountItem
    {
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public string Notes { get; set; }
        public decimal? PaymentAmount { get; set; }
        public string PaymentCheckNo { get; set; }
        public decimal? ReceiptAmount { get; set; }
        public string ReceiptCheckNo { get; set; }
        public string Id { get; set; }
        public int? TrustAccountItemIndex { get; set; }
    }
}