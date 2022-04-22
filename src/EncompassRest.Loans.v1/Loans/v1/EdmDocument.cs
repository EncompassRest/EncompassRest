namespace EncompassRest.Loans.v1;

/// <summary>
/// EdmDocument
/// </summary>
public sealed partial class EdmDocument : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// EdmDocument Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EdmDocument Title
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }
}