using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// ConversationLog
/// </summary>
public sealed partial class ConversationLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// ConversationLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// ConversationLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// ConversationLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ConversationLog Company
    /// </summary>
    public string? Company { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ConversationLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ConversationLog Email
    /// </summary>
    public string? Email { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ConversationLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ConversationLog Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ConversationLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ConversationLog InLogIndicator
    /// </summary>
    public bool? InLogIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ConversationLog IsEmailIndicator
    /// </summary>
    public bool? IsEmailIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ConversationLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ConversationLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ConversationLog Name
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ConversationLog Phone
    /// </summary>
    public string? Phone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ConversationLog SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ConversationLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ConversationLog UserId
    /// </summary>
    public string? UserId { get => GetValue<string?>(); set => SetValue(value); }
}