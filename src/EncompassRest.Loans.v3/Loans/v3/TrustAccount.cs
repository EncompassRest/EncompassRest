using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// TrustAccount
/// </summary>
public sealed partial class TrustAccount : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Trust Acct Balance [TABALANCE]
    /// </summary>
    public decimal? Balance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trust Acct Pymts Total [TATOTAL1]
    /// </summary>
    public decimal? Total1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trust Acct Receipts Total [TATOTAL2]
    /// </summary>
    public decimal? Total2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TrustAccount TrustAccountItems
    /// </summary>
    [AllowNull]
    public IList<TrustAccountItem> TrustAccountItems { get => GetList<TrustAccountItem>(); set => SetList(value); }
}