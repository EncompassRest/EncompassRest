using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans.RateLocks.v1
{
    /// <summary>
    /// Rate Lock Comparison
    /// </summary>
    public sealed partial class Comparison : DirtyExtensibleObject
    {
        /// <summary>
        /// Comparison Requested By
        /// </summary>
        public string? RequestedBy { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Object containing information about the investor.
        /// </summary>
        public Investor? Investor { get => GetValue<Investor?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock comparison servicing type.
        /// </summary>
        public string? ServicingType { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The rate lock comparison for the yield spread premium (YSP).
        /// </summary>
        public decimal? DiscountYsp { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The rate lock comparison master contract number.
        /// </summary>
        public string? MasterContractNumber { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock comparison gain loss percentage.
        /// </summary>
        public decimal? GainLossPercentage { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock comparison gain loss price.
        /// </summary>
        public decimal? GainLossPrice { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Rate lock comparison gain loss total price.
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
        /// The number of days for the rate comparison lock.
        /// </summary>
        public int? LockNumberOfDays { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// The date the rate comparison lock expires, calculated by adding the value in the # of Days field to the date in the Lock Date field on the Secondary Lock Tool.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? LockExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// The rate comparison lock date.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? LockDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// The base comparison rate (as a percentage) for the lock.
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
        /// The base margin rate.
        /// </summary>
        public decimal? BaseMarginRate { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The total margin adjustment.
        /// </summary>
        public decimal? TotalMarginAdjustments { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The base net margin rate.
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
        /// Loan program.
        /// </summary>
        public string? LoanProgram { get => GetValue<string?>(); set => SetValue(value); }
    }
}