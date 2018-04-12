#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class DocumentAudit : ExtensibleObject, IIdentifiable
    {
        private DirtyList<DocumentAuditAlert> _alerts;
        public IList<DocumentAuditAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<DocumentAuditAlert>()); set => _alerts = new DirtyList<DocumentAuditAlert>(value); }
        private DirtyValue<string> _reportKey;
        public string ReportKey { get => _reportKey; set => _reportKey = value; }
        private DirtyValue<DateTime?> _timeStamp;
        public DateTime? TimeStamp { get => _timeStamp; set => _timeStamp = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _reportKey.Dirty
                    || _timeStamp.Dirty
                    || _alerts?.Dirty == true;
            }
            set
            {
                _reportKey.Dirty = value;
                _timeStamp.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
            }
        }
    }
}