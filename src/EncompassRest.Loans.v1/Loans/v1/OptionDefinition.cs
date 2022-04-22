namespace EncompassRest.Loans.v1;

/// <summary>
/// OptionDefinition
/// </summary>
public sealed partial class OptionDefinition : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// OptionDefinition Name
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }
}