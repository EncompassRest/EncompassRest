namespace EncompassRest.Loans.v3;

/// <summary>
/// ServiceProviderContactFee
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class ServiceProviderContactFee : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// ServiceProviderContactFee Amount
    /// </summary>
    public decimal? Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ServiceProviderContactFee Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ServiceProviderContactFee ItemNumber
    /// </summary>
    public int? ItemNumber { get => GetValue<int?>(); set => SetValue(value); }
}