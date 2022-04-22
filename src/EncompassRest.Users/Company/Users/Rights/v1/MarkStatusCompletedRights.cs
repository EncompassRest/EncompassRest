namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// MarkStatusCompletedRights
    /// </summary>
    public sealed class MarkStatusCompletedRights : DirtyExtensibleObject
    {
        /// <summary>
        /// MarkStatusCompletedRights Cleared
        /// </summary>
        public bool? Cleared { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MarkStatusCompletedRights Fulfilled
        /// </summary>
        public bool? Fulfilled { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MarkStatusCompletedRights Received
        /// </summary>
        public bool? Received { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MarkStatusCompletedRights Rejected
        /// </summary>
        public bool? Rejected { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MarkStatusCompletedRights Reviewed
        /// </summary>
        public bool? Reviewed { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MarkStatusCompletedRights Waived
        /// </summary>
        public bool? Waived { get => GetValue<bool?>(); set => SetValue(value); }
    }
}