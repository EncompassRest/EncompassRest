using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// DocumentAudit
    /// </summary>
    public sealed partial class DocumentAudit : ExtensibleObject, IIdentifiable
    {
        private DirtyList<DocumentAuditAlert> _alerts;
        /// <summary>
        /// DocumentAudit Alerts
        /// </summary>
        public IList<DocumentAuditAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<DocumentAuditAlert>()); set => _alerts = new DirtyList<DocumentAuditAlert>(value); }
        private DirtyValue<string> _reportKey;
        /// <summary>
        /// DocumentAudit ReportKey
        /// </summary>
        public string ReportKey { get => _reportKey; set => _reportKey = value; }
        private DirtyValue<DateTime?> _timeStamp;
        /// <summary>
        /// DocumentAudit TimeStamp
        /// </summary>
        public DateTime? TimeStamp { get => _timeStamp; set => _timeStamp = value; }
        internal override bool DirtyInternal
        {
            get => _reportKey.Dirty
                || _timeStamp.Dirty
                || _alerts?.Dirty == true;
            set
            {
                _reportKey.Dirty = value;
                _timeStamp.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
            }
        }
    }
}