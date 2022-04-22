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
    /// <summary>
    /// DocumentOrder CreatedBy
    /// </summary>
    [AllowNull]
    public EntityReference CreatedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// DocumentOrder CreatedDate
    /// </summary>
    public DateTime? CreatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentOrder DocumentAudit
    /// </summary>
    [AllowNull]
    public DocumentAudit DocumentAudit { get => GetEntity<DocumentAudit>(); set => SetEntity(value); }

    /// <summary>
    /// DocumentOrder DocumentFields
    /// </summary>
    public object? DocumentFields { get => GetValue<object?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentOrder Documents
    /// </summary>
    [AllowNull]
    public IList<OrderedDocument> Documents { get => GetList<OrderedDocument>(); set => SetList(value); }

    /// <summary>
    /// DocumentOrder Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentOrder LastModifiedDate
    /// </summary>
    public DateTime? LastModifiedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentOrder OrderId
    /// </summary>
    public string? OrderId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentOrder OrderType
    /// </summary>
    public StringEnumValue<OrderType> OrderType { get => GetValue<StringEnumValue<OrderType>>(); set => SetValue(value); }
}