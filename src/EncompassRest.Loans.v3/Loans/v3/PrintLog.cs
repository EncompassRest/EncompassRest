using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// PrintLog
/// </summary>
public sealed partial class PrintLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _action;
    private DirtyList<LogAlert>? _alerts;
    private DirtyList<LogComment>? _commentList;
    private DirtyValue<string?>? _comments;
    private DirtyValue<DateTime?>? _date;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _printedBy;
    private DirtyValue<string?>? _printedByFullName;
    private DirtyList<PrintForm>? _printForms;

    /// <summary>
    /// PrintLogContract Action
    /// </summary>
    public string? Action { get => _action; set => SetField(ref _action, value); }

    /// <summary>
    /// PrintLogContract Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

    /// <summary>
    /// PrintLogContract CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

    /// <summary>
    /// PrintLogContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// PrintLogContract Date
    /// </summary>
    public DateTime? Date { get => _date; set => SetField(ref _date, value); }

    /// <summary>
    /// PrintLogContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// PrintLogContract PrintedBy
    /// </summary>
    public string? PrintedBy { get => _printedBy; set => SetField(ref _printedBy, value); }

    /// <summary>
    /// PrintLogContract PrintedByFullName
    /// </summary>
    public string? PrintedByFullName { get => _printedByFullName; set => SetField(ref _printedByFullName, value); }

    /// <summary>
    /// PrintLogContract PrintForms
    /// </summary>
    [AllowNull]
    public IList<PrintForm> PrintForms { get => GetField(ref _printForms); set => SetField(ref _printForms, value); }
}