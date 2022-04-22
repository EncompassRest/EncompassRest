namespace EncompassRest.Loans.v3;

/// <summary>
/// Hud1EsItemize
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Hud1EsItemize : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Itemize Escrow Payment Date [AEA0001]
    /// </summary>
    public string? Date { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Itemize Escrow Payment Balance [AEA0005]
    /// </summary>
    public decimal? EscrowPaymentBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Itemize Escrow Payment Description [AEA0004]
    /// </summary>
    public string? EscrowPaymentDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Itemize Escrow Payment From [AEA0003]
    /// </summary>
    public decimal? EscrowPaymentFrom { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Itemize Escrow Payment To [AEA0002]
    /// </summary>
    public decimal? EscrowPaymentTo { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsItemize Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }
}