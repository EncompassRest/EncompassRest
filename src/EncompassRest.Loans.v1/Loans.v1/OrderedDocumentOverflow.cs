namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// OrderedDocumentOverflow
    /// </summary>
    public sealed partial class OrderedDocumentOverflow : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _coordinateBottom;
        private DirtyValue<string?>? _coordinateLeft;
        private DirtyValue<string?>? _coordinateRight;
        private DirtyValue<string?>? _coordinateTop;
        private DirtyValue<string?>? _originalText;
        private DirtyValue<int?>? _pageNumber;
        private DirtyValue<string?>? _templateFieldName;

        /// <summary>
        /// OrderedDocumentOverflow CoordinateBottom
        /// </summary>
        public string? CoordinateBottom { get => _coordinateBottom; set => SetField(ref _coordinateBottom, value); }

        /// <summary>
        /// OrderedDocumentOverflow CoordinateLeft
        /// </summary>
        public string? CoordinateLeft { get => _coordinateLeft; set => SetField(ref _coordinateLeft, value); }

        /// <summary>
        /// OrderedDocumentOverflow CoordinateRight
        /// </summary>
        public string? CoordinateRight { get => _coordinateRight; set => SetField(ref _coordinateRight, value); }

        /// <summary>
        /// OrderedDocumentOverflow CoordinateTop
        /// </summary>
        public string? CoordinateTop { get => _coordinateTop; set => SetField(ref _coordinateTop, value); }

        /// <summary>
        /// OrderedDocumentOverflow OriginalText
        /// </summary>
        public string? OriginalText { get => _originalText; set => SetField(ref _originalText, value); }

        /// <summary>
        /// OrderedDocumentOverflow PageNumber
        /// </summary>
        public int? PageNumber { get => _pageNumber; set => SetField(ref _pageNumber, value); }

        /// <summary>
        /// OrderedDocumentOverflow TemplateFieldName
        /// </summary>
        public string? TemplateFieldName { get => _templateFieldName; set => SetField(ref _templateFieldName, value); }
    }
}