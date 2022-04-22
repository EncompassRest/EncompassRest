namespace EncompassRest.Loans.v1;

/// <summary>
/// ExportLogServiceType
/// </summary>
public sealed partial class ExportLogServiceType : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// ExportLogServiceType Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ExportLogServiceType Name
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }
}