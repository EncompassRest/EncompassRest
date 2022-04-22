namespace EncompassRest.Loans.v1;

/// <summary>
/// Hud1EsItemize
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Hud1EsItemize : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Itemize Escrow Payment Date [AEANN01]
    /// </summary>
    public string? Date { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Itemize Escrow Payment Balance [AEANN05]
    /// </summary>
    public decimal? EscrowPaymentBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Itemize Escrow Payment Description [AEANN04]
    /// </summary>
    public string? EscrowPaymentDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Itemize Escrow Payment From [AEANN03]
    /// </summary>
    public decimal? EscrowPaymentFrom { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Itemize Escrow Payment To [AEANN02]
    /// </summary>
    public decimal? EscrowPaymentTo { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsItemize Hud1EsItemizeIndex
    /// </summary>
    public int? Hud1EsItemizeIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsItemize Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }
}