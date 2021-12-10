namespace EncompassRest.Loans.v3;

/// <summary>
/// Form
/// </summary>
public sealed partial class Form : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<int?>? _formId;
    private DirtyValue<string?>? _name;

    /// <summary>
    /// FormContract FormId
    /// </summary>
    public int? FormId { get => _formId; set => SetField(ref _formId, value); }

    /// <summary>
    /// FormContract Name
    /// </summary>
    public string? Name { get => _name; set => SetField(ref _name, value); }
}