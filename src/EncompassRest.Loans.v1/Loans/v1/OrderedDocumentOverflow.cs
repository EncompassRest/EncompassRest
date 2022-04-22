namespace EncompassRest.Loans.v1;

/// <summary>
/// OrderedDocumentOverflow
/// </summary>
public sealed partial class OrderedDocumentOverflow : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// OrderedDocumentOverflow CoordinateBottom
    /// </summary>
    public string? CoordinateBottom { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OrderedDocumentOverflow CoordinateLeft
    /// </summary>
    public string? CoordinateLeft { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OrderedDocumentOverflow CoordinateRight
    /// </summary>
    public string? CoordinateRight { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OrderedDocumentOverflow CoordinateTop
    /// </summary>
    public string? CoordinateTop { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OrderedDocumentOverflow OriginalText
    /// </summary>
    public string? OriginalText { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OrderedDocumentOverflow PageNumber
    /// </summary>
    public int? PageNumber { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// OrderedDocumentOverflow TemplateFieldName
    /// </summary>
    public string? TemplateFieldName { get => GetValue<string?>(); set => SetValue(value); }
}