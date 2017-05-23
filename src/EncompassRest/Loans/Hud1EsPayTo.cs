using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsPayTo
    {
        public string Address { get; set; }
        public JsonNullable<decimal?> AmountLastPay { get; set; }
        public JsonNullable<decimal?> AmountNextDue { get; set; }
        public string City { get; set; }
        public string ContactName { get; set; }
        public JsonNullable<decimal?> CoverageAmount { get; set; }
        public JsonNullable<DateTime?> DatePaid { get; set; }
        public JsonNullable<DateTime?> DelinquentDate { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string FeeType { get; set; }
        public int? Hud1EsPayToIndex { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> MaxDeductibleAmount { get; set; }
        public JsonNullable<decimal?> MaxDeductiblePercentage { get; set; }
        public string Name { get; set; }
        public JsonNullable<DateTime?> NextDueDate { get; set; }
        public string PaymentSchedule { get; set; }
        public string Phone { get; set; }
        public string PolicyNumber { get; set; }
        public string PostalCode { get; set; }
        public JsonNullable<decimal?> Premium { get; set; }
        public JsonNullable<DateTime?> RenewalDate { get; set; }
        public string State { get; set; }
    }
}