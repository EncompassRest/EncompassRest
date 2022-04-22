namespace EncompassRest.Loans.v3;

/// <summary>
/// LogSnapshotField
/// </summary>
public sealed partial class LogSnapshotField : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LogSnapshotField FieldId
    /// </summary>
    public string? FieldId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LogSnapshotField Value
    /// </summary>
    public string? Value { get => GetValue<string?>(); set => SetValue(value); }
}