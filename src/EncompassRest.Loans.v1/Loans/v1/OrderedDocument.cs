using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// OrderedDocument
/// </summary>
public sealed partial class OrderedDocument : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// OrderedDocument Category
    /// </summary>
    public string? Category { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OrderedDocument DataKey
    /// </summary>
    public string? DataKey { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OrderedDocument DocumentServiceId
    /// </summary>
    public string? DocumentServiceId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OrderedDocument Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OrderedDocument OverflowDataKey
    /// </summary>
    public string? OverflowDataKey { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OrderedDocument Overflows
    /// </summary>
    [AllowNull]
    public IList<OrderedDocumentOverflow> Overflows { get => GetList<OrderedDocumentOverflow>(); set => SetList(value); }

    /// <summary>
    /// OrderedDocument PairId
    /// </summary>
    public string? PairId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OrderedDocument SignatureType
    /// </summary>
    public StringEnumValue<OrderedDocumentSignatureType> SignatureType { get => GetValue<StringEnumValue<OrderedDocumentSignatureType>>(); set => SetValue(value); }

    /// <summary>
    /// OrderedDocument Size
    /// </summary>
    public int? Size { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// OrderedDocument TemplateId
    /// </summary>
    public string? TemplateId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OrderedDocument Title
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OrderedDocument Type
    /// </summary>
    public StringEnumValue<OrderedDocumentType> Type { get => GetValue<StringEnumValue<OrderedDocumentType>>(); set => SetValue(value); }
}