using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// DocumentAudit
/// </summary>
public sealed partial class DocumentAudit : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// DocumentAudit Alerts
    /// </summary>
    [AllowNull]
    public IList<DocumentAuditAlert> Alerts { get => GetList<DocumentAuditAlert>(); set => SetList(value); }

    /// <summary>
    /// DocumentAudit ReportKey
    /// </summary>
    public string? ReportKey { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentAudit TimeStamp
    /// </summary>
    public DateTime? TimeStamp { get => GetValue<DateTime?>(); set => SetValue(value); }
}