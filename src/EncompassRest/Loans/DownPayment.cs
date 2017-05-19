using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class DownPayment
    {
        public string DownPaymentType { get; set; }
        public string SourceDescription { get; set; }
        public decimal? Amount { get; set; }
        public string Id { get; set; }
    }
}