namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// MarkStatusCompletedRights
    /// </summary>
    public sealed class MarkStatusCompletedRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _cleared;
        private DirtyValue<bool?>? _fulfilled;
        private DirtyValue<bool?>? _received;
        private DirtyValue<bool?>? _rejected;
        private DirtyValue<bool?>? _reviewed;
        private DirtyValue<bool?>? _waived;

        /// <summary>
        /// MarkStatusCompletedRights Cleared
        /// </summary>
        public bool? Cleared { get => _cleared; set => SetField(ref _cleared, value); }

        /// <summary>
        /// MarkStatusCompletedRights Fulfilled
        /// </summary>
        public bool? Fulfilled { get => _fulfilled; set => SetField(ref _fulfilled, value); }

        /// <summary>
        /// MarkStatusCompletedRights Received
        /// </summary>
        public bool? Received { get => _received; set => SetField(ref _received, value); }

        /// <summary>
        /// MarkStatusCompletedRights Rejected
        /// </summary>
        public bool? Rejected { get => _rejected; set => SetField(ref _rejected, value); }

        /// <summary>
        /// MarkStatusCompletedRights Reviewed
        /// </summary>
        public bool? Reviewed { get => _reviewed; set => SetField(ref _reviewed, value); }

        /// <summary>
        /// MarkStatusCompletedRights Waived
        /// </summary>
        public bool? Waived { get => _waived; set => SetField(ref _waived, value); }
    }
}