using System;
using System.Collections.Generic;

namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// BuySide
    /// </summary>
    public sealed partial class BuySide : DirtyExtensibleObject
    {
        private DirtyValue<string?>? _requestedBy;
        private DirtyValue<DateTime?>? _onrpDate;
        private DirtyValue<bool?>? _onrpEligible;
        private DirtyValue<string?>? _commitmentNumber;
        private DirtyValue<string?>? _masterCommitmentNumber;
        private DirtyValue<string?>? _tpoName;
        private DirtyValue<string?>? _tpoId;
        private DirtyValue<string?>? _orgId;
        private DirtyValue<DateTime?>? _commitmentDate;
        private DirtyValue<string?>? _commitmentType;
        private DirtyValue<string?>? _deliveryType;
        private DirtyValue<DateTime?>? _expirationDate;
        private DirtyValue<DateTime?>? _deliveryExpirationDate;
        private DirtyValue<decimal?>? _startingAdjustPrice;
        private DirtyValue<decimal?>? _unDiscountedRate;
        private DirtyValue<decimal?>? _startingAdjPrice;
        private DirtyValue<DateTime?>? _branchApprovalDate;
        private DirtyValue<string?>? _branchApprovedby;
        private DirtyValue<decimal?>? _branchPrice;
        private DirtyValue<DateTime?>? _corporateApprovalDate;
        private DirtyValue<string?>? _corporateApprovedby;
        private DirtyValue<decimal?>? _corporatePrice;
        private DirtyValue<decimal?>? _profitMarginAdjustedBuyPrice;
        private DirtyValue<string?>? _reasonforBranchApproval;
        private DirtyValue<string?>? _reasonforCorporateApproval;
        private DirtyValue<decimal?>? _totalBuyPrice;
        private DirtyValue<decimal?>? _totalPrice;
        private DirtyValue<string?>? _correspondentTradeId;
        private DirtyValue<string?>? _correspondentTradeNumber;
        private DirtyValue<int?>? _daysToExtend;
        private DirtyValue<DateTime?>? _extendedLockExpirationDate;
        private DirtyValue<decimal?>? _lockExtendPriceAdjustment;
        private DirtyValue<string?>? _commitment;
        private DirtyValue<string?>? _rateSheetId;
        private DirtyValue<string?>? _lastRateSetDate;
        private DirtyValue<int?>? _lockNumberOfDays;
        private DirtyValue<string?>? _lockExpirationDate;
        private DirtyValue<string?>? _lockDate;
        private DirtyValue<decimal?>? _baseRate;
        private DirtyValue<List<LockAdjustment>?>? _adjustments;
        private DirtyValue<decimal?>? _netRate;
        private DirtyValue<decimal?>? _totalRateAdjustments;
        private DirtyValue<decimal?>? _basePrice;
        private DirtyValue<decimal?>? _totalPriceAdjustments;
        private DirtyValue<decimal?>? _netPrice;
        private DirtyValue<decimal?>? _baseMarginRate;
        private DirtyValue<decimal?>? _totalMarginAdjustments;
        private DirtyValue<decimal?>? _netMarginRate;
        private DirtyValue<string?>? _comments;
        private DirtyValue<DateTime?>? _originalLockExpirationDate;
        private DirtyValue<decimal?>? _srpPaidOut;
        private DirtyValue<string?>? _loanProgram;

        /// <summary>
        /// The individual who entered the buy side lock and pricing information.
        /// </summary>
        public string? RequestedBy { get => _requestedBy; set => SetField(ref _requestedBy, value); }

        /// <summary>
        /// Lock date for overnight rate protection (ONRP) for an initial lock.
        /// </summary>
        public DateTime? OnrpDate { get => _onrpDate; set => SetField(ref _onrpDate, value); }

        /// <summary>
        /// Indicates whether the loan is eligible for ONRP.
        /// </summary>
        public bool? OnrpEligible { get => _onrpEligible; set => SetField(ref _onrpEligible, value); }

        /// <summary>
        /// Unique identifier for the Correspondent Trade associated with the loan.
        /// </summary>
        public string? CommitmentNumber { get => _commitmentNumber; set => SetField(ref _commitmentNumber, value); }

        /// <summary>
        /// Unique identifier for the Correspondent Master Commitment associated with the loan.
        /// </summary>
        public string? MasterCommitmentNumber { get => _masterCommitmentNumber; set => SetField(ref _masterCommitmentNumber, value); }

        /// <summary>
        /// Rate lock buy side TPO name.
        /// </summary>
        public string? TpoName { get => _tpoName; set => SetField(ref _tpoName, value); }

        /// <summary>
        /// The Site ID for the TPO WebCenter site.
        /// </summary>
        public string? TpoId { get => _tpoId; set => SetField(ref _tpoId, value); }

        /// <summary>
        /// The organization ID of the TPO Company.
        /// </summary>
        public string? orgId { get => _orgId; set => SetField(ref _orgId, value); }

        /// <summary>
        /// The commitment date for the loan.
        /// </summary>
        public DateTime? CommitmentDate { get => _commitmentDate; set => SetField(ref _commitmentDate, value); }

        /// <summary>
        /// The type of Lock applied to the loan. Possible values are: best efforts, mandatory
        /// </summary>
        public string? CommitmentType { get => _commitmentType; set => SetField(ref _commitmentType, value); }

        /// <summary>
        /// Delivery type for the loan request. If the Commitment Type is defined, this field will be automatically populated (“Individual Best Efforts for “Best Efforts Commitment Type and “Individual Mandatory” for “Mandatory” Commitment Type).
        /// </summary>
        public string? DeliveryType { get => _deliveryType; set => SetField(ref _deliveryType, value); }

        /// <summary>
        /// The date the commitment expires.
        /// </summary>
        public DateTime? ExpirationDate { get => _expirationDate; set => SetField(ref _expirationDate, value); }

        /// <summary>
        /// The day the note was drawn on the loan.
        /// </summary>
        public DateTime? DeliveryExpirationDate { get => _deliveryExpirationDate; set => SetField(ref _deliveryExpirationDate, value); }

        /// <summary>
        /// Rate lock buy side starting adjusted rate.
        /// </summary>
        public decimal? StartingAdjustPrice { get => _startingAdjustPrice; set => SetField(ref _startingAdjustPrice, value); }

        /// <summary>
        /// Lock request buy side undiscounted rate.
        /// </summary>
        public decimal? UnDiscountedRate { get => _unDiscountedRate; set => SetField(ref _unDiscountedRate, value); }

        /// <summary>
        /// Rate lock buy side starting adjusted price.
        /// </summary>
        public decimal? StartingAdjPrice { get => _startingAdjPrice; set => SetField(ref _startingAdjPrice, value); }

        /// <summary>
        /// Date when the branch price concession was approved.
        /// </summary>
        public DateTime? BranchApprovalDate { get => _branchApprovalDate; set => SetField(ref _branchApprovalDate, value); }

        /// <summary>
        /// Individual who approved the branch price concession.
        /// </summary>
        public string? BranchApprovedby { get => _branchApprovedby; set => SetField(ref _branchApprovedby, value); }

        /// <summary>
        /// Adjustment amount paid by your branch to offset pricing on a lock to subsize the cost to the borrower.
        /// </summary>
        public decimal? BranchPrice { get => _branchPrice; set => SetField(ref _branchPrice, value); }

        /// <summary>
        /// Date when the corporate price concession was approved.
        /// </summary>
        public DateTime? CorporateApprovalDate { get => _corporateApprovalDate; set => SetField(ref _corporateApprovalDate, value); }

        /// <summary>
        /// Individual who approved the corporate price concession.
        /// </summary>
        public string? CorporateApprovedby { get => _corporateApprovedby; set => SetField(ref _corporateApprovedby, value); }

        /// <summary>
        /// Adjustment amount paid by your company to offset pricing on a lock to subsize the cost to the borrower.
        /// </summary>
        public decimal? CorporatePrice { get => _corporatePrice; set => SetField(ref _corporatePrice, value); }

        /// <summary>
        /// The value of the rate lock buy side profit margin adjustment.
        /// </summary>
        public decimal? ProfitMarginAdjustedBuyPrice { get => _profitMarginAdjustedBuyPrice; set => SetField(ref _profitMarginAdjustedBuyPrice, value); }

        /// <summary>
        /// Description of the reason for approving the branch price concession.
        /// </summary>
        public string? ReasonforBranchApproval { get => _reasonforBranchApproval; set => SetField(ref _reasonforBranchApproval, value); }

        /// <summary>
        /// Description of the reason for approving the company concession.
        /// </summary>
        public string? ReasonforCorporateApproval { get => _reasonforCorporateApproval; set => SetField(ref _reasonforCorporateApproval, value); }

        /// <summary>
        /// Rate lock buy side total buy price.
        /// </summary>
        public decimal? TotalBuyPrice { get => _totalBuyPrice; set => SetField(ref _totalBuyPrice, value); }

        /// <summary>
        /// Rate lock buy side total price.
        /// </summary>
        public decimal? TotalPrice { get => _totalPrice; set => SetField(ref _totalPrice, value); }

        /// <summary>
        /// Unique identifier for the Correspondent Trade associated with the loan.
        /// </summary>
        public string? CorrespondentTradeId { get => _correspondentTradeId; set => SetField(ref _correspondentTradeId, value); }

        /// <summary>
        /// The assigned trade number for the rate lock.
        /// </summary>
        public string? CorrespondentTradeNumber { get => _correspondentTradeNumber; set => SetField(ref _correspondentTradeNumber, value); }

        /// <summary>
        /// Buy side number of additional days for the rate lock extension.
        /// </summary>
        public int? DaysToExtend { get => _daysToExtend; set => SetField(ref _daysToExtend, value); }

        /// <summary>
        /// Buy side expiration date for the requested rate lock extension.
        /// </summary>
        public DateTime? ExtendedLockExpirationDate { get => _extendedLockExpirationDate; set => SetField(ref _extendedLockExpirationDate, value); }

        /// <summary>
        /// Buy side price adjustment for the requested rate lock extension.
        /// </summary>
        public decimal? LockExtendPriceAdjustment { get => _lockExtendPriceAdjustment; set => SetField(ref _lockExtendPriceAdjustment, value); }

        /// <summary>
        /// Unique identifier for the Correspondent Master Commitment associated with the loan.
        /// </summary>
        public string? Commitment { get => _commitment; set => SetField(ref _commitment, value); }

        /// <summary>
        /// The ID from the investor's rate sheet.
        /// </summary>
        public string? RateSheetId { get => _rateSheetId; set => SetField(ref _rateSheetId, value); }

        /// <summary>
        /// Date when the interest rate for the loan was last locked.
        /// </summary>
        public string? LastRateSetDate { get => _lastRateSetDate; set => SetField(ref _lastRateSetDate, value); }

        /// <summary>
        /// The number of days in the current lock.
        /// </summary>
        public int? LockNumberOfDays { get => _lockNumberOfDays; set => SetField(ref _lockNumberOfDays, value); }

        /// <summary>
        /// The expiration date of the current lock.
        /// </summary>
        public string? LockExpirationDate { get => _lockExpirationDate; set => SetField(ref _lockExpirationDate, value); }

        /// <summary>
        /// The buy side lock day.
        /// </summary>
        public string? LockDate { get => _lockDate; set => SetField(ref _lockDate, value); }

        /// <summary>
        /// The base buy side base rate (as a percentage) for the lock.
        /// </summary>
        public decimal? BaseRate { get => _baseRate; set => SetField(ref _baseRate, value); }

        /// <summary>
        /// Object containing attributes that describe buy side rate lock adjustments.
        /// </summary>
        public List<LockAdjustment>? Adjustments { get => _adjustments; set => SetField(ref _adjustments, value); }

        /// <summary>
        /// The total value of the buy side rate adjustments.
        /// </summary>
        public decimal? TotalRateAdjustments { get => _totalRateAdjustments; set => SetField(ref _totalRateAdjustments, value); }

        /// <summary>
        /// The Base Buy Rate plus the total rate adjustments.
        /// </summary>
        public decimal? NetRate { get => _netRate; set => SetField(ref _netRate, value); }

        /// <summary>
        /// The Base Buy Price for the lock. Enter pricing using 100 as par. Example 1: If the base price is .25 above par, enter 100.25. A loan amount of $100,000 with pricing of 100.25 would result in $100,250 being received. Example 2: If the base price is .25 below par, enter 99.75. A loan amount of $100,000 with pricing of 99.75 would result in $99,750 being received.
        /// </summary>
        public decimal? BasePrice { get => _basePrice; set => SetField(ref _basePrice, value); }

        /// <summary>
        /// The total value of the buy side price adjustments.
        /// </summary>
        public decimal? TotalPriceAdjustments { get => _totalPriceAdjustments; set => SetField(ref _totalPriceAdjustments, value); }

        /// <summary>
        /// The Base Sell Price plus the Total Price Adjustments.
        /// </summary>
        public decimal? NetPrice { get => _netPrice; set => SetField(ref _netPrice, value); }

        /// <summary>
        /// The buy side base ARM margin for the lock.
        /// </summary>
        public decimal? BaseMarginRate { get => _baseMarginRate; set => SetField(ref _baseMarginRate, value); }

        /// <summary>
        /// Description of the buy side base rate adjustment for the lock.
        /// </summary>
        public decimal? TotalMarginAdjustments { get => _totalMarginAdjustments; set => SetField(ref _totalMarginAdjustments, value); }

        /// <summary>
        /// The Base Buy ARM Margin for the lock plus the Total Buy ARM Margin Adjustments for the lock.
        /// </summary>
        public decimal? NetMarginRate { get => _netMarginRate; set => SetField(ref _netMarginRate, value); }

        /// <summary>
        /// Additional notes and comments.
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// Original lock expiration date for the requested rate lock extension.
        /// </summary>
        public DateTime? OriginalLockExpirationDate { get => _originalLockExpirationDate; set => SetField(ref _originalLockExpirationDate, value); }

        /// <summary>
        /// Service release premium percentage to be paid to the Lender.
        /// </summary>
        public decimal? SrpPaidOut { get => _srpPaidOut; set => SetField(ref _srpPaidOut, value); }

        /// <summary>
        /// Buy side loan program.
        /// </summary>
        public string? LoanProgram { get => _loanProgram; set => SetField(ref _loanProgram, value); }
    }
}