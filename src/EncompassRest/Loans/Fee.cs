using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Fee
    {
        public string FeeType { get; set; }
        public decimal? SellerPaidAmount { get; set; }
        public string Description { get; set; }
        public decimal? BorPaidAmount { get; set; }
        public string PaidToName { get; set; }
        public decimal? MonthlyPayment { get; set; }
        public bool? Use4Decimals { get; set; }
        public int? Days { get; set; }
        public decimal? AmountPerDay { get; set; }
        public decimal? TruncatedAmountPerDay { get; set; }
        public int? NumberOfMonths { get; set; }
        public decimal? Percentage { get; set; }
        public decimal? Amount { get; set; }
        public decimal? PaidInAdvance { get; set; }
        public decimal? LenderCoverage { get; set; }
        public decimal? OwnerCoverage { get; set; }
        public decimal? DeedAmount { get; set; }
        public decimal? MortgageAmount { get; set; }
        public decimal? ReleasesAmount { get; set; }
        public string IncludeAboveNumber { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public decimal? PaidToOthers { get; set; }
        public decimal? PaidToBroker { get; set; }
        public bool? FHA { get; set; }
        public bool? PFC { get; set; }
        public bool? POC { get; set; }
        public string PaidBy { get; set; }
        public string PTB { get; set; }
        public string FWBC { get; set; }
        public string FWSC { get; set; }
        public decimal? NewHUDBorPaidAmount { get; set; }
        public string Id { get; set; }
    }
}