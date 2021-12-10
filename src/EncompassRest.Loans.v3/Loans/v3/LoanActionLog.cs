using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LoanActionLog
/// </summary>
public sealed partial class LoanActionLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyList<LogAlert>? _alerts;
    private DirtyList<LogComment>? _commentList;
    private DirtyValue<string?>? _comments;
    private DirtyValue<DateTime?>? _date;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _loanActionType;
    private DirtyValue<string?>? _triggeredBy;

    /// <summary>
    /// LoanActionLogContract Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

    /// <summary>
    /// LoanActionLogContract CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

    /// <summary>
    /// LoanActionLogContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// LoanActionLogContract Date
    /// </summary>
    public DateTime? Date { get => _date; set => SetField(ref _date, value); }

    /// <summary>
    /// LoanActionLogContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// LoanActionLogContract LoanActionType
    /// </summary>
    public string? LoanActionType { get => _loanActionType; set => SetField(ref _loanActionType, value); }

    /// <summary>
    /// LoanActionLogContract TriggeredBy
    /// </summary>
    public string? TriggeredBy { get => _triggeredBy; set => SetField(ref _triggeredBy, value); }
}