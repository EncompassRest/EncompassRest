using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassApi.Loans
{
    /// <summary>
    /// OrderedDocument
    /// </summary>
    public sealed partial class OrderedDocument : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _category;
        private DirtyValue<string?>? _dataKey;
        private DirtyValue<string?>? _documentServiceId;
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _overflowDataKey;
        private DirtyList<OrderedDocumentOverflow>? _overflows;
        private DirtyValue<string?>? _pairId;
        private DirtyValue<string?>? _signatureType;
        private DirtyValue<int?>? _size;
        private DirtyValue<string?>? _templateId;
        private DirtyValue<string?>? _title;
        private DirtyValue<string?>? _type;

        /// <summary>
        /// OrderedDocument Category
        /// </summary>
        public string? Category { get => _category; set => SetField(ref _category, value); }

        /// <summary>
        /// OrderedDocument DataKey
        /// </summary>
        public string? DataKey { get => _dataKey; set => SetField(ref _dataKey, value); }

        /// <summary>
        /// OrderedDocument DocumentServiceId
        /// </summary>
        public string? DocumentServiceId { get => _documentServiceId; set => SetField(ref _documentServiceId, value); }

        /// <summary>
        /// OrderedDocument Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// OrderedDocument OverflowDataKey
        /// </summary>
        public string? OverflowDataKey { get => _overflowDataKey; set => SetField(ref _overflowDataKey, value); }

        /// <summary>
        /// OrderedDocument Overflows
        /// </summary>
        [AllowNull]
        public IList<OrderedDocumentOverflow> Overflows { get => GetField(ref _overflows); set => SetField(ref _overflows, value); }

        /// <summary>
        /// OrderedDocument PairId
        /// </summary>
        public string? PairId { get => _pairId; set => SetField(ref _pairId, value); }

        /// <summary>
        /// OrderedDocument SignatureType
        /// </summary>
        public string? SignatureType { get => _signatureType; set => SetField(ref _signatureType, value); }

        /// <summary>
        /// OrderedDocument Size
        /// </summary>
        public int? Size { get => _size; set => SetField(ref _size, value); }

        /// <summary>
        /// OrderedDocument TemplateId
        /// </summary>
        public string? TemplateId { get => _templateId; set => SetField(ref _templateId, value); }

        /// <summary>
        /// OrderedDocument Title
        /// </summary>
        public string? Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// OrderedDocument Type
        /// </summary>
        public string? Type { get => _type; set => SetField(ref _type, value); }
    }
}