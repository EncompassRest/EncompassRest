namespace EncompassRest.Loans.v3;

/// <summary>
/// Address
/// </summary>
public sealed partial class Address : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Address City
    /// </summary>
    public string? City { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Address State
    /// </summary>
    public string? State { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Address Street1
    /// </summary>
    public string? Street1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Address Street2
    /// </summary>
    public string? Street2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Address Zip
    /// </summary>
    public string? Zip { get => GetValue<string?>(); set => SetValue(value); }
}