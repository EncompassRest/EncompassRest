namespace EncompassRest.Loans
{
    /// <summary>
    /// FieldLockData
    /// </summary>
    public sealed partial class FieldLockData : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _lockRemoved;
        internal DirtyValue<string> _modelPath;
        private DirtyValue<string> _value;

        /// <summary>
        /// FieldLockData LockRemoved
        /// </summary>
        public bool? LockRemoved { get => _lockRemoved; set => SetField(ref _lockRemoved, value); }

        /// <summary>
        /// FieldLockData ModelPath
        /// </summary>
        public string ModelPath { get => _modelPath; set => SetField(ref _modelPath, value); }

        /// <summary>
        /// FieldLockData Value
        /// </summary>
        public string Value { get => _value; set => SetField(ref _value, value); }
    }
}