namespace EncompassRest.Loans
{
    /// <summary>
    /// LogSnapshotField
    /// </summary>
    public sealed partial class LogSnapshotField : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _fieldID;
        private DirtyValue<string> _id;
        private DirtyValue<string> _modalPath;
        private DirtyValue<string> _value;

        /// <summary>
        /// LogSnapshotField FieldID
        /// </summary>
        public string FieldID { get => _fieldID; set => SetField(ref _fieldID, value); }

        /// <summary>
        /// LogSnapshotField Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// LogSnapshotField ModalPath
        /// </summary>
        public string ModalPath { get => _modalPath; set => SetField(ref _modalPath, value); }

        /// <summary>
        /// LogSnapshotField Value
        /// </summary>
        public string Value { get => _value; set => SetField(ref _value, value); }
    }
}