using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans.RateLocks.v1
{
    /// <summary>
    /// SellSide
    /// </summary>
    public sealed partial class SellSide : DirtyExtensibleObject
    {
        /// <summary>
        /// The individual who entered the sell side lock and pricing information.
        /// </summary>
        public string? RequestedBy { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Service release premium percentage (SRP) from investor.
        /// </summary>
        public decimal? Srp { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Array containing information about the investor.
        /// </summary>
        public Investor? Investor { get => GetValue<Investor?>(); set => SetValue(value); }

        /// <summary>
        /// Name of the servicer.
        /// </summary>
        public string? Servicer { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock sell side servicing fee.
        /// </summary>
        public decimal? ServicingFee { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock sell side guarantee base fee.
        /// </summary>
        public decimal? GuarantyBaseFee { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock sell side guarantee fee.
        /// </summary>
        public decimal? GuaranteeFee { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The pool number assigned by the investor.
        /// </summary>
        public string? PoolNumber { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Unique identifier for a group or pool of loans.
        /// </summary>
        public string? PoolId { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The commitment contract number.
        /// </summary>
        public string? CommitmentContractNumber { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock sell side product name.
        /// </summary>
        public string? ProductName { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Mortgage servicing rights (MSR) value.
        /// </summary>
        public decimal? MsrValue { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock sell side commitment date.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? CommitmentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock sell side actual amount.
        /// </summary>
        public decimal? ActualAmount { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock sell side actual price.
        /// </summary>
        public decimal? ActualPrice { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The service release premium (SRP) from the Sell Side on the Secondary Registration tool.
        /// </summary>
        public decimal? ActualSrp { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock sell side different amount.
        /// </summary>
        public decimal? DiffAmount { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock sell side different price.
        /// </summary>
        public decimal? DiffPrice { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock sell side different SRP.
        /// </summary>
        public decimal? DiffSrp { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The Base Sell Price plus the Total Price Adjustments.
        /// </summary>
        public decimal? NetAmount { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock sell side paid MI premium.
        /// </summary>
        public decimal? PaidMiPremium { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Correspondent escrow disbursements to be paid by the seller.
        /// </summary>
        public decimal? CorrespondentEscrowDisbursementsToBePaid { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// TradeMgmtPrevConfirmedLockGuid
        /// </summary>
        public string? TradeMgmtPrevConfirmedLockGuid { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock sell side trade ID.
        /// </summary>
        public string? TradeId { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock sell side trade number.
        /// </summary>
        public string? TradeNumber { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Sell side number of additional days for the rate lock extension.
        /// </summary>
        public int? DaysToExtend { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// Sell side expiration date for the requested rate lock extension.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? ExtendedLockExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Sell side price adjustment for the requested rate lock extension.
        /// </summary>
        public decimal? LockExtendPriceAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock sell side servicing type.
        /// </summary>
        public StringEnumValue<ServicingType> ServicingType { get => GetValue<StringEnumValue<ServicingType>>(); set => SetValue(value); }

        /// <summary>
        /// The discount yield spread premium
        /// </summary>
        public decimal? DiscountYsp { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The master contract number.
        /// </summary>
        public string? MasterContractNumber { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock sell side gain loss percentage.
        /// </summary>
        public decimal? GainLossPercentage { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock sell side gain loss price.
        /// </summary>
        public decimal? GainLossPrice { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock sell side gain loss total price.
        /// </summary>
        public decimal? GainLossTotalPrice { get => GetValue<decimal?>(); set => SetValue(value); }

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
        /// The number of days for the sell side lock.
        /// </summary>
        public int? LockNumberOfDays { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// The date the sell side rate lock expires, calculated by adding the value in the # of Days field to the date in the Lock Date field on the Secondary Lock Tool.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? LockExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// The sell side lock date.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? LockDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// The base sell side rate (as a percentage) for the lock. The rate is populated from the Sell Side Lock and Pricing column on the Secondary Lock Tool.
        /// </summary>
        public decimal? BaseRate { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Object containing attributes that describe sell side rate lock adjustments.
        /// </summary>
        [AllowNull]
        public IList<LockAdjustment> Adjustments { get => GetList<LockAdjustment>(); set => SetList(value); }

        /// <summary>
        /// The total value of the sell side rate adjustments.
        /// </summary>
        public decimal? TotalRateAdjustments { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The base sell side rate plus the total rate adjustments.
        /// </summary>
        public decimal? NetRate { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The base sell side price for the lock. Enter pricing using 100 as par. Example 1: If the base price is .25 above par, enter 100.25. A loan amount of $100,000 with pricing of 100.25 would result in $100,250 being received. Example 2: If the base price is .25 below par, enter 99.75. A loan amount of $100,000 with pricing of 99.75 would result in $99,750 being received.
        /// </summary>
        public decimal? BasePrice { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The total value of the sell side price adjustments.
        /// </summary>
        public decimal? TotalPriceAdjustments { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The base sell side price plus the total rate adjustments.
        /// </summary>
        public decimal? NetPrice { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The sell side base margin rate.
        /// </summary>
        public decimal? BaseMarginRate { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The sell side total margin adjustment.
        /// </summary>
        public decimal? TotalMarginAdjustments { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The base sell side net margin rate.
        /// </summary>
        public decimal? NetMarginRate { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Additional notes and comments.
        /// </summary>
        public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Original lock expiration date.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? OriginalLockExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Service release premium percentage (SRP) paid out.
        /// </summary>
        public decimal? SrpPaidOut { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Sell side loan program.
        /// </summary>
        public string? LoanProgram { get => GetValue<string?>(); set => SetValue(value); }
    }
}