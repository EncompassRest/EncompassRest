using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans
{
    /// <summary>
    /// DocumentAudit
    /// </summary>
    public sealed partial class DocumentAudit : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyList<DocumentAuditAlert>? _alerts;
        private DirtyValue<string?>? _reportKey;
        private DirtyValue<DateTime?>? _timeStamp;

        /// <summary>
        /// DocumentAudit Alerts
        /// </summary>
        [AllowNull]
        public IList<DocumentAuditAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

        /// <summary>
        /// DocumentAudit ReportKey
        /// </summary>
        public string? ReportKey { get => _reportKey; set => SetField(ref _reportKey, value); }

        /// <summary>
        /// DocumentAudit TimeStamp
        /// </summary>
        public DateTime? TimeStamp { get => _timeStamp; set => SetField(ref _timeStamp, value); }
    }
}