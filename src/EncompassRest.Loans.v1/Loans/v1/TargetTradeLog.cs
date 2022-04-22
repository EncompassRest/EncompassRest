using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// TargetTradeLog
/// </summary>
public sealed partial class TargetTradeLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// TargetTradeLog BasePrice
    /// </summary>
    public decimal? BasePrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TargetTradeLog CommitmentID
    /// </summary>
    public string? CommitmentID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TargetTradeLog Date
    /// </summary>
    public DateTime? Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TargetTradeLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TargetTradeLog PriceAdjustmentLogRecord
    /// </summary>
    [AllowNull]
    public IList<PriceAdjustmentLogRecord> PriceAdjustmentLogRecord { get => GetList<PriceAdjustmentLogRecord>(); set => SetList(value); }

    /// <summary>
    /// TargetTradeLog SRPPaidOut
    /// </summary>
    public decimal? SRPPaidOut { get => GetValue<decimal?>(); set => SetValue(value); }
}