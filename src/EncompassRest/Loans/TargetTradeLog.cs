using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans
{
    /// <summary>
    /// TargetTradeLog
    /// </summary>
    public sealed partial class TargetTradeLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?>? _basePrice;
        private DirtyValue<string?>? _commitmentID;
        private DirtyValue<DateTime?>? _date;
        private DirtyValue<string?>? _id;
        private DirtyList<PriceAdjustmentLogRecord>? _priceAdjustmentLogRecord;
        private DirtyValue<decimal?>? _sRPPaidOut;

        /// <summary>
        /// TargetTradeLog BasePrice
        /// </summary>
        public decimal? BasePrice { get => _basePrice; set => SetField(ref _basePrice, value); }

        /// <summary>
        /// TargetTradeLog CommitmentID
        /// </summary>
        public string? CommitmentID { get => _commitmentID; set => SetField(ref _commitmentID, value); }

        /// <summary>
        /// TargetTradeLog Date
        /// </summary>
        public DateTime? Date { get => _date; set => SetField(ref _date, value); }

        /// <summary>
        /// TargetTradeLog Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// TargetTradeLog PriceAdjustmentLogRecord
        /// </summary>
        [AllowNull]
        public IList<PriceAdjustmentLogRecord> PriceAdjustmentLogRecord { get => GetField(ref _priceAdjustmentLogRecord); set => SetField(ref _priceAdjustmentLogRecord, value); }

        /// <summary>
        /// TargetTradeLog SRPPaidOut
        /// </summary>
        public decimal? SRPPaidOut { get => _sRPPaidOut; set => SetField(ref _sRPPaidOut, value); }
    }
}