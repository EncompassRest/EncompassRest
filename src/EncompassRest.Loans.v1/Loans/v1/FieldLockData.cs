namespace EncompassRest.Loans.v1;

/// <summary>
/// FieldLockData
/// </summary>
public sealed partial class FieldLockData : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// FieldLockData LockRemoved
    /// </summary>
    public bool? LockRemoved { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// FieldLockData ModelPath
    /// </summary>
    public string? ModelPath { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FieldLockData Value
    /// </summary>
    public string? Value { get => GetValue<string?>(); set => SetValue(value); }
}