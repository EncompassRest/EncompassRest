using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class RegulationZPayment
    {
        public JsonNullable<decimal?> Balance { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> InterestRatePercent { get; set; }
        public JsonNullable<decimal?> MonthlyPayment { get; set; }
        public JsonNullable<int?> NumberOfPayments { get; set; }
        public JsonNullable<DateTime?> PaymentDate { get; set; }
        public int? RegulationZPaymentIndex { get; set; }
    }
}