namespace EncompassApi.Loans
{
    /// <summary>
    /// EmailDocument
    /// </summary>
    public sealed partial class EmailDocument : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _docId;
        private DirtyValue<string?>? _docTitle;

        /// <summary>
        /// EmailDocument DocId
        /// </summary>
        public string? DocId { get => _docId; set => SetField(ref _docId, value); }

        /// <summary>
        /// EmailDocument DocTitle
        /// </summary>
        public string? DocTitle { get => _docTitle; set => SetField(ref _docTitle, value); }
    }
}