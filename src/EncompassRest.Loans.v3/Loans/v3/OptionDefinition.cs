namespace EncompassRest.Loans.v3;

/// <summary>
/// OptionDefinition
/// </summary>
public sealed partial class OptionDefinition : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _name;

    /// <summary>
    /// OptionDefinitionContract Name
    /// </summary>
    public string? Name { get => _name; set => SetField(ref _name, value); }
}