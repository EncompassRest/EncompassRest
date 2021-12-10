using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// TrustAccount
/// </summary>
public sealed partial class TrustAccount : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _balance;
    private DirtyValue<decimal?>? _total1;
    private DirtyValue<decimal?>? _total2;
    private DirtyList<TrustAccountItem>? _trustAccountItems;

    /// <summary>
    /// Trust Acct Balance [TABALANCE]
    /// </summary>
    public decimal? Balance { get => _balance; set => SetField(ref _balance, value); }

    /// <summary>
    /// Trust Acct Pymts Total [TATOTAL1]
    /// </summary>
    public decimal? Total1 { get => _total1; set => SetField(ref _total1, value); }

    /// <summary>
    /// Trust Acct Receipts Total [TATOTAL2]
    /// </summary>
    public decimal? Total2 { get => _total2; set => SetField(ref _total2, value); }

    /// <summary>
    /// TrustAccountContract TrustAccountItems
    /// </summary>
    [AllowNull]
    public IList<TrustAccountItem> TrustAccountItems { get => GetField(ref _trustAccountItems); set => SetField(ref _trustAccountItems, value); }
}