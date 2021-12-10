using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// OrderedDocument
/// </summary>
public sealed partial class OrderedDocument : DirtyExtensibleObject, IIdentifiable
{
    private ApplicationReference? _application;
    private DirtyValue<string?>? _category;
    private DirtyValue<string?>? _dataKey;
    private DirtyValue<StringEnumValue<OrderedDocumentType>>? _documentType;
    private DirtyValue<string?>? _externalDocumentId;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _overflowDataKey;
    private DirtyList<OrderedDocumentOverflow>? _overflows;
    private DirtyValue<StringEnumValue<OrderedDocumentSignatureType>>? _signatureType;
    private DirtyValue<int?>? _size;
    private EntityReference? _templateId;
    private DirtyValue<string?>? _title;

    /// <summary>
    /// OrderedDocumentContract Application
    /// </summary>
    [AllowNull]
    public ApplicationReference Application { get => GetField(ref _application); set => SetField(ref _application, value); }

    /// <summary>
    /// OrderedDocumentContract Category
    /// </summary>
    public string? Category { get => _category; set => SetField(ref _category, value); }

    /// <summary>
    /// OrderedDocumentContract DataKey
    /// </summary>
    public string? DataKey { get => _dataKey; set => SetField(ref _dataKey, value); }

    /// <summary>
    /// OrderedDocumentContract DocumentType
    /// </summary>
    public StringEnumValue<OrderedDocumentType> DocumentType { get => _documentType; set => SetField(ref _documentType, value); }

    /// <summary>
    /// OrderedDocumentContract ExternalDocumentId
    /// </summary>
    public string? ExternalDocumentId { get => _externalDocumentId; set => SetField(ref _externalDocumentId, value); }

    /// <summary>
    /// OrderedDocumentContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// OrderedDocumentContract OverflowDataKey
    /// </summary>
    public string? OverflowDataKey { get => _overflowDataKey; set => SetField(ref _overflowDataKey, value); }

    /// <summary>
    /// OrderedDocumentContract Overflows
    /// </summary>
    [AllowNull]
    public IList<OrderedDocumentOverflow> Overflows { get => GetField(ref _overflows); set => SetField(ref _overflows, value); }

    /// <summary>
    /// OrderedDocumentContract SignatureType
    /// </summary>
    public StringEnumValue<OrderedDocumentSignatureType> SignatureType { get => _signatureType; set => SetField(ref _signatureType, value); }

    /// <summary>
    /// OrderedDocumentContract Size
    /// </summary>
    public int? Size { get => _size; set => SetField(ref _size, value); }

    /// <summary>
    /// OrderedDocumentContract TemplateId
    /// </summary>
    [AllowNull]
    public EntityReference TemplateId { get => GetField(ref _templateId); set => SetField(ref _templateId, value); }

    /// <summary>
    /// OrderedDocumentContract Title
    /// </summary>
    public string? Title { get => _title; set => SetField(ref _title, value); }
}