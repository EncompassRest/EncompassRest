using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// DocumentAudit
    /// </summary>
    public sealed partial class DocumentAudit : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyList<DocumentAuditAlert> _alerts;
        /// <summary>
        /// DocumentAudit Alerts
        /// </summary>
        public IList<DocumentAuditAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }
        private DirtyValue<string> _reportKey;
        /// <summary>
        /// DocumentAudit ReportKey
        /// </summary>
        public string ReportKey { get => _reportKey; set => SetField(ref _reportKey, value); }
        private DirtyValue<DateTime?> _timeStamp;
        /// <summary>
        /// DocumentAudit TimeStamp
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? TimeStamp { get => _timeStamp; set => SetField(ref _timeStamp, value); }
    }
}