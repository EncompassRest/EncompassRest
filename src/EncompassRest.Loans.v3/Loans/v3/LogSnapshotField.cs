namespace EncompassRest.Loans.v3;

/// <summary>
/// LogSnapshotField
/// </summary>
public sealed partial class LogSnapshotField : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _fieldId;
    private DirtyValue<string?>? _value;

    /// <summary>
    /// LogSnapshotFieldContract FieldId
    /// </summary>
    public string? FieldId { get => _fieldId; set => SetField(ref _fieldId, value); }

    /// <summary>
    /// LogSnapshotFieldContract Value
    /// </summary>
    public string? Value { get => _value; set => SetField(ref _value, value); }
}