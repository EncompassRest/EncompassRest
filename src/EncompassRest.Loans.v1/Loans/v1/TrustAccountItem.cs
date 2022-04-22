using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// TrustAccountItem
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class TrustAccountItem : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Trust Acct Trans Descr Date [TANNDT]
    /// </summary>
    public DateTime? Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Trust Acct Trans Descr [TANNDS]
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TrustAccountItem Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trust Acct Trans Descr Notes [TANNNO]
    /// </summary>
    public string? Notes { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trust Acct Trans Descr Pymt Amt [TANNPA]
    /// </summary>
    public decimal? PaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trust Acct Trans Descr Pymt Check [TANNPC]
    /// </summary>
    public string? PaymentCheckNo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trust Acct Trans Descr Receipt Amt [TANNRA]
    /// </summary>
    public decimal? ReceiptAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trust Acct Trans Descr Receipt Check [TANNRC]
    /// </summary>
    public string? ReceiptCheckNo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TrustAccountItem TrustAccountItemIndex
    /// </summary>
    public int? TrustAccountItemIndex { get => GetValue<int?>(); set => SetValue(value); }
}