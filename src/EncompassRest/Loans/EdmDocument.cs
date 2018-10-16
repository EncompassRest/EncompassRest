namespace EncompassRest.Loans
{
    /// <summary>
    /// EdmDocument
    /// </summary>
    public sealed partial class EdmDocument : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        private DirtyValue<string> _title;

        /// <summary>
        /// EdmDocument Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// EdmDocument Title
        /// </summary>
        public string Title { get => _title; set => SetField(ref _title, value); }
    }
}