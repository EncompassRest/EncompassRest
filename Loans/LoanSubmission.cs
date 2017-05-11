using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class LoanSubmission
    {
        public decimal? AmountAvailable { get; set; }
        public List<LoanSubmissionFee> LoanSubmissionFees { get; set; }
        public bool? ReducedDocsIndicator { get; set; }
        public decimal? TotalDiscountPointCharged { get; set; }
        public string RateLock { get; set; }
        public int? NumberOfDays { get; set; }
        public decimal? TotalForDueLender { get; set; }
        public decimal? TotalForDueBroker { get; set; }
        public decimal? Total { get; set; }
        public string Comments { get; set; }
        public decimal? AmountRequiredToClose { get; set; }
        public DateTime? LockDate { get; set; }
        public DateTime? LockExpiresDate { get; set; }
        public string ProgramCode { get; set; }
        public string BuydownMonthsPerAdjustment { get; set; }
        public string BuydownDescription { get; set; }
        public decimal? TotalForPrimaryResidence { get; set; }
        public bool? TaxesIndicator { get; set; }
        public bool? HazardIndicator { get; set; }
        public bool? MmmPmiIndicator { get; set; }
        public bool? FloodIndicator { get; set; }
        public bool? OtherIndicator { get; set; }
        public string OtherDescription { get; set; }
        public DateTime? DateLastPaymentReceived { get; set; }
        public DateTime? LockDateTimestampUtc { get; set; }
        public DateTime? CurrentRateSetDate { get; set; }
        public DateTime? RateLockDisclosureDate { get; set; }
        public bool? IsSecondaryRegistration { get; set; }
        public string Id { get; set; }
    }
}