using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class DownPayment
    {
        public JsonNullable<decimal?> Amount { get; set; }
        public string DownPaymentType { get; set; }
        public string Id { get; set; }
        public string SourceDescription { get; set; }
    }
}