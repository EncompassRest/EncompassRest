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
        public DateTime? DateFilesPurged { get => _dateFilesPurged; set => SetField(ref _dateFilesPurged, value); }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// DocumentOrderLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }
        private DocumentAudit _documentAudit;
        /// <summary>
        /// DocumentOrderLog DocumentAudit
        /// </summary>
        public DocumentAudit DocumentAudit { get => GetField(ref _documentAudit); set => SetField(ref _documentAudit, value); }
        private DirtyDictionary<string, string> _documentFields;
        /// <summary>
        /// DocumentOrderLog DocumentFields
        /// </summary>
        public IDictionary<string, string> DocumentFields { get => GetField(ref _documentFields); set => SetField(ref _documentFields, value); }
        private DirtyList<OrderedDocument> _orderedDocuments;
        /// <summary>
        /// DocumentOrderLog OrderedDocuments
        /// </summary>
        public IList<OrderedDocument> OrderedDocuments { get => GetField(ref _orderedDocuments); set => SetField(ref _orderedDocuments, value); }
        private DirtyValue<string> _orderId;
        /// <summary>
        /// DocumentOrderLog OrderId
        /// </summary>
        public string OrderId { get => _orderId; set => SetField(ref _orderId, value); }
        private DirtyValue<string> _orderType;
        /// <summary>
        /// DocumentOrderLog OrderType
        /// </summary>
        public string OrderType { get => _orderType; set => SetField(ref _orderType, value); }
        private DirtyValue<string> _userId;
        /// <summary>
        /// DocumentOrderLog UserId
        /// </summary>
        public string UserId { get => _userId; set => SetField(ref _userId, value); }
    }
}