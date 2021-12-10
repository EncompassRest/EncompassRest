using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ComplianceTestLog
/// </summary>
public sealed partial class ComplianceTestLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyList<LogAlert>? _alerts;
    private DirtyList<LogComment>? _commentList;
    private DirtyValue<DateTime?>? _date;
    private DirtyValue<string?>? _details;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _name;
    private DirtyValue<string?>? _result;
    private DirtyValue<bool?>? _showAlert;

    /// <summary>
    /// ComplianceTestLogContract Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

    /// <summary>
    /// ComplianceTestLogContract CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

    /// <summary>
    /// ComplianceTestLogContract Date
    /// </summary>
    public DateTime? Date { get => _date; set => SetField(ref _date, value); }

    /// <summary>
    /// ComplianceTestLogContract Details
    /// </summary>
    public string? Details { get => _details; set => SetField(ref _details, value); }

    /// <summary>
    /// ComplianceTestLogContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// ComplianceTestLogContract Name
    /// </summary>
    public string? Name { get => _name; set => SetField(ref _name, value); }

    /// <summary>
    /// ComplianceTestLogContract Result
    /// </summary>
    public string? Result { get => _result; set => SetField(ref _result, value); }

    /// <summary>
    /// ComplianceTestLogContract ShowAlert
    /// </summary>
    public bool? ShowAlert { get => _showAlert; set => SetField(ref _showAlert, value); }
}