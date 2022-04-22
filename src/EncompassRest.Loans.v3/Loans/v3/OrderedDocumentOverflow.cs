using System.Diagnostics.CodeAnalysis;
namespace EncompassRest.Loans.v3;

/// <summary>
/// OrderedDocumentOverflow
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(OriginalText))]
public sealed partial class OrderedDocumentOverflow : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// OrderedDocumentOverflow FieldName
    /// </summary>
    public string? FieldName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OrderedDocumentOverflow Location
    /// </summary>
    [AllowNull]
    public LocationCoordinates Location { get => GetEntity<LocationCoordinates>(); set => SetEntity(value); }

    /// <summary>
    /// OrderedDocumentOverflow OriginalText
    /// </summary>
    public string? OriginalText { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OrderedDocumentOverflow PageNumber
    /// </summary>
    public int? PageNumber { get => GetValue<int?>(); set => SetValue(value); }
}