using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans
{
    /// <summary>
    /// DocumentOrderLog
    /// </summary>
    public sealed partial class DocumentOrderLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?>? _dateFilesPurged;
        private DirtyValue<DateTime?>? _dateUtc;
        private DirtyValue<DocumentAudit>? _documentAudit;
        private DirtyDictionary<string, string?>? _documentFields;
        private DirtyList<OrderedDocument>? _orderedDocuments;
        private DirtyValue<string?>? _orderId;
        private DirtyValue<string?>? _orderType;
        private DirtyValue<DateTime?>? _updatedDateUtc;
        private DirtyValue<string?>? _userId;

        /// <summary>
        /// DocumentOrderLog DateFilesPurged
        /// </summary>
        public DateTime? DateFilesPurged { get => _dateFilesPurged; set => SetField(ref _dateFilesPurged, value); }

        /// <summary>
        /// DocumentOrderLog DateUtc
        /// </summary>
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

        /// <summary>
        /// DocumentOrderLog DocumentAudit (Nullable)
        /// </summary>
        public DocumentAudit DocumentAudit { get => _documentAudit; set => SetField(ref _documentAudit, value); }

        /// <summary>
        /// DocumentOrderLog DocumentFields
        /// </summary>
        [AllowNull]
        public IDictionary<string, string?> DocumentFields { get => GetField(ref _documentFields); set => SetField(ref _documentFields, value); }

        /// <summary>
        /// DocumentOrderLog OrderedDocuments
        /// </summary>
        [AllowNull]
        public IList<OrderedDocument> OrderedDocuments { get => GetField(ref _orderedDocuments); set => SetField(ref _orderedDocuments, value); }

        /// <summary>
        /// DocumentOrderLog OrderId
        /// </summary>
        public string? OrderId { get => _orderId; set => SetField(ref _orderId, value); }

        /// <summary>
        /// DocumentOrderLog OrderType
        /// </summary>
        public string? OrderType { get => _orderType; set => SetField(ref _orderType, value); }

        /// <summary>
        /// DocumentOrderLog UpdatedDateUtc
        /// </summary>
        public DateTime? UpdatedDateUtc { get => _updatedDateUtc; set => SetField(ref _updatedDateUtc, value); }

        /// <summary>
        /// DocumentOrderLog UserId
        /// </summary>
        public string? UserId { get => _userId; set => SetField(ref _userId, value); }
    }
}