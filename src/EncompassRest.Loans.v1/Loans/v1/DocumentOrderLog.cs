using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// DocumentOrderLog
/// </summary>
public sealed partial class DocumentOrderLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// DocumentOrderLog DateFilesPurged
    /// </summary>
    public DateTime? DateFilesPurged { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentOrderLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentOrderLog DocumentAudit
    /// </summary>
    public DocumentAudit? DocumentAudit { get => GetValue<DocumentAudit?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentOrderLog DocumentFields
    /// </summary>
    [AllowNull]
    public IDictionary<string, string?> DocumentFields { get => GetDictionary<string, string?>(); set => SetDictionary(value); }

    /// <summary>
    /// DocumentOrderLog OrderedDocuments
    /// </summary>
    [AllowNull]
    public IList<OrderedDocument> OrderedDocuments { get => GetList<OrderedDocument>(); set => SetList(value); }

    /// <summary>
    /// DocumentOrderLog OrderId
    /// </summary>
    public string? OrderId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentOrderLog OrderType
    /// </summary>
    public StringEnumValue<OrderType> OrderType { get => GetValue<StringEnumValue<OrderType>>(); set => SetValue(value); }

    /// <summary>
    /// DocumentOrderLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentOrderLog UserId
    /// </summary>
    public string? UserId { get => GetValue<string?>(); set => SetValue(value); }
}