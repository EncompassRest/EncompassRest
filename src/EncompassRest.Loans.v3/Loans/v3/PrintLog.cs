using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// PrintLog
/// </summary>
public sealed partial class PrintLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PrintLog Action
    /// </summary>
    public string? Action { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrintLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// PrintLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// PrintLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrintLog Date
    /// </summary>
    public DateTime? Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PrintLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrintLog PrintedBy
    /// </summary>
    public string? PrintedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrintLog PrintedByFullName
    /// </summary>
    public string? PrintedByFullName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrintLog PrintForms
    /// </summary>
    [AllowNull]
    public IList<PrintForm> PrintForms { get => GetList<PrintForm>(); set => SetList(value); }
}