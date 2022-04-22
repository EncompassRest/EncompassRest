using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LogEntryLog
/// </summary>
public sealed partial class LogEntryLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LogEntryLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// LogEntryLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// LogEntryLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LogEntryLog Date
    /// </summary>
    public DateTime? Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LogEntryLog Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LogEntryLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LogEntryLog UserId
    /// </summary>
    public string? UserId { get => GetValue<string?>(); set => SetValue(value); }
}