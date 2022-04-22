using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// LoanActionLog
/// </summary>
public sealed partial class LoanActionLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LoanActionLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// LoanActionLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// LoanActionLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanActionLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LoanActionLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanActionLog LoanActionType
    /// </summary>
    public string? LoanActionType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanActionLog TriggeredBy
    /// </summary>
    public string? TriggeredBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanActionLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }
}