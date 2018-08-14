using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// OrderedDocumentOverflow
    /// </summary>
    public sealed partial class OrderedDocumentOverflow : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _coordinateBottom;
        /// <summary>
        /// OrderedDocumentOverflow CoordinateBottom
        /// </summary>
        public string CoordinateBottom { get => _coordinateBottom; set => _coordinateBottom = value; }
        private DirtyValue<string> _coordinateLeft;
        /// <summary>
        /// OrderedDocumentOverflow CoordinateLeft
        /// </summary>
        public string CoordinateLeft { get => _coordinateLeft; set => _coordinateLeft = value; }
        private DirtyValue<string> _coordinateRight;
        /// <summary>
        /// OrderedDocumentOverflow CoordinateRight
        /// </summary>
        public string CoordinateRight { get => _coordinateRight; set => _coordinateRight = value; }
        private DirtyValue<string> _coordinateTop;
        /// <summary>
        /// OrderedDocumentOverflow CoordinateTop
        /// </summary>
        public string CoordinateTop { get => _coordinateTop; set => _coordinateTop = value; }
        private DirtyValue<string> _originalText;
        /// <summary>
        /// OrderedDocumentOverflow OriginalText
        /// </summary>
        public string OriginalText { get => _originalText; set => _originalText = value; }
        private DirtyValue<int?> _pageNumber;
        /// <summary>
        /// OrderedDocumentOverflow PageNumber
        /// </summary>
        public int? PageNumber { get => _pageNumber; set => _pageNumber = value; }
        private DirtyValue<string> _templateFieldName;
        /// <summary>
        /// OrderedDocumentOverflow TemplateFieldName
        /// </summary>
        public string TemplateFieldName { get => _templateFieldName; set => _templateFieldName = value; }
    }
}