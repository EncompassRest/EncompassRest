using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Hud1EsPayTo
    {
        public int? Hud1EsPayToIndex { get; set; }
        public decimal? MaxDeductiblePercentage { get; set; }
        public decimal? MaxDeductibleAmount { get; set; }
        public string PolicyNumber { get; set; }
        public decimal? Premium { get; set; }
        public DateTime? RenewalDate { get; set; }
        public string PaymentSchedule { get; set; }
        public decimal? AmountLastPay { get; set; }
        public DateTime? DatePaid { get; set; }
        public decimal? AmountNextDue { get; set; }
        public DateTime? NextDueDate { get; set; }
        public DateTime? DelinquentDate { get; set; }
        public string FeeType { get; set; }
        public decimal? CoverageAmount { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Id { get; set; }
    }
}