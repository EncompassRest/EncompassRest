using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// OrderedDocument
/// </summary>
public sealed partial class OrderedDocument : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// OrderedDocument Application
    /// </summary>
    [AllowNull]
    public ApplicationReference Application { get => GetEntity<ApplicationReference>(); set => SetEntity(value); }

    /// <summary>
    /// OrderedDocument Category
    /// </summary>
    public string? Category { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OrderedDocument DataKey
    /// </summary>
    public string? DataKey { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OrderedDocument DocumentType
    /// </summary>
    public StringEnumValue<OrderedDocumentType> DocumentType { get => GetValue<StringEnumValue<OrderedDocumentType>>(); set => SetValue(value); }

    /// <summary>
    /// OrderedDocument ExternalDocumentId
    /// </summary>
    public string? ExternalDocumentId { get => GetValue<string?>(); set => SetValue(value); }

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
    [AllowNull]
    public EntityReference TemplateId { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// OrderedDocument Title
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }
}