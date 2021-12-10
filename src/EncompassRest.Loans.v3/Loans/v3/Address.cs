namespace EncompassRest.Loans.v3;

/// <summary>
/// Address
/// </summary>
public sealed partial class Address : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _city;
    private DirtyValue<string?>? _state;
    private DirtyValue<string?>? _street1;
    private DirtyValue<string?>? _street2;
    private DirtyValue<string?>? _zip;

    /// <summary>
    /// AddressContract City
    /// </summary>
    public string? City { get => _city; set => SetField(ref _city, value); }

    /// <summary>
    /// AddressContract State
    /// </summary>
    public string? State { get => _state; set => SetField(ref _state, value); }

    /// <summary>
    /// AddressContract Street1
    /// </summary>
    public string? Street1 { get => _street1; set => SetField(ref _street1, value); }

    /// <summary>
    /// AddressContract Street2
    /// </summary>
    public string? Street2 { get => _street2; set => SetField(ref _street2, value); }

    /// <summary>
    /// AddressContract Zip
    /// </summary>
    public string? Zip { get => _zip; set => SetField(ref _zip, value); }
}