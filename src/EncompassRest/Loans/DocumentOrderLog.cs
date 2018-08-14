using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// DocumentOrderLog
    /// </summary>
    public sealed partial class DocumentOrderLog : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _dateFilesPurged;
        /// <summary>
        /// DocumentOrderLog DateFilesPurged
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateFilesPurged { get => _dateFilesPurged; set => _dateFilesPurged = value; }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// DocumentOrderLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DocumentAudit _documentAudit;
        /// <summary>
        /// DocumentOrderLog DocumentAudit
        /// </summary>
        public DocumentAudit DocumentAudit { get => _documentAudit ?? (_documentAudit = new DocumentAudit()); set => _documentAudit = value; }
        private DirtyDictionary<string, string> _documentFields;
        /// <summary>
        /// DocumentOrderLog DocumentFields
        /// </summary>
        public IDictionary<string, string> DocumentFields { get => _documentFields ?? (_documentFields = new DirtyDictionary<string, string>(StringComparer.OrdinalIgnoreCase)); set => _documentFields = new DirtyDictionary<string, string>(value, StringComparer.OrdinalIgnoreCase); }
        private DirtyList<OrderedDocument> _orderedDocuments;
        /// <summary>
        /// DocumentOrderLog OrderedDocuments
        /// </summary>
        public IList<OrderedDocument> OrderedDocuments { get => _orderedDocuments ?? (_orderedDocuments = new DirtyList<OrderedDocument>()); set => _orderedDocuments = new DirtyList<OrderedDocument>(value); }
        private DirtyValue<string> _orderId;
        /// <summary>
        /// DocumentOrderLog OrderId
        /// </summary>
        public string OrderId { get => _orderId; set => _orderId = value; }
        private DirtyValue<string> _orderType;
        /// <summary>
        /// DocumentOrderLog OrderType
        /// </summary>
        public string OrderType { get => _orderType; set => _orderType = value; }
        private DirtyValue<string> _userId;
        /// <summary>
        /// DocumentOrderLog UserId
        /// </summary>
        public string UserId { get => _userId; set => _userId = value; }
    }
}