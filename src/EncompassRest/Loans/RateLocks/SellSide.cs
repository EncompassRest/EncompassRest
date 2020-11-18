using System;
using System.Collections.Generic;

namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// SellSide
    /// </summary>
    public sealed partial class SellSide : DirtyExtensibleObject
    {
        private DirtyValue<string?>? _requestedBy;
        private DirtyValue<decimal?>? _srp;
        private DirtyValue<Investor?>? _investor;
        private DirtyValue<string?>? _servicer;
        private DirtyValue<decimal?>? _servicingFee;
        private DirtyValue<decimal?>? _guarantyBaseFee;
        private DirtyValue<decimal?>? _guaranteeFee;
        private DirtyValue<string?>? _poolNumber;
        private DirtyValue<string?>? _poolId;
        private DirtyValue<string?>? _commitmentContractNumber;
        private DirtyValue<string?>? _productName;
        private DirtyValue<decimal?>? _msrValue;
        private DirtyValue<DateTime?>? _commitmentDate;
        private DirtyValue<decimal?>? _actualAmount;
        private DirtyValue<decimal?>? _actualPrice;
        private DirtyValue<decimal?>? _actualSrp;
        private DirtyValue<decimal?>? _diffAmount;
        private DirtyValue<decimal?>? _diffPrice;
        private DirtyValue<decimal?>? _diffSrp;
        private DirtyValue<decimal?>? _netAmount;
        private DirtyValue<decimal?>? _paidMiPremium;
        private DirtyValue<decimal?>? _correspondentEscrow;
        private DirtyValue<string?>? _tradeMgmtPrevConfirmedLockGuid;
        private DirtyValue<string?>? _tradeId;
        private DirtyValue<string?>? _tradeNumber;
        private DirtyValue<int?>? _daysToExtend;
        private DirtyValue<DateTime?>? _extendedLockExpirationDate;
        private DirtyValue<decimal?>? _lockExtendPriceAdjustment;
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
        /// The individual who entered the sell side lock and pricing information.
        /// </summary>
        public string? RequestedBy { get => _requestedBy; set => SetField(ref _requestedBy, value); }

        /// <summary>
        /// Service release premium percentage (SRP) from investor.
        /// </summary>
        public decimal? Srp { get => _srp; set => SetField(ref _srp, value); }

        /// <summary>
        /// Array containing information about the investor.
        /// </summary>
        public Investor? Investor { get => _investor; set => SetField(ref _investor, value); }

        /// <summary>
        /// Name of the servicer.
        /// </summary>
        public string? Servicer { get => _servicer; set => SetField(ref _servicer, value); }

        /// <summary>
        /// Rate lock sell side servicing fee.
        /// </summary>
        public decimal? ServicingFee { get => _servicingFee; set => SetField(ref _servicingFee, value); }

        /// <summary>
        /// Rate lock sell side guarantee base fee.
        /// </summary>
        public decimal? GuarantyBaseFee { get => _guarantyBaseFee; set => SetField(ref _guarantyBaseFee, value); }

        /// <summary>
        /// Rate lock sell side guarantee fee.
        /// </summary>
        public decimal? GuaranteeFee { get => _guaranteeFee; set => SetField(ref _guaranteeFee, value); }

        /// <summary>
        /// The pool number assigned by the investor.
        /// </summary>
        public string? PoolNumber { get => _poolNumber; set => SetField(ref _poolNumber, value); }

        /// <summary>
        /// Unique identifier for a group or pool of loans.
        /// </summary>
        public string? PoolId { get => _poolId; set => SetField(ref _poolId, value); }

        /// <summary>
        /// The commitment contract number.
        /// </summary>
        public string? CommitmentContractNumber { get => _commitmentContractNumber; set => SetField(ref _commitmentContractNumber, value); }

        /// <summary>
        /// Rate lock sell side product name.
        /// </summary>
        public string? ProductName { get => _productName; set => SetField(ref _productName, value); }

        /// <summary>
        /// Mortgage servicing rights (MSR) value.
        /// </summary>
        public decimal? MsrValue { get => _msrValue; set => SetField(ref _msrValue, value); }

        /// <summary>
        /// Rate lock sell side commitment date.
        /// </summary>
        public DateTime? CommitmentDate { get => _commitmentDate; set => SetField(ref _commitmentDate, value); }

        /// <summary>
        /// Rate lock sell side actual amount.
        /// </summary>
        public decimal? ActualAmount { get => _actualAmount; set => SetField(ref _actualAmount, value); }

        /// <summary>
        /// Rate lock sell side actual price.
        /// </summary>
        public decimal? ActualPrice { get => _actualPrice; set => SetField(ref _actualPrice, value); }

        /// <summary>
        /// The service release premium (SRP) from the Sell Side on the Secondary Registration tool.
        /// </summary>
        public decimal? ActualSrp { get => _actualSrp; set => SetField(ref _actualSrp, value); }

        /// <summary>
        /// Rate lock sell side different amount.
        /// </summary>
        public decimal? DiffAmount { get => _diffAmount; set => SetField(ref _diffAmount, value); }

        /// <summary>
        /// Rate lock sell side different price.
        /// </summary>
        public decimal? DiffPrice { get => _diffPrice; set => SetField(ref _diffPrice, value); }

        /// <summary>
        /// Rate lock sell side different SRP.
        /// </summary>
        public decimal? DiffSrp { get => _diffSrp; set => SetField(ref _diffSrp, value); }

        /// <summary>
        /// The Base Sell Price plus the Total Price Adjustments.
        /// </summary>
        public decimal? NetAmount { get => _netAmount; set => SetField(ref _netAmount, value); }

        /// <summary>
        /// Rate lock sell side paid MI premium.
        /// </summary>
        public decimal? PaidMiPremium { get => _paidMiPremium; set => SetField(ref _paidMiPremium, value); }

        /// <summary>
        /// Correspondent escrow disbursements to be paid by the seller.
        /// </summary>
        public decimal? CorrespondentEscrow { get => _correspondentEscrow; set => SetField(ref _correspondentEscrow, value); }

        /// <summary>
        /// TradeMgmtPrevConfirmedLockGuid
        /// </summary>
        public string? TradeMgmtPrevConfirmedLockGuid { get => _tradeMgmtPrevConfirmedLockGuid; set => SetField(ref _tradeMgmtPrevConfirmedLockGuid, value); }

        /// <summary>
        /// Rate lock sell side trade ID.
        /// </summary>
        public string? TradeId { get => _tradeId; set => SetField(ref _tradeId, value); }

        /// <summary>
        /// Rate lock sell side trade number.
        /// </summary>
        public string? TradeNumber { get => _tradeNumber; set => SetField(ref _tradeNumber, value); }

        /// <summary>
        /// Sell side number of additional days for the rate lock extension.
        /// </summary>
        public int? DaysToExtend { get => _daysToExtend; set => SetField(ref _daysToExtend, value); }

        /// <summary>
        /// Sell side expiration date for the requested rate lock extension.
        /// </summary>
        public DateTime? ExtendedLockExpirationDate { get => _extendedLockExpirationDate; set => SetField(ref _extendedLockExpirationDate, value); }

        /// <summary>
        /// Sell side price adjustment for the requested rate lock extension.
        /// </summary>
        public decimal? LockExtendPriceAdjustment { get => _lockExtendPriceAdjustment; set => SetField(ref _lockExtendPriceAdjustment, value); }

        /// <summary>
        /// Rate lock sell side servicing type.
        /// </summary>
        public string? ServicingType { get => _servicingType; set => SetField(ref _servicingType, value); }

        /// <summary>
        /// The discount yield spread premium
        /// </summary>
        public decimal? DiscountYsp { get => _discountYsp; set => SetField(ref _discountYsp, value); }

        /// <summary>
        /// The master contract number.
        /// </summary>
        public string? masterContractNumber { get => _masterContractNumber; set => SetField(ref _masterContractNumber, value); }

        /// <summary>
        /// Rate lock sell side gain loss percentage.
        /// </summary>
        public decimal? GainLossPercentage { get => _gainLossPercentage; set => SetField(ref _gainLossPercentage, value); }

        /// <summary>
        /// Rate lock sell side gain loss price.
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