using System.Diagnostics.CodeAnalysis;
namespace EncompassRest.Loans.v3;

/// <summary>
/// OrderedDocumentOverflow
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(OriginalText))]
public sealed partial class OrderedDocumentOverflow : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _fieldName;
    private LocationCoordinates? _location;
    private DirtyValue<string?>? _originalText;
    private DirtyValue<int?>? _pageNumber;

    /// <summary>
    /// OrderedDocumentOverflowContract FieldName
    /// </summary>
    public string? FieldName { get => _fieldName; set => SetField(ref _fieldName, value); }

    /// <summary>
    /// OrderedDocumentOverflowContract Location
    /// </summary>
    [AllowNull]
    public LocationCoordinates Location { get => GetField(ref _location); set => SetField(ref _location, value); }

    /// <summary>
    /// OrderedDocumentOverflowContract OriginalText
    /// </summary>
    public string? OriginalText { get => _originalText; set => SetField(ref _originalText, value); }

    /// <summary>
    /// OrderedDocumentOverflowContract PageNumber
    /// </summary>
    public int? PageNumber { get => _pageNumber; set => SetField(ref _pageNumber, value); }
}