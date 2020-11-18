using System;
using System.Collections.Generic;

namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// Rate Lock Comparison
    /// </summary>
    public sealed partial class Comparison : DirtyExtensibleObject
    {
        private DirtyValue<string?>? _requestedBy;
        private DirtyValue<Investor?>? _investor;
        private DirtyValue<string?>? _servicingType;
        private DirtyValue<decimal?>? _discountYsp;
        private DirtyValue<string?>? _masterContractNumber;
        private DirtyValue<decimal?>? _gainLossPercentage;
        private DirtyValue<decimal?>? _gainLossPrice;
        private DirtyValue<decimal?>? _gainLossTotalPrice;
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
        private DirtyValue<decimal?>? _netMarginRate;
        private DirtyValue<string?>? _comments;
        private DirtyValue<DateTime?>? _originalLockExpirationDate;
        private DirtyValue<decimal?>? _srpPaidOut;
        private DirtyValue<string?>? _loanProgram;

        /// <summary>
        /// 
        /// </summary>
        public string? RequestedBy { get => _requestedBy; set => SetField(ref _requestedBy, value); }

        /// <summary>
        /// 
        /// </summary>
        public Investor? Investor { get => _investor; set => SetField(ref _investor, value); }

        /// <summary>
        /// 
        /// </summary>
        public string? ServicingType { get => _servicingType; set => SetField(ref _servicingType, value); }

        /// <summary>
        /// 
        /// </summary>
        public decimal? DiscountYsp { get => _discountYsp; set => SetField(ref _discountYsp, value); }

        /// <summary>
        /// 
        /// </summary>
        public string? MasterContractNumber { get => _masterContractNumber; set => SetField(ref _masterContractNumber, value); }

        /// <summary>
        /// 
        /// </summary>
        public decimal? GainLossPercentage { get => _gainLossPercentage; set => SetField(ref _gainLossPercentage, value); }

        /// <summary>
        /// 
        /// </summary>
        public decimal? GainLossPrice { get => _gainLossPrice; set => SetField(ref _gainLossPrice, value); }

        /// <summary>
        /// Rate lock sell side gain loss total price.
        /// </summary>
        public decimal? GainLossTotalPrice { get => _gainLossTotalPrice; set => SetField(ref _gainLossTotalPrice, value); }

        /// <summary>
        /// The ID from the investor's rate sheet.
        /// </summary>
        public string? RateSheetId { get => _rateSheetId; set => SetField(ref _rateSheetId, value); }

        /// <summary>
        /// Date when the interest rate for the loan was last locked.
        /// </summary>
        public string? LastRateSetDate { get => _lastRateSetDate; set => SetField(ref _lastRateSetDate, value); }

        /// <summary>
        /// The number of days for the sell side lock.
        /// </summary>
        public int? LockNumberOfDays { get => _lockNumberOfDays; set => SetField(ref _lockNumberOfDays, value); }

        /// <summary>
        /// The date the sell side rate lock expires, calculated by adding the value in the # of Days field to the date in the Lock Date field on the Secondary Lock Tool.
        /// </summary>
        public string? LockExpirationDate { get => _lockExpirationDate; set => SetField(ref _lockExpirationDate, value); }

        /// <summary>
        /// The sell side lock date.
        /// </summary>
        public string? LockDate { get => _lockDate; set => SetField(ref _lockDate, value); }

        /// <summary>
        /// The base sell side rate (as a percentage) for the lock. The rate is populated from the Sell Side Lock and Pricing column on the Secondary Lock Tool.
        /// </summary>
        public decimal? BaseRate { get => _baseRate; set => SetField(ref _baseRate, value); }

        /// <summary>
        /// Object containing attributes that describe sell side rate lock adjustments.
        /// </summary>
        public List<LockAdjustment>? Adjustments { get => _adjustments; set => SetField(ref _adjustments, value); }

        /// <summary>
        /// The total value of the sell side rate adjustments.
        /// </summary>
        public decimal? TotalRateAdjustments { get => _totalRateAdjustments; set => SetField(ref _totalRateAdjustments, value); }

        /// <summary>
        /// The base sell side rate plus the total rate adjustments.
        /// </summary>
        public decimal? NetRate { get => _netRate; set => SetField(ref _netRate, value); }

        /// <summary>
        /// The base sell side price for the lock. Enter pricing using 100 as par. Example 1: If the base price is .25 above par, enter 100.25. A loan amount of $100,000 with pricing of 100.25 would result in $100,250 being received. Example 2: If the base price is .25 below par, enter 99.75. A loan amount of $100,000 with pricing of 99.75 would result in $99,750 being received.
        /// </summary>
        public decimal? BasePrice { get => _basePrice; set => SetField(ref _basePrice, value); }

        /// <summary>
        /// The total value of the sell side price adjustments.
        /// </summary>
        public decimal? TotalPriceAdjustments { get => _totalPriceAdjustments; set => SetField(ref _totalPriceAdjustments, value); }

        /// <summary>
        /// The base sell side price plus the total rate adjustments.
        /// </summary>
        public decimal? NetPrice { get => _netPrice; set => SetField(ref _netPrice, value); }

        /// <summary>
        /// The sell side base margin rate.
        /// </summary>
        public decimal? BaseMarginRate { get => _baseMarginRate; set => SetField(ref _baseMarginRate, value); }

        /// <summary>
        /// The base sell side net margin rate.
        /// </summary>
        public decimal? NetMarginRate { get => _netMarginRate; set => SetField(ref _netMarginRate, value); }

        /// <summary>
        /// Additional notes and comments.
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// Original lock expiration date.
        /// </summary>
        public DateTime? OriginalLockExpirationDate { get => _originalLockExpirationDate; set => SetField(ref _originalLockExpirationDate, value); }

        /// <summary>
        /// Service release premium percentage (SRP) paid out.
        /// </summary>
        public decimal? SrpPaidOut { get => _srpPaidOut; set => SetField(ref _srpPaidOut, value); }

        /// <summary>
        /// Sell side loan program.
        /// </summary>
        public string? LoanProgram { get => _loanProgram; set => SetField(ref _loanProgram, value); }
    }
}