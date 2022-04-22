namespace EncompassRest.Loans.v1;

/// <summary>
/// EmailDocument
/// </summary>
public sealed partial class EmailDocument : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// EmailDocument DocId
    /// </summary>
    public string? DocId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EmailDocument DocTitle
    /// </summary>
    public string? DocTitle { get => GetValue<string?>(); set => SetValue(value); }
}