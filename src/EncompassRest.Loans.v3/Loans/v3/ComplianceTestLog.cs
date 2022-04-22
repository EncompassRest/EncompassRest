using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ComplianceTestLog
/// </summary>
public sealed partial class ComplianceTestLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// ComplianceTestLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// ComplianceTestLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// ComplianceTestLog Date
    /// </summary>
    public DateTime? Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ComplianceTestLog Details
    /// </summary>
    public string? Details { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ComplianceTestLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ComplianceTestLog Name
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ComplianceTestLog Result
    /// </summary>
    public string? Result { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ComplianceTestLog ShowAlert
    /// </summary>
    public bool? ShowAlert { get => GetValue<bool?>(); set => SetValue(value); }
}