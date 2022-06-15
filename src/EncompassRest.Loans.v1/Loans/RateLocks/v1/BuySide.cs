using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans.RateLocks.v1
{
    /// <summary>
    /// BuySide
    /// </summary>
    public sealed partial class BuySide : DirtyExtensibleObject
    {
        /// <summary>
        /// The individual who entered the buy side lock and pricing information.
        /// </summary>
        public string? RequestedBy { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Lock date for overnight rate protection (ONRP) for an initial lock.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? OnrpDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the loan is eligible for ONRP.
        /// </summary>
        public bool? OnrpEligible { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Unique identifier for the Correspondent Trade associated with the loan.
        /// </summary>
        public string? CommitmentNumber { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Unique identifier for the Correspondent Master Commitment associated with the loan.
        /// </summary>
        public string? MasterCommitmentNumber { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock buy side TPO name.
        /// </summary>
        public string? TpoName { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The Site ID for the TPO WebCenter site.
        /// </summary>
        public string? TpoId { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The organization ID of the TPO Company.
        /// </summary>
        public string? OrgId { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The commitment date for the loan.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? CommitmentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// The type of Lock applied to the loan. Possible values are: best efforts, mandatory
        /// </summary>
        public StringEnumValue<CommitmentType> CommitmentType { get => GetValue<StringEnumValue<CommitmentType>>(); set => SetValue(value); }

        /// <summary>
        /// Delivery type for the loan request. If the Commitment Type is defined, this field will be automatically populated (“Individual Best Efforts for “Best Efforts Commitment Type and “Individual Mandatory” for “Mandatory” Commitment Type).
        /// </summary>
        public string? DeliveryType { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The date the commitment expires.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? ExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// The day the note was drawn on the loan.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? DeliveryExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock buy side starting adjusted rate.
        /// </summary>
        public decimal? StartingAdjustPrice { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Lock request buy side undiscounted rate.
        /// </summary>
        public decimal? UnDiscountedRate { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock buy side starting adjusted price.
        /// </summary>
        public decimal? StartingAdjPrice { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Date when the branch price concession was approved.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? BranchApprovalDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Individual who approved the branch price concession.
        /// </summary>
        public string? BranchApprovedby { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Adjustment amount paid by your branch to offset pricing on a lock to subsize the cost to the borrower.
        /// </summary>
        public decimal? BranchPrice { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Date when the corporate price concession was approved.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? CorporateApprovalDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Individual who approved the corporate price concession.
        /// </summary>
        public string? CorporateApprovedby { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Adjustment amount paid by your company to offset pricing on a lock to subsize the cost to the borrower.
        /// </summary>
        public decimal? CorporatePrice { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The value of the rate lock buy side profit margin adjustment.
        /// </summary>
        public decimal? ProfitMarginAdjustedBuyPrice { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Description of the reason for approving the branch price concession.
        /// </summary>
        public string? ReasonforBranchApproval { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Description of the reason for approving the company concession.
        /// </summary>
        public string? ReasonforCorporateApproval { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock buy side total buy price.
        /// </summary>
        public decimal? TotalBuyPrice { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock buy side total price.
        /// </summary>
        public decimal? TotalPrice { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Unique identifier for the Correspondent Trade associated with the loan.
        /// </summary>
        public string? CorrespondentTradeId { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The assigned trade number for the rate lock.
        /// </summary>
        public string? CorrespondentTradeNumber { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Buy side number of additional days for the rate lock extension.
        /// </summary>
        public int? DaysToExtend { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// Buy side expiration date for the requested rate lock extension.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? ExtendedLockExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Buy side price adjustment for the requested rate lock extension.
        /// </summary>
        public decimal? LockExtendPriceAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Unique identifier for the Correspondent Master Commitment associated with the loan.
        /// </summary>
        public string? Commitment { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The ID from the investor's rate sheet.
        /// </summary>
        public string? RateSheetId { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Date when the interest rate for the loan was last locked.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? LastRateSetDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// The number of days in the current lock.
        /// </summary>
        public int? LockNumberOfDays { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// The expiration date of the current lock.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? LockExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// The buy side lock day.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? LockDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// The base buy side base rate (as a percentage) for the lock.
        /// </summary>
        public decimal? BaseRate { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Object containing attributes that describe buy side rate lock adjustments.
        /// </summary>
        [AllowNull]
        public IList<LockAdjustment> Adjustments { get => GetList<LockAdjustment>(); set => SetList(value); }

        /// <summary>
        /// The total value of the buy side rate adjustments.
        /// </summary>
        public decimal? TotalRateAdjustments { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The Base Buy Rate plus the total rate adjustments.
        /// </summary>
        public decimal? NetRate { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The Base Buy Price for the lock. Enter pricing using 100 as par. Example 1: If the base price is .25 above par, enter 100.25. A loan amount of $100,000 with pricing of 100.25 would result in $100,250 being received. Example 2: If the base price is .25 below par, enter 99.75. A loan amount of $100,000 with pricing of 99.75 would result in $99,750 being received.
        /// </summary>
        public decimal? BasePrice { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The total value of the buy side price adjustments.
        /// </summary>
        public decimal? TotalPriceAdjustments { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The Base Sell Price plus the Total Price Adjustments.
        /// </summary>
        public decimal? NetPrice { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The buy side base ARM margin for the lock.
        /// </summary>
        public decimal? BaseMarginRate { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Description of the buy side base rate adjustment for the lock.
        /// </summary>
        public decimal? TotalMarginAdjustments { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The Base Buy ARM Margin for the lock plus the Total Buy ARM Margin Adjustments for the lock.
        /// </summary>
        public decimal? NetMarginRate { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Additional notes and comments.
        /// </summary>
        public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Original lock expiration date for the requested rate lock extension.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? OriginalLockExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Service release premium percentage to be paid to the Lender.
        /// </summary>
        public decimal? SrpPaidOut { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Buy side loan program.
        /// </summary>
        public string? LoanProgram { get => GetValue<string?>(); set => SetValue(value); }
    }
}