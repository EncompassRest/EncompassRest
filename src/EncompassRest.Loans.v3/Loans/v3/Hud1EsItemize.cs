namespace EncompassRest.Loans.v3;

/// <summary>
/// Hud1EsItemize
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Hud1EsItemize : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _date;
    private DirtyValue<decimal?>? _escrowPaymentBalance;
    private DirtyValue<string?>? _escrowPaymentDescription;
    private DirtyValue<decimal?>? _escrowPaymentFrom;
    private DirtyValue<decimal?>? _escrowPaymentTo;
    private DirtyValue<string?>? _id;

    /// <summary>
    /// Itemize Escrow Payment Date [AEA0001]
    /// </summary>
    public string? Date { get => _date; set => SetField(ref _date, value); }

    /// <summary>
    /// Itemize Escrow Payment Balance [AEA0005]
    /// </summary>
    public decimal? EscrowPaymentBalance { get => _escrowPaymentBalance; set => SetField(ref _escrowPaymentBalance, value); }

    /// <summary>
    /// Itemize Escrow Payment Description [AEA0004]
    /// </summary>
    public string? EscrowPaymentDescription { get => _escrowPaymentDescription; set => SetField(ref _escrowPaymentDescription, value); }

    /// <summary>
    /// Itemize Escrow Payment From [AEA0003]
    /// </summary>
    public decimal? EscrowPaymentFrom { get => _escrowPaymentFrom; set => SetField(ref _escrowPaymentFrom, value); }

    /// <summary>
    /// Itemize Escrow Payment To [AEA0002]
    /// </summary>
    public decimal? EscrowPaymentTo { get => _escrowPaymentTo; set => SetField(ref _escrowPaymentTo, value); }

    /// <summary>
    /// Hud1EsItemizeContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }
}