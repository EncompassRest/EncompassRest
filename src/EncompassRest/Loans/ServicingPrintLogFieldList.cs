namespace EncompassRest.Loans
{
    /// <summary>
    /// ServicingPrintLogFieldList
    /// </summary>
    public sealed partial class ServicingPrintLogFieldList : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;

        /// <summary>
        /// ServicingPrintLogFieldList Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
    }
}