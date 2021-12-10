namespace EncompassRest.Loans.v3;

/// <summary>
/// EdmDocument
/// </summary>
public sealed partial class EdmDocument : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _title;

    /// <summary>
    /// EdmDocumentContract Title
    /// </summary>
    public string? Title { get => _title; set => SetField(ref _title, value); }
}