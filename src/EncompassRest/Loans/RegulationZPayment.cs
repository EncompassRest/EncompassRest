using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class RegulationZPayment
    {
        public int? RegulationZPaymentIndex { get; set; }
        public decimal? InterestRatePercent { get; set; }
        public decimal? Balance { get; set; }
        public int? NumberOfPayments { get; set; }
        public decimal? MonthlyPayment { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string Id { get; set; }
    }
}