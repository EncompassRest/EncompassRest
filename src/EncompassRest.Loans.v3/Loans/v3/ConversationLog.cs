using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

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
    /// ConversationLog CreatedBy
    /// </summary>
    [AllowNull]
    public EntityReference CreatedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// ConversationLog CreatedDate
    /// </summary>
    public DateTime? CreatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ConversationLog Email
    /// </summary>
    public string? Email { get => GetValue<string?>(); set => SetValue(value); }

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
    /// ConversationLog Name
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ConversationLog Phone
    /// </summary>
    public string? Phone { get => GetValue<string?>(); set => SetValue(value); }
}