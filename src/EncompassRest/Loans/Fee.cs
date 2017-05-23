using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Fee
    {
        public JsonNullable<decimal?> Amount { get; set; }
        public JsonNullable<decimal?> AmountPerDay { get; set; }
        public JsonNullable<decimal?> BorPaidAmount { get; set; }
        public JsonNullable<DateTime?> DateFrom { get; set; }
        public JsonNullable<DateTime?> DateTo { get; set; }
        public JsonNullable<int?> Days { get; set; }
        public JsonNullable<decimal?> DeedAmount { get; set; }
        public string Description { get; set; }
        public string FeeType { get; set; }
        public JsonNullable<bool?> FHA { get; set; }
        public string FWBC { get; set; }
        public string FWSC { get; set; }
        public string Id { get; set; }
        public string IncludeAboveNumber { get; set; }
        public JsonNullable<decimal?> LenderCoverage { get; set; }
        public JsonNullable<decimal?> MonthlyPayment { get; set; }
        public JsonNullable<decimal?> MortgageAmount { get; set; }
        public decimal? NewHUDBorPaidAmount { get; set; }
        public JsonNullable<int?> NumberOfMonths { get; set; }
        public JsonNullable<decimal?> OwnerCoverage { get; set; }
        public string PaidBy { get; set; }
        public JsonNullable<decimal?> PaidInAdvance { get; set; }
        public JsonNullable<decimal?> PaidToBroker { get; set; }
        public string PaidToName { get; set; }
        public JsonNullable<decimal?> PaidToOthers { get; set; }
        public JsonNullable<decimal?> Percentage { get; set; }
        public JsonNullable<bool?> PFC { get; set; }
        public JsonNullable<bool?> POC { get; set; }
        public string PTB { get; set; }
        public JsonNullable<decimal?> ReleasesAmount { get; set; }
        public JsonNullable<decimal?> SellerPaidAmount { get; set; }
        public JsonNullable<decimal?> TruncatedAmountPerDay { get; set; }
        public JsonNullable<bool?> Use4Decimals { get; set; }
    }
}