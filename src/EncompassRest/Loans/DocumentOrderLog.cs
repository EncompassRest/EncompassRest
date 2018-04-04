#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class DocumentOrderLog : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _dateFilesPurged;
        public DateTime? DateFilesPurged { get => _dateFilesPurged; set => _dateFilesPurged = value; }
        private DirtyValue<DateTime?> _dateUtc;
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DocumentAudit _documentAudit;
        public DocumentAudit DocumentAudit { get => _documentAudit ?? (_documentAudit = new DocumentAudit()); set => _documentAudit = value; }
        private DirtyDictionary<string, string> _documentFields;
        public IDictionary<string, string> DocumentFields { get => _documentFields ?? (_documentFields = new DirtyDictionary<string, string>(StringComparer.OrdinalIgnoreCase)); set => _documentFields = new DirtyDictionary<string, string>(value, StringComparer.OrdinalIgnoreCase); }
        private DirtyValue<string> _orderId;
        public string OrderId { get => _orderId; set => _orderId = value; }
        private DirtyValue<string> _orderType;
        public string OrderType { get => _orderType; set => _orderType = value; }
        private DirtyValue<string> _userId;
        public string UserId { get => _userId; set => _userId = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _dateFilesPurged.Dirty
                    || _dateUtc.Dirty
                    || _orderId.Dirty
                    || _orderType.Dirty
                    || _userId.Dirty
                    || _documentAudit?.Dirty == true
                    || _documentFields?.Dirty == true;
            }
            set
            {
                _dateFilesPurged.Dirty = value;
                _dateUtc.Dirty = value;
                _orderId.Dirty = value;
                _orderType.Dirty = value;
                _userId.Dirty = value;
                if (_documentAudit != null) _documentAudit.Dirty = value;
                if (_documentFields != null) _documentFields.Dirty = value;
            }
        }
    }
}