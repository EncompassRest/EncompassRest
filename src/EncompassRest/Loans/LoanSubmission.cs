using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class LoanSubmission
    {
        public JsonNullable<decimal?> AmountAvailable { get; set; }
        public JsonNullable<decimal?> AmountRequiredToClose { get; set; }
        public string BuydownDescription { get; set; }
        public string BuydownMonthsPerAdjustment { get; set; }
        public string Comments { get; set; }
        public JsonNullable<DateTime?> CurrentRateSetDate { get; set; }
        public JsonNullable<DateTime?> DateLastPaymentReceived { get; set; }
        public JsonNullable<bool?> FloodIndicator { get; set; }
        public JsonNullable<bool?> HazardIndicator { get; set; }
        public string Id { get; set; }
        public JsonNullable<bool?> IsSecondaryRegistration { get; set; }
        public JsonNullable<List<LoanSubmissionFee>> LoanSubmissionFees { get; set; }
        public JsonNullable<DateTime?> LockDate { get; set; }
        public JsonNullable<DateTime?> LockDateTimestampUtc { get; set; }
        public JsonNullable<DateTime?> LockExpiresDate { get; set; }
        public JsonNullable<bool?> MmmPmiIndicator { get; set; }
        public JsonNullable<int?> NumberOfDays { get; set; }
        public string OtherDescription { get; set; }
        public JsonNullable<bool?> OtherIndicator { get; set; }
        public string ProgramCode { get; set; }
        public string RateLock { get; set; }
        public JsonNullable<DateTime?> RateLockDisclosureDate { get; set; }
        public JsonNullable<bool?> ReducedDocsIndicator { get; set; }
        public JsonNullable<bool?> TaxesIndicator { get; set; }
        public JsonNullable<decimal?> Total { get; set; }
        public JsonNullable<decimal?> TotalDiscountPointCharged { get; set; }
        public JsonNullable<decimal?> TotalForDueBroker { get; set; }
        public JsonNullable<decimal?> TotalForDueLender { get; set; }
        public JsonNullable<decimal?> TotalForPrimaryResidence { get; set; }
    }
}