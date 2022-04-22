namespace EncompassRest.Loans.v1;

/// <summary>
/// PrintForm
/// </summary>
public sealed partial class PrintForm : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PrintForm Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrintForm Name
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }
}