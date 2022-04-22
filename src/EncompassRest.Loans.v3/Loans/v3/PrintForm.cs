namespace EncompassRest.Loans.v3;

/// <summary>
/// PrintForm
/// </summary>
public sealed partial class PrintForm : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PrintForm Name
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }
}