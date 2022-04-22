using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// EmailTriggerLog
/// </summary>
public sealed partial class EmailTriggerLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// EmailTriggerLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// EmailTriggerLog Body
    /// </summary>
    public string? Body { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EmailTriggerLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// EmailTriggerLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EmailTriggerLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EmailTriggerLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// EmailTriggerLog Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EmailTriggerLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EmailTriggerLog InLogIndicator
    /// </summary>
    public bool? InLogIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// EmailTriggerLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// EmailTriggerLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// EmailTriggerLog Recipients
    /// </summary>
    public string? Recipients { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EmailTriggerLog Sender
    /// </summary>
    public string? Sender { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EmailTriggerLog Subject
    /// </summary>
    public string? Subject { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EmailTriggerLog SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EmailTriggerLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }
}