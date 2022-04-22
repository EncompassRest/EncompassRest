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
    /// <summary>
    /// DocumentAudit Alerts
    /// </summary>
    [AllowNull]
    public IList<DocumentAuditAlert> Alerts { get => GetList<DocumentAuditAlert>(); set => SetList(value); }

    /// <summary>
    /// DocumentAudit AuditDateTime
    /// </summary>
    public DateTime? AuditDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentAudit ReportKey
    /// </summary>
    public string? ReportKey { get => GetValue<string?>(); set => SetValue(value); }
}