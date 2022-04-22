using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// HtmlEmailLog
/// </summary>
public sealed partial class HtmlEmailLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// HtmlEmailLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// HtmlEmailLog Body
    /// </summary>
    public string? Body { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HtmlEmailLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// HtmlEmailLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HtmlEmailLog Creator
    /// </summary>
    public string? Creator { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HtmlEmailLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HtmlEmailLog Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HtmlEmailLog DocList
    /// </summary>
    [AllowNull]
    public IList<EmailDocument> DocList { get => GetList<EmailDocument>(); set => SetList(value); }

    /// <summary>
    /// HtmlEmailLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HtmlEmailLog Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HtmlEmailLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HtmlEmailLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HtmlEmailLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HtmlEmailLog ReadReceipt
    /// </summary>
    public bool? ReadReceipt { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HtmlEmailLog Recipient
    /// </summary>
    public string? Recipient { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HtmlEmailLog Sender
    /// </summary>
    public string? Sender { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HtmlEmailLog Subject
    /// </summary>
    public string? Subject { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HtmlEmailLog SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HtmlEmailLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }
}