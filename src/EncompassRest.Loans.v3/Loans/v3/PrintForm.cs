namespace EncompassRest.Loans.v3;

/// <summary>
/// PrintForm
/// </summary>
public sealed partial class PrintForm : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _name;

    /// <summary>
    /// PrintFormContract Name
    /// </summary>
    public string? Name { get => _name; set => SetField(ref _name, value); }
}