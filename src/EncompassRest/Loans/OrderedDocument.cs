using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// OrderedDocument
    /// </summary>
    public sealed partial class OrderedDocument : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _category;
        /// <summary>
        /// OrderedDocument Category
        /// </summary>
        public string Category { get => _category; set => _category = value; }
        private DirtyValue<string> _dataKey;
        /// <summary>
        /// OrderedDocument DataKey
        /// </summary>
        public string DataKey { get => _dataKey; set => _dataKey = value; }
        private DirtyValue<string> _documentServiceId;
        /// <summary>
        /// OrderedDocument DocumentServiceId
        /// </summary>
        public string DocumentServiceId { get => _documentServiceId; set => _documentServiceId = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// OrderedDocument Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _overflowDataKey;
        /// <summary>
        /// OrderedDocument OverflowDataKey
        /// </summary>
        public string OverflowDataKey { get => _overflowDataKey; set => _overflowDataKey = value; }
        private DirtyList<OrderedDocumentOverflow> _overflows;
        /// <summary>
        /// OrderedDocument Overflows
        /// </summary>
        public IList<OrderedDocumentOverflow> Overflows { get => _overflows ?? (_overflows = new DirtyList<OrderedDocumentOverflow>()); set => _overflows = new DirtyList<OrderedDocumentOverflow>(value); }
        private DirtyValue<string> _pairId;
        /// <summary>
        /// OrderedDocument PairId
        /// </summary>
        public string PairId { get => _pairId; set => _pairId = value; }
        private DirtyValue<string> _signatureType;
        /// <summary>
        /// OrderedDocument SignatureType
        /// </summary>
        public string SignatureType { get => _signatureType; set => _signatureType = value; }
        private DirtyValue<int?> _size;
        /// <summary>
        /// OrderedDocument Size
        /// </summary>
        public int? Size { get => _size; set => _size = value; }
        private DirtyValue<string> _templateId;
        /// <summary>
        /// OrderedDocument TemplateId
        /// </summary>
        public string TemplateId { get => _templateId; set => _templateId = value; }
        private DirtyValue<string> _title;
        /// <summary>
        /// OrderedDocument Title
        /// </summary>
        public string Title { get => _title; set => _title = value; }
        private DirtyValue<string> _type;
        /// <summary>
        /// OrderedDocument Type
        /// </summary>
        public string Type { get => _type; set => _type = value; }
    }
}