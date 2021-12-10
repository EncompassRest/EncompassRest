using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// DocumentAudit
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(AuditDateTime) + "," + nameof(ReportKey))]
public sealed partial class DocumentAudit : DirtyExtensibleObject, IIdentifiable
{
    private DirtyList<DocumentAuditAlert>? _alerts;
    private DirtyValue<DateTime?>? _auditDateTime;
    private DirtyValue<string?>? _reportKey;

    /// <summary>
    /// DocumentAuditContract Alerts
    /// </summary>
    [AllowNull]
    public IList<DocumentAuditAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

    /// <summary>
    /// DocumentAuditContract AuditDateTime
    /// </summary>
    public DateTime? AuditDateTime { get => _auditDateTime; set => SetField(ref _auditDateTime, value); }

    /// <summary>
    /// DocumentAuditContract ReportKey
    /// </summary>
    public string? ReportKey { get => _reportKey; set => SetField(ref _reportKey, value); }
}