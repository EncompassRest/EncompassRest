using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// TrustAccountItem
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class TrustAccountItem : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Trust Acct Trans Descr Date [TA00DT]
    /// </summary>
    public DateTime? Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Trust Acct Trans Descr [TA00DS]
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TrustAccountItem Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trust Acct Trans Descr Notes [TA00NO]
    /// </summary>
    public string? Notes { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trust Acct Trans Descr Pymt Amt [TA00PA]
    /// </summary>
    public decimal? PaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trust Acct Trans Descr Pymt Check [TA00PC]
    /// </summary>
    public string? PaymentCheckNo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trust Acct Trans Descr Receipt Amt [TA00RA]
    /// </summary>
    public decimal? ReceiptAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trust Acct Trans Descr Receipt Check [TA00RC]
    /// </summary>
    public string? ReceiptCheckNo { get => GetValue<string?>(); set => SetValue(value); }
}