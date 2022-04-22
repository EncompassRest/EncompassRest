namespace EncompassRest.Loans.v3;

/// <summary>
/// EdmDocument
/// </summary>
public sealed partial class EdmDocument : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// EdmDocument Title
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }
}