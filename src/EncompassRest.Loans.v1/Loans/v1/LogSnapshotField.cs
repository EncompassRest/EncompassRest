namespace EncompassRest.Loans.v1;

/// <summary>
/// LogSnapshotField
/// </summary>
public sealed partial class LogSnapshotField : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LogSnapshotField FieldID
    /// </summary>
    public string? FieldID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LogSnapshotField Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LogSnapshotField ModalPath
    /// </summary>
    public string? ModalPath { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LogSnapshotField Value
    /// </summary>
    public string? Value { get => GetValue<string?>(); set => SetValue(value); }
}