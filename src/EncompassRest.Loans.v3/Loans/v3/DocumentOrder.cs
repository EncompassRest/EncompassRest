using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// DocumentOrder
/// </summary>
public sealed partial class DocumentOrder : DirtyExtensibleObject, IIdentifiable
{
    private EntityReference? _createdBy;
    private DirtyValue<DateTime?>? _createdDate;
    private DocumentAudit? _documentAudit;
    private DirtyValue<object?>? _documentFields;
    private DirtyList<OrderedDocument>? _documents;
    private DirtyValue<string?>? _id;
    private DirtyValue<DateTime?>? _lastModifiedDate;
    private DirtyValue<string?>? _orderId;
    private DirtyValue<StringEnumValue<OrderType>>? _orderType;

    /// <summary>
    /// DocumentOrderContract CreatedBy
    /// </summary>
    [AllowNull]
    public EntityReference CreatedBy { get => GetField(ref _createdBy); set => SetField(ref _createdBy, value); }

    /// <summary>
    /// DocumentOrderContract CreatedDate
    /// </summary>
    public DateTime? CreatedDate { get => _createdDate; set => SetField(ref _createdDate, value); }

    /// <summary>
    /// DocumentOrderContract DocumentAudit
    /// </summary>
    [AllowNull]
    public DocumentAudit DocumentAudit { get => GetField(ref _documentAudit); set => SetField(ref _documentAudit, value); }

    /// <summary>
    /// DocumentOrderContract DocumentFields
    /// </summary>
    public object? DocumentFields { get => _documentFields; set => SetField(ref _documentFields, value); }

    /// <summary>
    /// DocumentOrderContract Documents
    /// </summary>
    [AllowNull]
    public IList<OrderedDocument> Documents { get => GetField(ref _documents); set => SetField(ref _documents, value); }

    /// <summary>
    /// DocumentOrderContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// DocumentOrderContract LastModifiedDate
    /// </summary>
    public DateTime? LastModifiedDate { get => _lastModifiedDate; set => SetField(ref _lastModifiedDate, value); }

    /// <summary>
    /// DocumentOrderContract OrderId
    /// </summary>
    public string? OrderId { get => _orderId; set => SetField(ref _orderId, value); }

    /// <summary>
    /// DocumentOrderContract OrderType
    /// </summary>
    public StringEnumValue<OrderType> OrderType { get => _orderType; set => SetField(ref _orderType, value); }
}