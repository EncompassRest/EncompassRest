namespace EncompassRest.Loans.v3;

/// <summary>
/// Form
/// </summary>
public sealed partial class Form : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Form FormId
    /// </summary>
    public int? FormId { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Form Name
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }
}